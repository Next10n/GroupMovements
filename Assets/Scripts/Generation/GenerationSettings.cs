using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using UnityEngine;

/// <summary>
/// Параметры генерации
/// </summary>
[System.Serializable]
public class GenerationSettings : ISerializable
{
    public int Amonth { get; set; }
    public int Types { get; set; }
    public float WeigthRange { get; set; }
    public float TargetRange { get; set; }
    public Vector3 Area { get; set; }

    public GenerationSettings()
    {

    }

    public GenerationSettings(SerializationInfo info, StreamingContext context)
    {
        Amonth = (int)info.GetValue("Amonth", typeof(int));
        Types = (int)info.GetValue("Types", typeof(int));
        WeigthRange = (float)info.GetValue("WeigthRange", typeof(float));
        TargetRange = (float)info.GetValue("TargetRange", typeof(float));
        Area = new Vector3(
            (float)info.GetValue("AreaX", typeof(float)),
             (float)info.GetValue("AreaY", typeof(float)),
              (float)info.GetValue("AreaZ", typeof(float))
              );
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Amonth", Amonth, typeof(int));
        info.AddValue("Types", Types, typeof(int));
        info.AddValue("WeigthRange", WeigthRange, typeof(float));
        info.AddValue("TargetRange", TargetRange, typeof(float));
        info.AddValue("AreaX", Area.x, typeof(float));
        info.AddValue("AreaY", Area.y, typeof(float));
        info.AddValue("AreaZ", Area.z, typeof(float));
    }
}
