using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit.Filtering;

public class EnginePowerController : MonoBehaviour
{
    [SerializeField] GameObject[] EngineFires;
    [SerializeField] EngineWork[] Engines;

    public void SetPowerValue(XRSlider sender)

    {
        float value = sender.value;

        SetEnginePower(value);
        SetPowerFires(value);
    }

    private void SetEnginePower(float value)
    {
        for (int i = 0; i < Engines.Length; i++)
        {
            Engines[i].SetPower(value);
        }
    }

    private void SetPowerFires(float value)
    {
        Vector3 pos;

        for (int i = 0; i < EngineFires.Length; i++)
        {
            pos = EngineFires[i].transform.localPosition;
            pos.y = value * -1;
            EngineFires[i].transform.localPosition = pos;
        }
    }
}
