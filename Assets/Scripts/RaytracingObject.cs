using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class RaytracingObject : MonoBehaviour
{
    private void OnEnable()
    {
        RaytracingMaster.RegisterObject(this);
    }

    private void OnDisable()
    {
        RaytracingMaster.UnregisterObject(this);
    }
}
