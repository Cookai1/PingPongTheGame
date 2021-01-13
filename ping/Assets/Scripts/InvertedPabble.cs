using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertedPabble : MonoBehaviour
{
    public Pabble pabbleScript;
    GameObject obj;


    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Invert");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            obj.GetComponent<Pabble>().InvertedPabbleBool = false;

            Debug.Log("Inverted:" + obj );

            Destroy(gameObject);
        }

    }

}    
