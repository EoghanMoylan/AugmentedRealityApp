using UnityEngine;
using Vuforia;
using System.Collections;

public class TrackableHandler : MonoBehaviour {

    private TrackableBehaviour mTrackableBehaviour;
    public Transform myModelPrefab;

    // Use this for initialization
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mTrackableBehaviour)
        {
          //  mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
              TrackableBehaviour.Status previousStatus,
              TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            OnTrackingFound();
        }
    }
    private void OnTrackingFound()
    {
        if (myModelPrefab != null)
        {
            Transform myModelTrf = GameObject.Instantiate(myModelPrefab) as Transform;

            myModelTrf.parent = mTrackableBehaviour.transform;
            myModelTrf.gameObject.SetActive(true);

        }
    }
}
