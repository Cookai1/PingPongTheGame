using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pabble : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    public bool InvertedPabbleBool;
    

    //Fast ball
    /**
    public Ball BallScript;
    public float increaseSpeed = 2.5f;
    GameObject obj;
    public float NewSpeed;
    **/

    public float movement;

    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        if (InvertedPabbleBool = true)
        {
            if (isPlayer1)
            {
                movement = Input.GetAxisRaw("Vertical");
            }else{
                movement = Input.GetAxisRaw("Vertical2");
            }
        }else{
            if (isPlayer1)
            {
                movement = -Input.GetAxisRaw("Vertical");
            }else{
                movement = -Input.GetAxisRaw("Vertical2");
            }
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
  
}



