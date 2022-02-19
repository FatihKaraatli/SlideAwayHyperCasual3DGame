using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public Camera cam;
    public GameObject car;
    public float speed;
    bool control = true;
    void Start()
    {
        control = true;
    }

    
    void Update()
    {
        if (PlayerPrefs.GetFloat("timeslow") == 1)
        {
            cam.transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, car.transform.position.z-7), Time.deltaTime * 5f);
        }
        else
        {
            cam.transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, car.transform.position.z-5), Time.deltaTime * 10f);
        }

        if (PlayerPrefs.GetString("isFinish") == "true")
        {
            cam.transform.position = Vector3.Lerp(transform.position, new Vector3(2.5f, 3f, cam.transform.position.z+11), Time.deltaTime * 5f);
            
            cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, Quaternion.Euler(cam.transform.localEulerAngles.x,-150, cam.transform.localEulerAngles.z), Time.deltaTime * speed);
        }
    }
}
