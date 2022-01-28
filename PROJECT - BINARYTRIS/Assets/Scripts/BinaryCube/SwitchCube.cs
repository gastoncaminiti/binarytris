using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCube : MonoBehaviour
{
    [SerializeField] private Material activatedMaterial;
    [SerializeField] private Material placeholderMaterial;

    private MeshRenderer myMeshRenderer;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnMouseOver()
    {
        MouseInputHandler();
    }

    private void MouseInputHandler()
    {
        if (Input.GetMouseButtonDown(0))
        {
            setMaterial(placeholderMaterial);
        }
        if (Input.GetMouseButtonDown(1))
        {
            setMaterial(activatedMaterial);
        }
    }

    private void setMaterial(Material newMaterial)
    {
        myMeshRenderer.material = newMaterial;
    }
}
