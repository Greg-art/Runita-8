﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class backgroundRepeaterScript : MonoBehaviour{
    public float offset = 54f;
    private Transform cameraTransform;
    
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update(){
        if ((transform.position.x + offset) < cameraTransform.position.x){
            Vector3 newPos = transform.position;
            newPos.x += 2*offset;
            transform.position = newPos;
        }
    }
}