using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    Rigidbody bala;
    [SerializeField]
    private float velocity = 9.0f;
    [SerializeField]
    private GameObject player = default;
    [SerializeField]
    private float distance = 17f;
    

    void Start()
    {
        bala = GetComponent<Rigidbody>();
    
    }
    void Update(){
        float distance =  player.transform.position.x - transform.position.x;
        float veloPlayer = player.GetComponent<Rigidbody2D>().velocity.x;

        if(veloPlayer > 0 && distance > 17){
            bala.velocity = new Vector3(veloPlayer,0,0);
        }else{
            bala.velocity = new Vector3(velocity,0,0);            
        }
    }

}
