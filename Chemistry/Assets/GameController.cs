using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        TextAsset data = Resources.Load("mapping.xml") as TextAsset;
        if (data)
            Debug.Log(data.text.ToString());
        else
            Debug.Log("Load failed");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
