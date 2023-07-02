using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class EngineRotator : MonoBehaviour
{
    [SerializeField] GameObject[] Engines;
    [SerializeField] float rotateSpeed = 1f;

    public void SetYRotation(XRJoystick sender)
    {
        float yRotation = sender.value.y / 5;

        Quaternion rot;

        for (int i = 0; i < Engines.Length; i++)
        {
            rot = Engines[i].transform.rotation;
            rot.x = yRotation;
            Engines[i].transform.rotation = rot;
        }
    }

    public void SetXRotation(XRJoystick sender)
    {
        float xRotation = sender.value.x / 5;

        Quaternion rot;

        for (int i = 0; i < Engines.Length; i++)
        {
            rot = Engines[i].transform.rotation;
            rot.z = xRotation * -1;
            Engines[i].transform.rotation = rot;
        }
    }
}
