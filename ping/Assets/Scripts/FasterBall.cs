using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasterBall : MonoBehaviour
{
    public Ball BallScript;
    public float increaseSpeed = 3f;
    GameObject obj;
    public float NewSpeed;
    public GameObject Player1Object;
    public GameObject Player2Object;
    public GameObject BallObject;

    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("BallTag");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            NewSpeed = obj.GetComponent<Ball>().speed += increaseSpeed;
            Debug.Log("New Ball Speed:" + NewSpeed);

            Destroy(gameObject);
        }
    }
}