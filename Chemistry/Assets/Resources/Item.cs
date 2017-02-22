using UnityEngine;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

public class Item {
    [XmlElement("Target")]
    public string target;

    [XmlArray("Entity")]
    [XmlArrayItem("ModelID")]
    public List<string> models = new List<string>();

/*    public class Model
    {
        [XmlElement("ModelID")]
        public string modelID;
    } */
}
