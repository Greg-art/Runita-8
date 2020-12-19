using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] plataformas;
    public GameObject[] obstaculos;
    public GameObject[] extra;
    public float spawnMin;
    public float spawnMax;
    public int chanceObstaculo = 20;
    public int chanceExtra = 5;
    private float _oldPosition = 0;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Spawn()
    {

        if (transform.position.x > _oldPosition + 3)
        { //pra não colocar plataformas mto emcima das outras
            int escolha = Random.Range(0, 100);
            if (escolha < chanceExtra)
            {
                if (extra.Length != 0)
                {
                    Instantiate(extra[Random.Range(0, extra.Length)], transform.position, Quaternion.Euler(-12, 10, 0));
                }
            }
            else if (escolha < chanceObstaculo)
            {
                if (obstaculos.Length != 0)
                {
                    Instantiate(obstaculos[Random.Range(0, obstaculos.Length)], transform.position, Quaternion.Euler(-12, 10, 0));
                }
            }
            else
            {
                if (plataformas.Length != 0)
                {
                    Instantiate(plataformas[Random.Range(0, plataformas.Length)], transform.position, Quaternion.Euler(-12, 10, 0));
                }

            }
        }
        _oldPosition = transform.position.x;

        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }
}