using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

/// <summary>
/// Загрузка и сериализация данных
/// </summary>
public class SettingsLoader : MonoBehaviour
{
    public GenerationSettings Settings { get; private set; }

    private string _fileName = "Settings.Data";
    private IFormatter _formatter;

    private void Awake()
    {
        Settings = new GenerationSettings();
        _formatter = new BinaryFormatter();
        Deserialize(_fileName, _formatter);
    }

    private void OnDestroy()
    {
        Serialize(_fileName, _formatter);
    }

    private void Serialize(string fileName, IFormatter formatter)
    {
        FileStream fileStream = new FileStream(fileName, FileMode.Create);
        formatter.Serialize(fileStream, Settings);
        fileStream.Close();
    }

    private void Deserialize(string fileName, IFormatter formatter)
    {
        if (File.Exists(fileName))
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            Settings = (GenerationSettings)formatter.Deserialize(fileStream);
            fileStream.Close();
        }
        else
        {
            Settings = new GenerationSettings();
        }       
    }
}
