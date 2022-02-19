using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishLine : MonoBehaviour
{
    public GameObject levelComplatePanel;
    public GameObject nextLevel;
    public TextMeshProUGUI levelText;
    bool sizeControl = true;
    float scaleX = 0;


    public GameObject levelComplatePanelAds;
    public GameObject nextLevelAds;
    float scaleXAds = 0;
    public TextMeshProUGUI levelTextAds;

    void Start()
    {
        //PlayerPrefs.SetInt("level", 0);
        scaleX = nextLevel.transform.localScale.x;
        scaleXAds = nextLevelAds.transform.localScale.x;

    }

    
    void Update()
    {
        /*if (PlayerPrefs.GetInt("ads") == 2)
        {
            if (PlayerPrefs.GetString("isFinish") == "true")
            {
                levelComplatePanelAds.SetActive(true);
                levelTextAds.text = "Level: " + PlayerPrefs.GetInt("level");
            }

            if (sizeControl)
            {
                nextLevelAds.transform.localScale = new Vector3(nextLevelAds.transform.localScale.x + 0.001f, nextLevelAds.transform.localScale.y + 0.001f, nextLevelAds.transform.localScale.z + 0.001f);
                Invoke("IncreaseSize", 0.25f);
            }
            else
            {
                if (nextLevelAds.transform.localScale.x != scaleXAds)
                {
                    nextLevelAds.transform.localScale = new Vector3(nextLevelAds.transform.localScale.x - 0.001f, nextLevelAds.transform.localScale.y - 0.001f, nextLevelAds.transform.localScale.z - 0.001f);
                }
                Invoke("DecreaseSize", 0.25f);
            }
        }*/
        //else
        //{
            if (PlayerPrefs.GetString("isFinish") == "true")
            {
                levelComplatePanel.SetActive(true);
                levelText.text = "Level: " + PlayerPrefs.GetInt("level");
            }

            if (sizeControl)
            {
                nextLevel.transform.localScale = new Vector3(nextLevel.transform.localScale.x + 0.001f, nextLevel.transform.localScale.y + 0.001f, nextLevel.transform.localScale.z + 0.001f);
                Invoke("IncreaseSize", 0.25f);
            }
            else
            {
                if (nextLevel.transform.localScale.x != scaleX)
                {
                    nextLevel.transform.localScale = new Vector3(nextLevel.transform.localScale.x - 0.001f, nextLevel.transform.localScale.y - 0.001f, nextLevel.transform.localScale.z - 0.001f);
                }
                Invoke("DecreaseSize", 0.25f);
            }
        //}

    }

    public void IncreaseSize()
    {
        sizeControl = false;
    }
    public void DecreaseSize()
    {
        sizeControl = true;
    }

    public void NextLevel()
    {
        PlayerPrefs.SetString("isFinish", "false");
        PlayerPrefs.SetInt("level",PlayerPrefs.GetInt("level")+1);
        PlayerPrefs.SetInt("instruction", 1);
        PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money")+100);
        PlayerPrefs.SetFloat("entertriggerbox", 0);
        PlayerPrefs.SetString("vibration", "true");
        if (PlayerPrefs.GetInt("ads") == 2)
        {
            PlayerPrefs.SetInt("ads", 0);
        }
        else
        {
            PlayerPrefs.SetInt("ads", PlayerPrefs.GetInt("ads") + 1);
            SceneManager.LoadScene("SampleScene");
        }
    }
}
