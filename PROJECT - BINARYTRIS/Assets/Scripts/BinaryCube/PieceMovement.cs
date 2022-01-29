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
        /*
        if (Input.GetKeyUp(KeyCode.W) && validMove(Vector3.forward))
        {
            lastMove = Vector3.forward;
            transform.position += lastMove;
        }

        if (Input.GetKeyUp(KeyCode.S) && validMove(Vector3.back))
        {
            lastMove = Vector3.back;
            transform.position += lastMove;
        }
        */

        if (Input.GetKeyUp(KeyCode.A) && validMove(Vector3.right))
        {
            lastMove = Vector3.right;
            transform.position += lastMove;
        }

        if (Input.GetKeyUp(KeyCode.D) && validMove(Vector3.left))
        {
            lastMove = Vector3.left;
            transform.position += lastMove;
        }

        transform.Translate(new Vector3(0f, customGravity, 0f) * speedGravity * Time.deltaTime);
    }

    public void StopMove()
    {
        canMove = false;
    }

    public bool validMove(Vector3 nextDirecction)
    {
        Vector3 nextMove = transform.position + nextDirecction;

        if (nextMove.x < GridManager.Zoffset  && nextMove.x > -GridManager.Zoffset)
        {
            return true;
        }

        return false;
    }
}
