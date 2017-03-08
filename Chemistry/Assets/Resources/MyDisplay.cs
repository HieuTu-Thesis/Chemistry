using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

[XmlRoot("MyDisplay")]
public class MyDisplay {
    [XmlArray("Models")]
    [XmlArrayItem("Model", typeof(Model))]
    public List<Model> models = new List<Model>();

}
