using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class stonesBT : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vbButton;
    private TrackableBehaviour mTrackableBehaviour;

    // Use this for initialization
    void Start () {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        vbButton = GameObject.Find("stonesBT");
        vbButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }


    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        DeleteComponent();
        Debug.Log("Log ra cho vui Presseddddd");
        MyEntity entity = ItemManager.getEntity(mTrackableBehaviour.TrackableName);
        if (entity == null)
            return;
        MyDisplay display = entity.getNextDisplay();
        if (display == null)
            return;
        Debug.Log("Log ra cho vui modelll");
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
                EntityInstantiator enIns = GetComponent<EntityInstantiator>();
                enIns.realModels.Add(realModel);
            }
        }
        Debug.Log("chips add log..." + mTrackableBehaviour.TrackableName);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Log ra cho vui Releasedddd");
    }

    public void DeleteComponent()
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

        Debug.Log("Next chips display xoa ne" + mTrackableBehaviour.TrackableName);
        EntityInstantiator enIns = GetComponent<EntityInstantiator>();
        foreach (GameObject model in enIns.realModels)
        {
            GameObject.Destroy(model);
        }
        enIns.realModels.Clear();
    }
}
