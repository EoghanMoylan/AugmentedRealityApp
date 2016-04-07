using UnityEngine;
using System.Collections;
using Vuforia;

public class TargetUpdater : MonoBehaviour
{
    public Trackable imgTar;// = new ImageTarget;
    private VuforiaBehaviour vb;
	// Use this for initialization
    private void Start()
    {
       vb =  vb.GetComponent<VuforiaBehaviour>();
       imgTar = vb.WorldCenter.Trackable;
    }
	public void setImage(ImageTarget imgTar)
    {
        this.imgTar = imgTar;
    }
    public Trackable getImage()
    {
        return imgTar;
    }
}
