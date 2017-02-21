using UnityEngine;
using Vuforia;
using System.Collections;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject vbButton;

    // Use this for initialization
    void Start()
    {
        vbButton = GameObject.Find("vbButton");
        vbButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour bh)
    {
        Debug.Log("Starttt");
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour bh)
    {
        Debug.Log("Stoppppp");
    }

}
