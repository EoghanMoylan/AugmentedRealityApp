﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public class SceneSelect : MonoBehaviour
{
    private string currentScene;// = Application.loadedLevelName;
    public void Begin()
    {
        Application.LoadLevel("alt");
    }


    public void nextScene()
    {
        currentScene = Application.loadedLevelName;
           
        if(currentScene == "alt")
        {
            currentScene = "test1";
        }
        else
        {
            currentScene = "alt";
        }

        Application.LoadLevel(currentScene);
    }

    public void about()
    {
        Application.LoadLevel("about");
    }
    public void refresh()
    {
        currentScene = Application.loadedLevelName;
        Application.LoadLevel(currentScene);
    }
}
