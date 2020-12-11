using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    Rigidbody bala;
    [SerializeField]
    private float velocity = 5.0f;
    void Start()
    {
        bala = GetComponent<Rigidbody>();
        bala.velocity = new Vector3(velocity,0,0);
    }
}
