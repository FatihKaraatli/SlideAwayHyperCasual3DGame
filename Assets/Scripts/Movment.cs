using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    float speed = 67500f;
    Rigidbody rb;
    bool triggerControl = false;
    public AudioSource slowSource;
    bool buttonControl = false;
    Movment movment;
    
    void Start()
    {
        movment = GetComponent<Movment>();
        PlayerPrefs.SetFloat("timeslow", 0);
        PlayerPrefs.SetFloat("entertriggerbox", 0);
        PlayerPrefs.SetString("isDead", "false");
        PlayerPrefs.SetString("isFinish", "false");
        PlayerPrefs.SetString("vibration" , "true");
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (buttonControl)
        {
            PlayerPrefs.SetFloat("timeslow", 1);
            PlayerPrefs.SetFloat("entertriggerbox", 0);

            transform.position = Vector3.Lerp(transform.position, new Vector3(0, transform.position.y, transform.position.z+24), Time.deltaTime * 2.5f);
            Time.timeScale = 0.5f;
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "triggerbox")
        {
            PlayerPrefs.SetFloat("entertriggerbox", 1);
            PlayerPrefs.SetFloat("timeslow", 0);
            Debug.Log("Triggere dokundu");
            rb.isKinematic = true;
            rb.isKinematic = false;
            Time.timeScale = 1f;
            buttonControl = false;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "block")
        {
            Debug.Log("Blocka dokundu");
            if (PlayerPrefs.GetString("vibration") == "true" && PlayerPrefs.GetString("vibrationbutton") == "on")
            {
                Handheld.Vibrate();
                PlayerPrefs.SetString("vibration", "false");
            }
            buttonControl = false;
            rb.isKinematic = true;
            movment.enabled = false;
            PlayerPrefs.SetString("isDead","true");
        }
        else if (other.gameObject.tag == "Finish")
        {
            PlayerPrefs.SetFloat("entertriggerbox", 1);
            buttonControl = false;
            rb.isKinematic = true;
            movment.enabled = false;
            PlayerPrefs.SetString("isFinish", "true");
        }
    }

    public void TouchInput()
    {
        if (PlayerPrefs.GetFloat("timeslow") == 0)
        {
            slowSource.Play();
            PlayerPrefs.SetInt("instruction", 1);
        }
        buttonControl = true;
        
    }




}
