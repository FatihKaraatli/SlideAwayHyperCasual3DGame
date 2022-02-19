using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlocks : MonoBehaviour
{
    public float speed = 0f;

    public bool x = false;
    public bool y = false;
    public bool z = false;



    void Start()
    {
        
    }

    void Update()
    {
        if (x)
        {
            if (PlayerPrefs.GetFloat("timeslow") == 1)
            {
                transform.Rotate(new Vector3(15f, 0f, 0f) * Time.deltaTime * speed / 1.02f);
            }
            else
            {
                transform.Rotate(new Vector3(15f, 0f, 0f) * Time.deltaTime * speed);
            }
        }
        else if (y)
        {
            if (PlayerPrefs.GetFloat("timeslow") == 1)
            {
                transform.Rotate(new Vector3(0f, 15f, 0f) * Time.deltaTime * speed / 1.02f);
            }
            else
            {
                transform.Rotate(new Vector3(0f, 15f, 0f) * Time.deltaTime * speed);
            }
        }
        else if (z)
        {
            if (PlayerPrefs.GetFloat("timeslow") == 1)
            {
                transform.Rotate(new Vector3(0f, 0f, 15f) * Time.deltaTime * speed / 1.02f);
            }
            else
            {
                transform.Rotate(new Vector3(0f, 0f, 15f) * Time.deltaTime * speed);
            }
        }

        
        
    }
}
