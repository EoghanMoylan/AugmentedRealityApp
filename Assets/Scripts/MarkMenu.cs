using UnityEngine;
using System.Collections;

public class MarkMenu : MonoBehaviour {

    public int isMenu;
	// Use this for initialization
	void Start ()
    {
        PlayerPrefs.SetInt("menu", isMenu);
	}
}
