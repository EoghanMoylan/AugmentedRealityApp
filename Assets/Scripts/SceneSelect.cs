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
        bool loadNext = false;
        List<string> sceneList = new List<string>();
        
        sceneList.Add("alt");
        sceneList.Add("siteMapScene");

        foreach(string scene in sceneList)
        {
            if(scene.Equals(currentScene))
            {
                loadNext = true;
            }

            if(sceneList.IndexOf(scene)  == sceneList.Count)
            {
                currentScene = sceneList.ElementAt(0);
            }
            else if (loadNext == true)
            {
                currentScene = scene;
                break;
            }
        }

        Application.LoadLevel(currentScene);

    }
    public void refresh()
    {
        currentScene = Application.loadedLevelName;
        Application.LoadLevel(currentScene);
    }
}
