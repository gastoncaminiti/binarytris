using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] pieces;
    [SerializeField] private Vector3 spawnPos;
    [SerializeField] private float spawnDelay = 2f;

    private bool canSpawn = true;

    void Start()
    {
        SpawnPiece();
    }

    public void SpawnPiece()
    {
        if(canSpawn){
           StartCoroutine(SpawnCoroutine());
        }
    }

    IEnumerator SpawnCoroutine(){
          canSpawn = false;
          int randomIndex = Random.Range(0, pieces.Length);
          Instantiate(pieces[randomIndex], spawnPos, Quaternion.identity);  
          yield return new WaitForSeconds(spawnDelay);
          canSpawn = true;
    }

}
