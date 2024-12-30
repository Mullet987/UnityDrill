using UnityEngine;
using Articy.Unity;
public class InformationNPC : MonoBehaviour
{
    [HideInInspector]
    public ArticyReference articyReference;
    [HideInInspector]
    public bool isNPC;

    private void Start()
    {
        articyReference = GetComponent<ArticyReference>();
        isNPC = true;
    }
}