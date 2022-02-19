using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelInstruction : MonoBehaviour
{
    public GameObject instructionComplatePanel;
    public GameObject touchScreen;
    bool sizeControl = true;
    float scaleX = 0;

    void Start()
    {
        PlayerPrefs.SetInt("instruction", 0);
        scaleX = touchScreen.transform.localScale.x;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("instruction") == 0 && PlayerPrefs.GetInt("level") == 0)
        {
            instructionComplatePanel.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("instruction") == 1 || PlayerPrefs.GetInt("level") != 0)
        {
            instructionComplatePanel.SetActive(false);
        }

        if (sizeControl)
        {
            touchScreen.transform.localScale = new Vector3(touchScreen.transform.localScale.x + 0.003f, touchScreen.transform.localScale.y + 0.003f, touchScreen.transform.localScale.z + 0.003f);
            Invoke("IncreaseSize", 0.3f);
        }
        else
        {
            if (touchScreen.transform.localScale.x != scaleX)
            {
                touchScreen.transform.localScale = new Vector3(touchScreen.transform.localScale.x - 0.003f, touchScreen.transform.localScale.y - 0.003f, touchScreen.transform.localScale.z - 0.003f);
            }
            Invoke("DecreaseSize", 0.3f);
        }
    }

    public void IncreaseSize()
    {
        sizeControl = false;
    }
    public void DecreaseSize()
    {
        sizeControl = true;
    }
}
