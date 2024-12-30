using Articy.Unity;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    private Vector2 offset = new Vector2(0, -40);
    private InformationNPC npcInformation;

    [SerializeField]
    ArticyflowPlayerManager flowPlayerManager;
    [SerializeField]
    GameObject uiObject;
    [SerializeField]
    RectTransform uiElement;
    [SerializeField]
    Canvas canvas;

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
                    bool isNPC = hit.collider.GetComponent<InformationNPC>().isNPC;

                    if (isNPC == true)
                    {
                        #region uiâ ��ġ ����
                        Vector2 screenPoint = Input.mousePosition;

                        // UI ��ǥ��� ��ȯ
                        RectTransformUtility.ScreenPointToLocalPointInRectangle(
                            canvas.transform as RectTransform,
                            screenPoint,
                            canvas.worldCamera,
                            out Vector2 localPoint
                        );

                        // ������ �߰�
                        localPoint += offset;
                        // UI ��� �̵�
                        uiElement.localPosition = localPoint;
                        #endregion

                        //��ȣ�ۿ� UI Ȱ��ȭ
                        uiObject.SetActive(true);
                    }
                }
            }
        }
    }

    public void onClickTalk()
    {
        ArticyObject articyObject = npcInformation.articyReference.GetObject<ArticyObject>();
        uiObject.SetActive(false);
        flowPlayerManager.StartDialogue(articyObject);
    }
}
