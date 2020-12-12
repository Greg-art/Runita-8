﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScoreItem : MonoBehaviour
{
    [SerializeField] private int _scoreGiven = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<IHaveScore>() != null)
        {
            other.GetComponent<IHaveScore>().HandleScore(_scoreGiven);
            Destroy(gameObject);
        }
    }
}
