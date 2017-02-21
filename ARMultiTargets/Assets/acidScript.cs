using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class acidScript : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbButton;
    public GameObject tag;
    static bool isShow;
    
    // Use this for initialization
    void Start()
    {
        vbButton = GameObject.Find("acidButton");
        vbButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
      //  tag = GameObject.Find("acid");
        tag.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour bh)
    {
        Debug.Log("Aciddddd");
        tag.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour bh)
    {
        Debug.Log("offfffff Aciddddd");
        tag.SetActive(false);
    }
}
