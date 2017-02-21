using UnityEngine;
using System.Collections;

public class Triggers : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger enter");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger stay");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exit");
    }
}
