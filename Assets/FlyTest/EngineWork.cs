using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineWork : MonoBehaviour
{
    Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void SetPower(float value)
    {
        rigidbody.AddForce(transform.up * value);
    }
}
