using UnityEngine;
using TMPro;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System.Collections;
using Articy.Noname.GlobalVariables;

public class ItemInteractManger : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI TextMeshProUGUI;
    private InformationItem informationItem;

    private void Update()
    {
        InteractionItem();
    }

    private void InteractionItem()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                informationItem = hit.collider.GetComponent<InformationItem>();
                if (informationItem != null && informationItem.isClicked == false)
                {
                    onClickSearch();
                    if (informationItem.itemID == 1) {
                        ArticyGlobalVariables.Default.NPCs.FIND_KNIFE = true;
                    }
                    TextMeshProUGUI.gameObject.SetActive(true);
                    StartCoroutine(DisableTextMeshProAfterDelay());
                }
            }
        }
    }

    public void onClickSearch()
    {
        TextMeshProUGUI.text = string.Empty;

        ArticyObject articyObject = informationItem.articyReference.GetObject<ArticyObject>();
        if (articyObject is IObjectWithLocalizableText objWithLocalizableText)
        {
            TextMeshProUGUI.text = objWithLocalizableText.Text;
        }
        informationItem.isClicked = true;
    }

    private IEnumerator DisableTextMeshProAfterDelay()
    {
        yield return new WaitForSeconds(4f); // 4초 대기
        TextMeshProUGUI.gameObject.SetActive(false); // TextMeshPro 비활성화
    }
}
