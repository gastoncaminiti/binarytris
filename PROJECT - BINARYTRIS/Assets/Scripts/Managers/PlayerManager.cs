using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private float rayLenght;
    [SerializeField] LayerMask layermask;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLenght,layermask))
            {
                if (hit.collider.tag == "Cube")
                {
                    
                   hit.collider.gameObject.GetComponent<SwitchCube>().MouseInputHandler(false);
                }
            }
        }

        if (Input.GetMouseButtonDown(1) )
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLenght,layermask))
            {
                if (hit.collider.tag == "Cube")
                {
                  hit.collider.gameObject.GetComponent<SwitchCube>().MouseInputHandler(true);
                }
            }
        }
    }
}
