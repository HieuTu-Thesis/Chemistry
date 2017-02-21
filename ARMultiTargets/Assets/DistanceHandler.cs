using UnityEngine;
using Vuforia;
using System.Collections;
using System;

public class DistanceHandler : MonoBehaviour, ITrackableEventHandler
{

    public TrackableBehaviour mTrackableBehaviour;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log("Vuivui. Find something");
            print("Found something");
        }
        else
        {
            Debug.Log("Huhu. Lost something");
            print("Lost something");
        }
    }
}
