using UnityEngine;
using System.Collections;

public class ZombieCollision : MonoBehaviour {

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
     //   sphere.SetActive(false);
        //   }
    }

    void OnCollisionStay(Collision col)
    {
        Debug.Log("ssssssssss");

    }

    void OnCollisionExit(Collision col)
    {
        Debug.Log("tttttttt");
      //  sphere.SetActive(true);
    }
}
