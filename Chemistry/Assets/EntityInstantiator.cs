using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class EntityInstantiator : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
  //  public GameObject myModelPrefab;
    private GameObject model;

    // Use this for initialization
    void Start () {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            OnTrackingFound();
        }
        else
        {
            OnTrackingLost();
        }
    }
    private void OnTrackingFound()
    {
        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
        List<string> models = ItemLoader.getEntity(mTrackableBehaviour.TrackableName);

        foreach (string modelName in models)
        {
            GameObject myModelPrefab = Instantiate(Resources.Load(modelName)) as GameObject;
            if (myModelPrefab != null)
            {
                model = Instantiate(myModelPrefab, Vector3.zero, Quaternion.identity) as GameObject;
                model.transform.parent = mTrackableBehaviour.transform;
                model.transform.position = mTrackableBehaviour.transform.position;
                model.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                model.SetActive(true);
            }
        }
    }
    private void OnTrackingLost()
    {
        Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
        Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

        // Disable rendering:
        foreach (Renderer component in rendererComponents)
        {
            component.enabled = false;
        }

        // Disable colliders:
        foreach (Collider component in colliderComponents)
        {
            component.enabled = false;
        }

        GameObject.Destroy(model);

        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
    }
}
