using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    GameObject obj1;
    GameObject obj2;

    public bool HaveFastBall = true;  //Sørger for at bolden ikke samler powerups op

    private void Awake()
    {
        obj1 = GameObject.FindGameObjectWithTag("PlayerOne");
        obj2 = GameObject.FindGameObjectWithTag("PlayerTwo");
    }

    void Start()
    {
        startPosition = transform.position;
        Launch();
        Debug.Log("Current Speed:" + speed);
    }

    
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;


        //Lang metode, men virker
        if (speed >= 6.05f)
        {
            Launch();
            speed -= 3f;
            Debug.Log("Current Speed:" + speed);
        }
        if (speed >= 9.05f)
        {
            Launch();
            speed -= 3f;
            Debug.Log("Current Speed:" + speed);
        }
        if (speed >= 12.05f)
        {
            Launch();
            speed -= 6f;
            Debug.Log("Current Speed:" + speed);
        }
        if (speed >= 15.05f)
        {
            Launch();
            speed -= 9f;
            Debug.Log("Current Speed:" + speed);
        }
        if (speed >= 18.05f)
        {
            Launch();
            speed -= 12f;
            Debug.Log("Current Speed:" + speed);
        }
        if (speed >= 21.05f)
        {
            Launch();
            speed -= 15f;
            Debug.Log("Current Speed:" + speed);
        }
        else
        { 
            Launch();
            Debug.Log("Current Speed:" + speed);
        }
        
    }   
    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed + x, speed * y);

    }

}