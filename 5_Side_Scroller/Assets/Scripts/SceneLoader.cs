﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadFirstScene", 10);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
