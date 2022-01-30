using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float customGravity = 2f;
    [SerializeField] private float speedGravity = 2f;
    private bool canMove = true;
    private Vector3 lastMove = new Vector3(0f, 0f, 0f);
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }

    private void Move()
    {

        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.Rotate(0, 0, 90);
        }

        if (Input.GetKeyUp(KeyCode.A) && isValidLeft())
        {
            
            if (isVertical())
            {
                transform.position += (Vector3.left + new Vector3(GridManager.vOffset,0f,0f));
            }else{
                transform.position += Vector3.left;
            }
        }

        if (Input.GetKeyUp(KeyCode.D) && isValidRight())
        {
              if (isVertical())
            {
                transform.position += (Vector3.right - new Vector3(GridManager.vOffset,0f,0f));
            }else{
                transform.position += Vector3.right;
            }
        }
        transform.position += new Vector3(0f, customGravity, 0f) * speedGravity * Time.deltaTime;
    }

    public void StopMove()
    {
        canMove = false;
    }

    bool isValidRight()
    {
        if (isVertical())
        {
            return (transform.position.x < (GridManager.Xgrid - GridManager.vOffset));
        }
        else
        {
            return transform.position.x < (GridManager.Xgrid - GridManager.hOffset);
        }
    }

    bool isValidLeft()
    {
        if (isVertical())
        {
            return (transform.position.x > (GridManager.hOffset - GridManager.vOffset));
        }
        else
        {
            return (transform.position.x > GridManager.hOffset);
        }
    }

    bool isVertical()
    {
        float zRotation = transform.rotation.eulerAngles.z;
        return (zRotation == 90 || zRotation == 270);
    }
}
