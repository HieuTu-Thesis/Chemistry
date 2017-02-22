using UnityEngine;
using System.Collections.Generic;

public class ItemLoader : MonoBehaviour {

    public const string path = "mapping";
    public static ItemContainer ic;

    // Use this for initialization
    void Start () 
    {
        ic = ItemContainer.Load(path);

        foreach (Item item in ic.items)
        {
            Debug.Log(item.target);
            foreach (string model in item.models)
            {
                Debug.Log(model);
            }
            Debug.Log("******");
        }
	}

    public static List<string> getEntity(string targetName)
    {
        List<string> result = new List<string>();

        foreach (Item item in ic.items)
        {
            if (item.target == targetName)
            {
                return item.models;
            }
        }

        return result;
    }
	
}
