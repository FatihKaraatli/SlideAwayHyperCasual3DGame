using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShot : MonoBehaviour
{
    Vector3 firstPosition;
    public float speed = 0f;
    void Start()
    {
        firstPosition = transform.localPosition;
    }

    
    void Update()
    {
        if (Mathf.Abs(transform.localPosition.z) < 1.7f)
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
        else
        {
            transform.localPosition = firstPosition;
        }
    }

}
