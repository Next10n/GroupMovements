using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsView : MonoBehaviour
{
    [SerializeField] private SettingsLoader _settingsLoader;

    [SerializeField] private InputField _XField;
    [SerializeField] private InputField _YField;
    [SerializeField] private InputField _ZField;

    [SerializeField] private InputField _amonthField;
    [SerializeField] private InputField _typesField;
    [SerializeField] private InputField _weightRangeField;
    [SerializeField] private InputField _targetRangeField;

    private GenerationSettings _generationSettings;

    private void Start()
    {
        _generationSettings = _settingsLoader.Settings;

        _XField.text = _generationSettings.Area.x.ToString();
        _YField.text = _generationSettings.Area.y.ToString();
        _ZField.text = _generationSettings.Area.z.ToString();

        _amonthField.text = _generationSettings.Amonth.ToString();
        _typesField.text = _generationSettings.Types.ToString();
        _weightRangeField.text = _generationSettings.WeigthRange.ToString();
        _targetRangeField.text = _generationSettings.TargetRange.ToString();
    }

    public void SetAmonth(string text)
    {       
        _generationSettings.Amonth = Convert.ToInt32(text);
    }

    public void SetTypes(string text)
    {
        _generationSettings.Types = Convert.ToInt32(text);
    }

    public void SetWeightRange(string text)
    {
        _generationSettings.WeigthRange = float.Parse(text);
    }

    public void SetTargetRange(string text)
    {
        _generationSettings.TargetRange = float.Parse(text);
    }

    public void SetXArea(string text)
    {
        _generationSettings.Area = new Vector3(float.Parse(text), _generationSettings.Area.y, _generationSettings.Area.z);
    }

    public void SetYArea(string text)
    {
        _generationSettings.Area = new Vector3(_generationSettings.Area.x, float.Parse(text), _generationSettings.Area.z);
    }

    public void SetZArea(string text)
    {
        _generationSettings.Area = new Vector3(_generationSettings.Area.x, _generationSettings.Area.y, float.Parse(text));
    }




}
