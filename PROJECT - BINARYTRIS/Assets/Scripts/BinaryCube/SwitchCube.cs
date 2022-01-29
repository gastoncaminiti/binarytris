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
    public void MouseInputHandler(bool isOne)
    {
        if (isOne)
        {
            ValidBinaryMaterial(true, activatedMaterialOne, placeholderMaterialOne);
  
        }
        else
        {
            ValidBinaryMaterial(true, activatedMaterialZero, placeholderMaterialZero);

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
