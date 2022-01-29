using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCube : MonoBehaviour
{
    [SerializeField] private Material activatedMaterialZero;
    [SerializeField] private Material activatedMaterialOne;
    [SerializeField] private Material placeholderMaterialOne;
    [SerializeField] private Material placeholderMaterialZero;

    [SerializeField] private bool isOne;
    private MeshRenderer myMeshRenderer;
    private bool isPlaceholder = true;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        setPlaceholder(placeholderMaterialZero, placeholderMaterialOne);
    }

    private void OnMouseOver()
    {
        MouseInputHandler();
    }

    private void MouseInputHandler()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ValidBinaryMaterial(!isOne, activatedMaterialZero, placeholderMaterialZero);
            isOne = false;
        }

        if (Input.GetMouseButtonDown(1))
        {
            ValidBinaryMaterial(isOne, activatedMaterialOne, placeholderMaterialOne);
            isOne = true;
        }
    }

    private void ValidBinaryMaterial(bool binary, Material activatedMaterial, Material placeholderMaterial)
    {
        if (binary)
        {
            if (isPlaceholder)
            {
                setMaterial(activatedMaterial);
            }
            else
            {
                setMaterial(placeholderMaterial);
            }
            isPlaceholder = !isPlaceholder;
        }
        else
        {
            setMaterial(placeholderMaterial);
            isPlaceholder = true;
        }
        
    }

    private void setPlaceholder(Material placeholderMaterial0, Material placeholderMaterial1)
    {
        if (isOne)
        {
            setMaterial(placeholderMaterial1);
        }
        else
        {
            setMaterial(placeholderMaterial0);
        }
    }

    private void setMaterial(Material newMaterial)
    {
        myMeshRenderer.material = newMaterial;
    }

}
