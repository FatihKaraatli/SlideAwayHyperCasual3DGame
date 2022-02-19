using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    public GameObject confetti;

    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;
    public Transform pos5;
    public Transform pos6;
    public Transform pos7;

    public GameObject lights;
    public GameObject MainLight;

    bool control = true;
    void Start()
    {
        control = true;
    }

    
    void Update()
    {
        if (PlayerPrefs.GetString("isFinish") == "true" && control)
        {
            Instantiate(confetti , pos1.position , Quaternion.identity);
            Instantiate(confetti, pos2.position, Quaternion.identity);
            Instantiate(confetti, pos3.position, Quaternion.identity);
            Instantiate(confetti, pos4.position, Quaternion.identity);
            Instantiate(confetti, pos5.position, Quaternion.identity);
            Instantiate(confetti, pos6.position, Quaternion.identity);
            Instantiate(confetti, pos7.position, Quaternion.identity);
            lights.SetActive(true);
            MainLight.SetActive(false);
            control = false;
        }
    }
}
