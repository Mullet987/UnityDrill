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

    // ī�޶� ����
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
            // �Է� ���� ���
            Vector3 inputDirection = new Vector3(Move.x, 0.0f, Move.y).normalized;

            // ī�޶��� ���� ��ǥ�踦 �������� �̵� ���� ��ȯ
            Vector3 cameraForward = CameraTransform.forward;
            Vector3 cameraRight = CameraTransform.right;

            // ī�޶��� Y���� ���� (��� �̵�)
            cameraForward.y = 0f;
            cameraRight.y = 0f;

            // ���� �̵� ���� ���
            Vector3 moveDirection = (inputDirection.x * cameraRight) + (inputDirection.z * cameraForward);

            // �̵��ϴ� �������� ĳ���Ͱ� �ٶ󺸰� ����
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle
                (transform.eulerAngles.y, //���� ����
                targetAngle, //��ǥ ����
                ref _currentVelocity, // ���� �ӵ��� ������
                smoothTime //�ε巴�� �����ϴµ� �ɸ��� �ð�
                );
            transform.rotation = Quaternion.Euler(0.0f, angle, 0.0f);

            // Rigidbody �ӵ� ����
            Rigidbody.linearVelocity = moveDirection * Speed;
        }
        else
        {
            // �Է��� ���� ��� �ӵ� 0
            Rigidbody.linearVelocity = Vector3.zero;
        }

        // �ִϸ������� Speed �Ķ���� ����
        Animator.SetFloat("Run", Rigidbody.linearVelocity.magnitude);
    }
}
