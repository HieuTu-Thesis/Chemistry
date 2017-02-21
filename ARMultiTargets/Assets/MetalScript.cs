using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MetalScript : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbButton;
    public GameObject tag;
    static bool isShow;

    // Use this for initialization
    void Start()
    {
        vbButton = GameObject.Find("metalButton");
        vbButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        tag.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour bh)
    {
        Debug.Log("Metallllllllllll");
        tag.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour bh)
    {
        Debug.Log("Realeased Metallllllllllll");
        tag.SetActive(false);
    }
}