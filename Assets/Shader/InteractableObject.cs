using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    new Renderer renderer;
    private Material mat;
    private UnityEvent ObjMouseEnter;
    private UnityEvent ObjMouseExit;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        mat = renderer.material;
    }

    private void OnMouseEnter()
    {
        CanSeeOutline();
    }

    private void OnMouseExit()
    {
        CannotSeeOutline();
    }

    public void CanSeeOutline()
    {
        mat.SetFloat("_SAlpha", 1);
    }

    public void CannotSeeOutline()
    {
        mat.SetFloat("_SAlpha", 0);
    }
}
