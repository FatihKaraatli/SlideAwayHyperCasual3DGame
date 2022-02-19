using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocks : MonoBehaviour
{
    public float currentZ;
    public float unitedZ;
    public float speed = 0f;
    bool control = true;

    public bool left;
    public bool right;

    public bool X;
    public bool Y;
    public bool Z;


    // Update is called once per frame
    void Update()
    {
        if (X)
        {
            if (right)
            {
                if (transform.localPosition.x > unitedZ && control)
                {
                    transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
                    if (transform.localPosition.x < unitedZ)
                    {
                        control = false;
                    }
                }
                else
                {
                    transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed);
                    if (transform.localPosition.x > currentZ)
                    {
                        control = true;
                    }
                }
            }
            else if (left)
            {
                if (transform.localPosition.x < unitedZ && control)
                {
                    transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
                    if (transform.localPosition.x > unitedZ)
                    {
                        control = false;
                    }
                }
                else
                {
                    transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed);
                    if (transform.localPosition.x < currentZ)
                    {
                        control = true;
                    }
                }
            }
        }
        else if (Y)
        {
            if (right)
            {
                if (transform.localPosition.y > unitedZ && control)
                {
                    transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
                    if (transform.localPosition.y < unitedZ)
                    {
                        control = false;
                    }
                }
                else
                {
                    transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
                    if (transform.localPosition.y > currentZ)
                    {
                        control = true;
                    }
                }
            }
            else if (left)
            {
                if (transform.localPosition.y < unitedZ && control)
                {
                    transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
                    if (transform.localPosition.y > unitedZ)
                    {
                        control = false;
                    }
                }
                else
                {
                    transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
                    if (transform.localPosition.y < currentZ)
                    {
                        control = true;
                    }
                }
            }
        }
        else if (Z)
        {
            if (right)
            {
                if (transform.localPosition.z > unitedZ && control)
                {
                    transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
                    if (transform.localPosition.z < unitedZ)
                    {
                        control = false;
                    }
                }
                else
                {
                    transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed);
                    if (transform.localPosition.z > currentZ)
                    {
                        control = true;
                    }
                }
            }
            else if (left)
            {
                if (transform.localPosition.z < unitedZ && control)
                {
                    transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
                    if (transform.localPosition.z > unitedZ)
                    {
                        control = false;
                    }
                }
                else
                {
                    transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed);
                    if (transform.localPosition.z < currentZ)
                    {
                        control = true;
                    }
                }
            }
        }
        

    }

}
