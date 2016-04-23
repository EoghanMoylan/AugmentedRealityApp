using UnityEngine;
using System.Collections;

public class ToggleObject : MonoBehaviour {

	public void toggle()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
}
