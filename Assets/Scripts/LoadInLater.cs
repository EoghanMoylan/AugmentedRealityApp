using UnityEngine;
using System.Collections;

public class LoadInLater : MonoBehaviour {

    private GameObject toLoad;
    public bool mainButton;
    public bool toLoadin;
	
    void Start()
    {
        toLoad = this.gameObject;
    }

	// Update is called once per frame
	void Update ()
    {
        if (!mainButton)
        {
            if (PlayerPrefs.GetInt("begun") == 1)
            {
                if (toLoadin == true)
                {
                    toLoad.SetActive(true);
                }
                else
                {
                    toLoad.SetActive(false);
                }
            }
        }
        else if (PlayerPrefs.GetInt("menu") == 0)
        {
            toLoad.SetActive(false);
        }
	}
}
