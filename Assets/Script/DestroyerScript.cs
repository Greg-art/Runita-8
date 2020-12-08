using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{

    void OnTriggerEnter(Collider outro){
        Debug.Log("trigger");
        if(outro.gameObject.tag == "Player"){
            Debug.Log("moreuuu");
            Debug.Break ();
            return;
        }
        
        if (outro.gameObject.transform.parent)
                Destroy(outro.gameObject.transform.parent.gameObject);
            else
                Destroy(outro.gameObject);
    }
}
