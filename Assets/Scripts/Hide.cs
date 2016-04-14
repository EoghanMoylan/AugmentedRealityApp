using UnityEngine;
using System.Collections;

public class Hide : MonoBehaviour
{
	public void visible(){
        //gameObject.SetActive(false);
        //this.gameObject.GetComponent<Renderer>().enabled = true;

        this.gameObject.SetActive(true);

		//hide.GetComponent<Hide> ().visible ();

		//GameObject.FindGameObjectsWithTag ("Building");
	}

	public void invisible()
    {
        //this.gameObject.GetComponent<Renderer>().enabled = false;
        //hide.GetComponent<Hide> ().invisible ();

        this.gameObject.SetActive(false);
	}
}
