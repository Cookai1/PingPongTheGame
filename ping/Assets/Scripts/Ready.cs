﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ready : MonoBehaviour
{

    public void QuitGame ()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
