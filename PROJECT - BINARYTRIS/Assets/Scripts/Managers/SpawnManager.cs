using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] pieces;
    [SerializeField] private Vector3 spawnPos;

    void Start()
    {
        spawnPiece();
    }

    public void spawnPiece()
    {

        int randomIndex = Random.Range(0, pieces.Length);
        Instantiate(pieces[randomIndex], spawnPos, Quaternion.identity);
    }
}
