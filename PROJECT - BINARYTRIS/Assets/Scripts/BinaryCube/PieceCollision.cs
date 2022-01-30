using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceCollision : MonoBehaviour
{
    private PieceMovement myPieceMovement;
    private SpawnManager mySpawnManager;

    private Rigidbody myRigidbody;

    private Transform myCubes;

    private void Start()
    {
        myPieceMovement = transform.parent.GetComponent<PieceMovement>();
        mySpawnManager = GameObject.Find("Spawn").GetComponent<SpawnManager>();
        myRigidbody = GetComponent<Rigidbody>();
        myCubes = transform.parent.GetChild(1);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Base"))
        {
            ResetPiece();
        }

        if (other.gameObject.CompareTag("Piece"))
        {
            ResetPiece();
        }
    }

    private void ResetPiece()
    {
        myPieceMovement.StopMove();
        mySpawnManager.SpawnPiece();
        DeletedZeros();
    }

    private void DeletedZeros()
    {
        foreach (Transform child in myCubes)
        {
            if (child.GetComponent<SwitchCube>().isZeroDeleted())
            {
                Destroy(child.gameObject);
            }
        }

        AddGrid();
    }

    private void AddGrid(){
         foreach (Transform children in myCubes)
        {
            // get x,y,z position as int
            // for all childrens - in this case cubes
            //int Xpos = Mathf.RoundToInt(children.transform.position.x);
            //int Ypos = Mathf.RoundToInt(children.transform.position.y);
            Debug.Log(children.transform.position);
            //GridManager.Grid[Xpos,Ypos] = children;
        }

        Debug.Log(GridManager.Grid);
    }
}
