using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

[XmlRoot("MyEntity")]
public class MyEntity {
    [XmlArray("MyDisplays")]
    [XmlArrayItem("MyDisplay", typeof(MyDisplay))]
    public List<MyDisplay> displays = new List<MyDisplay>();

    public int curDisplay;

    public MyDisplay getDisplay()
    {
        return getINextDisplay(0);
    }

    private MyDisplay getINextDisplay(int kNext)
    {
        if (displays == null || displays.Count == 0)
            return null;
        int n = displays.Count;
        if (kNext >= 0)
            curDisplay = (curDisplay + kNext) % n;

        MyDisplay result = displays[curDisplay];


        return result;
    }

    public MyDisplay getNextDisplay()
    {
        return getINextDisplay(1);
    }

    public MyDisplay getFinalDisplay()
    {
        return displays[displays.Count - 1];
    }
}
