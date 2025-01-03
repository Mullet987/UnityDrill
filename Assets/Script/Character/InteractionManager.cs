using Articy.Unity;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    private Vector2 offset = new Vector2(0, -40);
    private Vector3 heroPosition;
    private InformationNPC npcInformation;
    private Transform heroTransform;

    [SerializeField]
    float interactionDistance;
    [SerializeField]
    ArticyflowPlayerManager flowPlayerManager;
    [SerializeField]
    GameObject uiObject;
    [SerializeField]
    RectTransform uiElement;
    [SerializeField]
    Canvas canvas;

    private void Start()
    {
        GameObject hero = GameObject.Find("HERO");
        heroTransform = hero.transform;
    }

    private void Update()
    {
        InteractionNPC();
    }

    private void InteractionNPC()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(ray, out hit))
            {
                npcInformation = hit.collider.GetComponent<InformationNPC>();
                if (npcInformation != null)
                {
                    heroPosition = heroTransform.position;
                    float distance = Vector3.Distance(npcInformation.transform.position, heroPosition);
                    if (distance <= interactionDistance && npcInformation != null)
                    {
                        bool isNPC = hit.collider.GetComponent<InformationNPC>().isNPC;
                        if (isNPC == true)
                        {
                            CahngeUIPosition();
                            uiObject.SetActive(true);
                        }
                    }
                }
            }
        }
    }

    private void CahngeUIPosition() //��ȣ�ۿ� UI�� ��Ÿ�� ��ġ�� ����
    {
        Vector2 screenPoint = Input.mousePosition;

        //��ȣ�ۿ� UI�� ��ġ�� ��ǥ��� ��ȯ
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform,
            screenPoint,
            canvas.worldCamera,
            out Vector2 localPoint
        );

        localPoint += offset;   // ������ �߰�

        uiElement.localPosition = localPoint;   // UI ��� �̵�
    }

    public void onClickTalk()
    {
        ArticyObject articyObject = npcInformation.articyReference.GetObject<ArticyObject>();
        uiObject.SetActive(false);
        flowPlayerManager.StartDialogue(articyObject);
    }
}
