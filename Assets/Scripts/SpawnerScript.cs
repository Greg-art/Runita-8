using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] plataformas;
    public GameObject[] obstaculos;
    public float spawnMin;
    public float spawnMax;
    public int chanceObstaculo = 30;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();   
    }

    // Update is called once per frame
    void Spawn()
    {
        int escolha = Random.Range(0,100);
        if (escolha < chanceObstaculo){
            Debug.Log("obstaculo");
            if (obstaculos.Length != 0){
                Debug.Log("tem obstaculo");
                Instantiate (obstaculos[Random.Range(0,obstaculos.Length )], transform.position, Quaternion.Euler(-12, 10, 0));
            }            
        }
        else{
            Debug.Log("plataformas");
            if (plataformas.Length != 0){
                Debug.Log("tem plataformas");
                Instantiate (plataformas[Random.Range(0,plataformas.Length )], transform.position, Quaternion.Euler(-12, 10, 0));                    
            }
        
        }


        Invoke("Spawn", Random.Range(spawnMin,spawnMax));
    }
}