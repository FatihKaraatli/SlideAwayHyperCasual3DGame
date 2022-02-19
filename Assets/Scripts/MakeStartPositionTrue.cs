using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeStartPositionTrue : MonoBehaviour
{
    public float value;
    void Start()
    {
        transform.position = new Vector3(transform.position.x, value , transform.position.z);
    }

}
