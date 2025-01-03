using Articy.Unity;
using UnityEngine;

public class InformationItem : MonoBehaviour
{
    [HideInInspector]
    public bool isClicked;
    [HideInInspector]
    public ArticyReference articyReference;
    public int itemID;

    private void Start()
    {
        articyReference = GetComponent<ArticyReference>();
        isClicked = false;
    }
}
