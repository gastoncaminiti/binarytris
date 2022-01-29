using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float customGravity = 2f;
    [SerializeField] private float speed = 2f;
    private bool canMove = true;
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
        float horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(speed * Time.deltaTime * new Vector3(-horizontal, customGravity, 0));
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Base"))
        {
            canMove = false;
           // GameObject.Find("Spawn").GetComponent<SpawnManager>().spawnPiece();
        }
    }
}
