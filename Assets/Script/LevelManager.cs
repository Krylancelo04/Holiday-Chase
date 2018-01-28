﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

	// Use this for initialization
	void Awake ()
    {
        instance = this;
	}

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
