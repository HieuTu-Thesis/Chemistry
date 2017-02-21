using UnityEngine;
using System.Collections;

public class DistanceController : MonoBehaviour {

    //public bool firstObj;
    //public bool secondObj;

    //public double distance;
    //public double threshold;

    public Transform firstObjTrans;
    public Transform secondObjTrans;
    

	// Use this for initializationss
	void Start () {
      //  firstObj = secondObj = false;
	}
	
	// Update is called once per frame
	void Update () {
        /*       if (Vector3.Distance(firstObjTrans.position,Vector3.zero) > 0.0  && Vector3.Distance(secondObjTrans.position, Vector3.zero) > 0.0)
                    distance = Vector3.Distance(firstObjTrans.position, secondObjTrans.position);
               else
                    distance = -1;

               Debug.Log("distance: " + distance.ToString());*/

        //if (firstObj && secondObj)
        //    distance = Vector3.Distance(firstObjTrans.position, secondObjTrans.position);
        //else
        //    distance = -1;

        Debug.Log(firstObjTrans.position.ToString() + secondObjTrans.position.ToString());

    }
}
