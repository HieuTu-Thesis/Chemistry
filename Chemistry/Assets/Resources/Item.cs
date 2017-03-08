using UnityEngine;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("Item")]
public class Item {
    [XmlElement("Target")]
    public string target;

    [XmlElement("MyEntity")]
    public MyEntity myEntity;
}
