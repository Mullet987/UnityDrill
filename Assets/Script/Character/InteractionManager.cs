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
                        #region ui창 위치 변경
                        Vector2 screenPoint = Input.mousePosition;

                        // UI 좌표계로 변환
                        RectTransformUtility.ScreenPointToLocalPointInRectangle(
                            canvas.transform as RectTransform,
                            screenPoint,
                            canvas.worldCamera,
                            out Vector2 localPoint
                        );

                        // 오프셋 추가
                        localPoint += offset;
                        // UI 요소 이동
                        uiElement.localPosition = localPoint;
                        #endregion

                        //상호작용 UI 활성화
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
