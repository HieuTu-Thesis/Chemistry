using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameController : MonoBehaviour {
    public GameObject firstObj;
    public GameObject secondObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(firstObj.transform.position.ToString() + secondObj.transform.position.ToString());
	}
}
