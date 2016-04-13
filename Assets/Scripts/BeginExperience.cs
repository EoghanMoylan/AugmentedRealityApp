using UnityEngine;
using System.Collections;

public class BeginExperience : MonoBehaviour
{
    private int begun;
    private Camera cam;
    public GameObject toLoad;
	// Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("begun", 0);
        cam = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update ()
    {
       begun = PlayerPrefs.GetInt("begun");

        if (begun == 1)
        {
            setUpBegining();
        }
    }
    private void setUpBegining()
    {
        cam.cullingMask |= 1 << LayerMask.NameToLayer("Hall");
        toLoad.SetActive(true);
    }
}
