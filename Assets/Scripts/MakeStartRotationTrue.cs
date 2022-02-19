using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeStartRotationTrue : MonoBehaviour
{
    public float X;
    public float Y;
    public float Z;
    void Start()
    {
        transform.rotation = Quaternion.Euler(X,Y,Z);
    }

}
