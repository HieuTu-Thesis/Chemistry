using UnityEngine;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour {

    public const string path = "mapping";
    public static ItemContainer ic;

    // Use this for initialization
    void Start () 
    {
        ic = ItemContainer.Load(path);
        // Debug item
      /*foreach (Item item in ic.items)
        {
            Debug.Log(item.target);
            foreach (MyDisplay display in item.myEntity.displays)
            {
                foreach (Model model in display.models)
                {
                    Debug.Log(model.name);
                }
            }
            Debug.Log("******");
        }*/
	}

    public static MyEntity getEntity(string targetName)
    {
        foreach (Item item in ic.items)
        {
            if (item.target == targetName)
            {
                return item.myEntity;
            }
        }

        return null;
    }

    private static Item getItem(string name)
    {
        Item destItem = null;
        foreach (Item item in ic.items)
        {
            if (item.target == name)
            {
                return destItem;
            }
        }

        return null;
    }

    public static MyDisplay getDisplay(string targetName, int kNext)
    {
        Item destItem = getItem(targetName);

        if (destItem != null && destItem.myEntity != null)
        {
            return destItem.myEntity.getDisplay();
        }

        return null;
    }

    public static MyDisplay getNextDisplay(string targetName)
    {
        Item destItem = getItem(targetName);

        if (destItem != null && destItem.myEntity != null)
        {
            return destItem.myEntity.getNextDisplay();
        }

        return null;
    }
}
