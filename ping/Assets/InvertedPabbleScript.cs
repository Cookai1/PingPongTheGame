using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertedPabbleScript : MonoBehaviour
{
    public Pabble pabbleScript;
    GameObject obj;


    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            obj.GetComponent<Pabble>().InvertedPabbleBool = false;

            Destroy(gameObject);

        }

    }
}
