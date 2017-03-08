using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class EntityInstantiator : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public List<GameObject> realModels = new List<GameObject>();
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

    public void OnTrackingFound()
    {
        Debug.Log("Trackable...... " + mTrackableBehaviour.TrackableName + " found");
        MyEntity entity = ItemManager.getEntity(mTrackableBehaviour.TrackableName);
        if (entity == null)
            return;
        MyDisplay display = entity.getDisplay();
        if (display == null)
            return;
        foreach (Model model in display.models)
        {
            if (model != null)
            {
                GameObject realModel = Instantiate(Resources.Load(model.name)) as GameObject;
                realModel.transform.parent = mTrackableBehaviour.transform;
                realModel.transform.position = mTrackableBehaviour.transform.position + model.getTransform().GetPosition();
                realModel.transform.localScale = model.getTransform().GetScale();
                realModel.transform.eulerAngles = model.getTransform().GetRotation();
                realModel.SetActive(true);
                realModels.Add(realModel);
            }
        }
        Debug.Log("Entity add log..." + mTrackableBehaviour.TrackableName);
    }

    public void OnTrackingLost()
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
        Debug.Log("Lost xoa ne " + mTrackableBehaviour.TrackableName);
        deleteModels(mTrackableBehaviour.TrackableName);

        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
    }


    public void deleteModels(string target)
    {
        foreach (GameObject model in realModels)
        {
            string xname = model.name;
            GameObject.DestroyObject(model);
        }
        realModels.Clear();
    }
}
