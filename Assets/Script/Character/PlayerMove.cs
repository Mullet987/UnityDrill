using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{

    private Rigidbody Rigidbody;
    private Animator Animator;
    private float smoothTime = 0.1f;
    private float _currentVelocity;
    private bool CharamoveActive;

    public float Speed;

    [Header("Character Input Values")]
    public Vector2 Move;

    // 카메라 참조
    public Transform CameraTransform;

    public void OnEnable()
    {
        CharamoveActive = true;
    }

    public void OnDisable()
    {
        CharamoveActive = false;
        Animator.SetFloat("Run", 0f);
        Rigidbody.linearVelocity = Vector3.zero;
    }

    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Animator = GetComponent<Animator>();
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (CharamoveActive == true)
        {
            CharaMove();
        }
    }

    public void OnMove(InputValue value)
    {
        Move = value.Get<Vector2>();
    }

    private void CharaMove()
    {
        if (Move != Vector2.zero)
        {
            // 입력 방향 계산
            Vector3 inputDirection = new Vector3(Move.x, 0.0f, Move.y).normalized;

            // 카메라의 로컬 좌표계를 기준으로 이동 방향 변환
            Vector3 cameraForward = CameraTransform.forward;
            Vector3 cameraRight = CameraTransform.right;

            // 카메라의 Y축은 제거 (평면 이동)
            cameraForward.y = 0f;
            cameraRight.y = 0f;

            // 최종 이동 방향 계산
            Vector3 moveDirection = (inputDirection.x * cameraRight) + (inputDirection.z * cameraForward);

            // 이동하는 방향으로 캐릭터가 바라보게 설정
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle
                (transform.eulerAngles.y, //현재 각도
                targetAngle, //목표 각도
                ref _currentVelocity, // 현재 속도의 참조값
                smoothTime //부드럽게 감속하는데 걸리는 시간
                );
            transform.rotation = Quaternion.Euler(0.0f, angle, 0.0f);

            // Rigidbody 속도 설정
            Rigidbody.linearVelocity = moveDirection * Speed;
        }
        else
        {
            // 입력이 없을 경우 속도 0
            Rigidbody.linearVelocity = Vector3.zero;
        }

        // 애니메이터의 Speed 파라미터 설정
        Animator.SetFloat("Run", Rigidbody.linearVelocity.magnitude);
    }
}
