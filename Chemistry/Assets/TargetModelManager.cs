using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetModelManager : MonoBehaviour {
    public string targetName;
    List<GameObject> objects;

    public TargetModelManager(string target)
    {
        targetName = name;
        objects = new List<GameObject>();
    }
}
