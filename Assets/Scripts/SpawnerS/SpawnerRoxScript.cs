using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRoxScript : MonoBehaviour
{
    public GameObject[] vetor;
    public float spawnMin;
    public float spawnMax;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();   
    }

    // Update is called once per frame
    void Spawn()
    {

        Instantiate (vetor[Random.Range(0,vetor.Length -1)], transform.position, Quaternion.Euler(-12, 10, 0));

        Invoke("Spawn", Random.Range(spawnMin,spawnMax));
    }
}