using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressKey : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Invoke("LoadScene", 6f);
        }
    }



    void LoadScene()
    {
        Application.LoadLevel("game");
    }
}
