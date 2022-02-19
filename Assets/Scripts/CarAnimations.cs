using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAnimations : MonoBehaviour
{
    public float currentRotationOfY;
    float currentPositionOfY = 0f;
    float currentPositionOfZ = 0f;
    float speed = 5f;
    public float increase = 0f;
    public float increase360Degree = 0f;

    int skill = 0;

    public Vector3 currentScale;

    CarAnimations carAnimation;

    void Start()
    {
        carAnimation = GetComponent<CarAnimations>();
        currentPositionOfY = transform.position.y;
        currentPositionOfZ = transform.position.z;
    }

    void Update()
    {
        if (PlayerPrefs.GetString("isDead") == "true")
        {
            carAnimation.enabled = false;
        }
        if (PlayerPrefs.GetString("isFinish") == "true")
        {
            carAnimation.enabled = false;
        }

        if (PlayerPrefs.GetInt("skill") == 5)
        {
            PlayerPrefs.SetInt("skill", 0);
        }
        if (PlayerPrefs.GetInt("skill") == 0)
        {
            if (PlayerPrefs.GetFloat("entertriggerbox") == 1)
            {
                PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill")+1);
                PlayerPrefs.SetFloat("entertriggerbox", 0);
            }
        }
        else if (PlayerPrefs.GetInt("skill") == 1)
        {
            if (PlayerPrefs.GetFloat("timeslow") == 1)
            {
                if (PlayerPrefs.GetInt("currentcarindex") == 2 || PlayerPrefs.GetInt("currentcarindex") == 9 || PlayerPrefs.GetInt("currentcarindex") == 10)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, currentPositionOfY + increase, transform.position.z), Time.deltaTime * speed);
                    transform.Rotate(new Vector3(-30f, 0f, 0f) * Time.deltaTime * speed);
                }
                else
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, currentPositionOfY + increase, transform.position.z), Time.deltaTime * speed);
                    transform.Rotate(new Vector3(0f, 0f, 30f) * Time.deltaTime * speed);
                }
            }
            else
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, currentRotationOfY, 0);
                transform.position = new Vector3(transform.position.x, currentPositionOfY, transform.position.z);
            }
            
            if (PlayerPrefs.GetFloat("entertriggerbox") == 1)
            {
                PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 1);
                PlayerPrefs.SetFloat("entertriggerbox", 0);
            }
        }
        else if (PlayerPrefs.GetInt("skill") == 2)
        {
            if (PlayerPrefs.GetFloat("timeslow") == 1)
            {
                Invoke("RightDrift", 0.00000000001f);
                Invoke("CancelRightDrift", 0.25f);
                Invoke("LeftDrift", 0.25f);
                Invoke("CancelLeftDrift", 0.4f);
                Invoke("MadeRotationCorrect",0.4f); 
            }
            else
            {
                transform.rotation = Quaternion.Euler(0f, currentRotationOfY, 0);
            }

            if (PlayerPrefs.GetFloat("entertriggerbox") == 1)
            {
                PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 1);
                PlayerPrefs.SetFloat("entertriggerbox", 0);
            }
        }
        else if (PlayerPrefs.GetInt("skill") == 3)
        {
            if (PlayerPrefs.GetFloat("timeslow") == 1)
            {
                if (PlayerPrefs.GetInt("currentcarindex") == 2 || PlayerPrefs.GetInt("currentcarindex") == 9 || PlayerPrefs.GetInt("currentcarindex") == 10)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, currentPositionOfY + increase360Degree, transform.position.z), Time.deltaTime * speed);
                    transform.Rotate(new Vector3(0f, 0f, 60f) * Time.deltaTime * speed*3.2f);
                }
                else
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, currentPositionOfY + increase360Degree, transform.position.z), Time.deltaTime * speed);
                    transform.Rotate(new Vector3(60f, 0f, 0f) * Time.deltaTime * speed*3.2f);
                }
            }
            else
            {
                transform.rotation = Quaternion.Euler(0f, currentRotationOfY, 0);
                transform.position = new Vector3(transform.position.x, currentPositionOfY, transform.position.z);
            }

            if (PlayerPrefs.GetFloat("entertriggerbox") == 1)
            {
                PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 1);
                PlayerPrefs.SetFloat("entertriggerbox", 0);
            }
        }
        else if (PlayerPrefs.GetInt("skill") == 4)
        {
            if (PlayerPrefs.GetFloat("timeslow") == 1)
            {
                Invoke("MakeCarSmall" , 0.00001f);
                Invoke("CancelCarSmall", 0.15f);
                Invoke("MakeCarNormal", 0.15f);
            }
            else
            {
                transform.localScale = currentScale;
            }

            if (PlayerPrefs.GetFloat("entertriggerbox") == 1)
            {
                PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 1);
                PlayerPrefs.SetFloat("entertriggerbox", 0);
            }
        }


    }

    public void RightDrift()
    {
        transform.Rotate(new Vector3(0f, 15f, 0f) * Time.deltaTime * speed*3);
    }
    public void LeftDrift()
    {
        transform.Rotate(new Vector3(0f, -30f, 0f) * Time.deltaTime * speed*15);
    }
    public void CancelRightDrift()
    {
        CancelInvoke("RightDrift");
    }
    public void CancelLeftDrift()
    {
        CancelInvoke("LeftDrift");
    }
    public void MadeRotationCorrect()
    {
        transform.rotation = Quaternion.Euler(0f, currentRotationOfY, 0);
    }


    public void MakeCarSmall()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(0.001f, 0.001f, 0.001f), Time.deltaTime * 10);
    }
    public void CancelCarSmall()
    {
        CancelInvoke("MakeCarSmall");
    }
    public void MakeCarNormal()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, currentScale, Time.deltaTime * 25);
    }

}
