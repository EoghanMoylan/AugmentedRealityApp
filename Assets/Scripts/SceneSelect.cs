using UnityEngine;
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
            currentScene = "siteMapScene";
        }
        else
        {
            currentScene = "alt";
        }

        Application.LoadLevel(currentScene);

    }
    public void refresh()
    {
        currentScene = Application.loadedLevelName;
        Application.LoadLevel(currentScene);
    }
}
