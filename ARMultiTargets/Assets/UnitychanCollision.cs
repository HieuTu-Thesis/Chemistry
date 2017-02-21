using UnityEngine;
using System.Collections;

public class UnitychanCollision : MonoBehaviour {

    public GameObject sphere;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("eeeeeeeeeeee");
    //    if (col.gameObject.name == "zombie")
       // {
            sphere.SetActive(false);
     //   }
    }

    void OnCollisionStay(Collision col)
    {
        Debug.Log("ssssssssss");

    }

    void OnCollisionExit(Collision col)
    {
        Debug.Log("tttttttt");
        sphere.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger enter");
        sphere.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger stay");
        sphere.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exit");
        sphere.SetActive(true);
    }
}
