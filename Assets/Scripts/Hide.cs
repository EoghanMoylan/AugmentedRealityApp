using UnityEngine;
using System.Collections;

public class Hide : MonoBehaviour {

	public Hide hide;
	// Use this for initialization
	void Start () {

		//Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("This gameObject is: " + gameObject);
	}

	public void visible(){
		//gameObject.SetActive(false);
		//this.gameObject.GetComponent<Renderer>().enabled = true;

		GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("Building");
		foreach(GameObject go in gameObjectArray)
		{
			go.GetComponent<Renderer>().enabled = true;
		}

		//hide.GetComponent<Hide> ().visible ();

		//GameObject.FindGameObjectsWithTag ("Building");
	}

	public void invisible(){
		//this.gameObject.GetComponent<Renderer>().enabled = false;
		//hide.GetComponent<Hide> ().invisible ();

		GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("Building");
		foreach(GameObject go in gameObjectArray)
		{
			go.GetComponent<Renderer>().enabled = false;
		}
	}
}
