using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : MonoBehaviour {

    public GameObject firstObj;
    public GameObject secondObj;
 //   public GameObject result;
    public ParticleSystem hidro;

	// Use this for initialization
	void Start () {
        hidro.Stop();
     //   result.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        double distance = Vector3.Distance(firstObj.transform.position, secondObj.transform.position);
        //     Debug.Log(firstObj.transform.position.ToString() + secondObj.transform.position.ToString() + distance.ToString());
        if (distance < 30.0)
        {
            if (hidro.isPaused || hidro.isStopped)
            {
                hidro.Play();
            //    result.SetActive(true);
            }
            else
            {
                hidro.Play();
             //   result.SetActive(true);
            }
        }
        else
        {
            hidro.Stop();
          //  result.SetActive(false);
        }
        }
}
