using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasterPabble : MonoBehaviour
{
    public GameObject pabbleScript1;
    public float increaseSpeed = 3f;
    GameObject obj1;
    GameObject obj2;
    public float NewSpeedPabble;
    public GameObject BallObject;

    private void Awake()
    {
        obj1 = GameObject.FindGameObjectWithTag("PlayerOne");
        obj2 = GameObject.FindGameObjectWithTag("PlayerTwo");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("PlayerOne"))
        {
            //NewSpeedPabble = obj1.GetComponent<Pabble>().speed += increaseSpeed;
            Pabble player1 = obj1.GetComponent<Pabble>();
            StartCoroutine(powerupTimer(player1));
            Debug.Log("New Pabble Speed:" + NewSpeedPabble);

            transform.position = new Vector2(2, 9);
        }
        if (collision.CompareTag("PlayerTwo"))
        {
            //NewSpeedPabble = obj2.GetComponent<Pabble>().speed += increaseSpeed;
            Debug.Log("New Pabble Speed:" + NewSpeedPabble);
            Pabble player2 = obj2.GetComponent<Pabble>();
            StartCoroutine(powerupTimer(player2));

            transform.position = new Vector2(2, 9);
        }
    }
    IEnumerator powerupTimer(Pabble p)
    {
        p.speed += increaseSpeed;
        yield return new WaitForSeconds(10f);
        p.speed -= increaseSpeed;
    }
}
