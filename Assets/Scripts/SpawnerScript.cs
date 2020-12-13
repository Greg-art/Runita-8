using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] vector;
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
        Instantiate (vector[Random.Range(0,vector.Length)], transform.position, Quaternion.Euler(-12, 10, 0));
        Invoke("Spawn", Random.Range(spawnMin,spawnMax));
    }
}