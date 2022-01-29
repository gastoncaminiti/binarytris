using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceCollision : MonoBehaviour
{
    private PieceMovement myPieceMovement;
    private SpawnManager mySpawnManager;

    private Rigidbody myRigidbody;

    private void Start()
    {
        myPieceMovement = transform.parent.GetComponent<PieceMovement>();
        mySpawnManager = GameObject.Find("Spawn").GetComponent<SpawnManager>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Base"))
        {
            Debug.Log("BASE");
            ResetPiece();
        }

        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("WALL");
            Vector3 direction = (transform.position - other.transform.position).normalized;
            myPieceMovement.transform.Translate(direction);

        }

        if (other.gameObject.CompareTag("Piece"))
        {
            myPieceMovement.stopMove();
        }
    }

    private void ResetPiece()
    {
        myPieceMovement.stopMove();
        mySpawnManager.spawnPiece();
    }
}
