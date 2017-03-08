using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

[XmlRoot("Model")]
public class Model {
    [XmlElement("ModelName")]
    public string name;

    [XmlElement("DataTransform")]
    public DataTransform dataTransform;

    public DataTransform getTransform()
    {
        if (dataTransform == null)
        {
            dataTransform = new DataTransform();
        }

        return dataTransform;
    }

    [XmlRoot("DataTransform")]
    public class DataTransform
    {
        public Vector3 GetPosition()
        {
            if (dataPosition != null && dataPosition.DataX != null && dataPosition.DataY != null && dataPosition.DataZ != null)
                return new Vector3(float.Parse(dataPosition.DataX), float.Parse(dataPosition.DataY), float.Parse(dataPosition.DataZ));
            return Vector3.zero;
        }
        public Vector3 GetRotation()
        {
            if (dataRotation != null && dataRotation.DataX != null && dataRotation.DataY != null && dataRotation.DataZ != null)
                return new Vector3(float.Parse(dataRotation.DataX), float.Parse(dataRotation.DataY), float.Parse(dataRotation.DataZ));
            return Vector3.zero;
        }
        public Vector3 GetScale()
        {
            if (dataScale != null && dataScale.DataX != null && dataScale.DataY != null && dataScale.DataZ != null)
                return new Vector3(float.Parse(dataScale.DataX), float.Parse(dataScale.DataY), float.Parse(dataScale.DataZ));
            return new Vector3(1.0f, 1.0f, 1.0f);
        }
        [XmlElement("DataPosition")]
        public DataPosition dataPosition;

        public class DataPosition
        {
            [XmlElement("DataX")]
            public string DataX;
            [XmlElement("DataY")]
            public string DataY;
            [XmlElement("DataZ")]
            public string DataZ;
        }

        [XmlElement("DataRotation")]
        public DataRotation dataRotation;

        public class DataRotation
        {
            [XmlElement("DataX")]
            public string DataX;
            [XmlElement("DataY")]
            public string DataY;
            [XmlElement("DataZ")]
            public string DataZ;
        }

        [XmlElement("DataScale")]
        public DataScale dataScale;

        public class DataScale
        {
            public string DataX;
            public string DataY;
            public string DataZ;
        }
    }


    
}

