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
            activateBirnaryCube(true, activatedMaterialOne, placeholderMaterialOne);
        }
        else
        {
            activateBirnaryCube(false, activatedMaterialZero, placeholderMaterialZero);
        }
    }

    private void activateBirnaryCube(bool binary, Material activatedMaterial, Material placeholderMaterial)
    {
        if (binary == isOne)
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

    public bool isZeroDeleted()
    {
        return !isOne && !isPlaceholder;
    }

    public bool isOneValid()
    {
        return isOne && !isPlaceholder;
    }
}
