using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject restart;
    public TextMeshProUGUI levelText;
    bool sizeControl = true;
    float scaleX = 0;

    public GameObject GameOverPanelAds;
    public GameObject restartAds;
    float scaleXAds = 0;
    public TextMeshProUGUI levelTextAds;

    void Start()
    {
        //PlayerPrefs.SetInt("ads", 0);
        scaleX = restart.transform.localScale.x;
        scaleXAds = restartAds.transform.localScale.x;
    }

    void Update()
    {
        /*if (PlayerPrefs.GetInt("ads") == 2)
        {
            if (PlayerPrefs.GetString("isDead") == "true")
            {
                GameOverPanelAds.SetActive(true);
                levelTextAds.text = "Level: " + PlayerPrefs.GetInt("level");
            }

            if (sizeControl)
            {
                restartAds.transform.localScale = new Vector3(restartAds.transform.localScale.x + 0.001f, restartAds.transform.localScale.y + 0.001f, restartAds.transform.localScale.z + 0.001f);
                Invoke("IncreaseSize", 0.25f);
            }
            else
            {
                if (restartAds.transform.localScale.x != scaleXAds)
                {
                    restartAds.transform.localScale = new Vector3(restartAds.transform.localScale.x - 0.001f, restartAds.transform.localScale.y - 0.001f, restartAds.transform.localScale.z - 0.001f);
                }
                Invoke("DecreaseSize", 0.25f);
            }
        }*/
        //else
        //{
            if (PlayerPrefs.GetString("isDead") == "true")
            {
                GameOverPanel.SetActive(true);
                levelText.text = "Level: " + PlayerPrefs.GetInt("level");
            }

            if (sizeControl)
            {
                restart.transform.localScale = new Vector3(restart.transform.localScale.x + 0.001f, restart.transform.localScale.y + 0.001f, restart.transform.localScale.z + 0.001f);
                Invoke("IncreaseSize", 0.25f);
            }
            else
            {
                if (restart.transform.localScale.x != scaleX)
                {
                    restart.transform.localScale = new Vector3(restart.transform.localScale.x - 0.001f, restart.transform.localScale.y - 0.001f, restart.transform.localScale.z - 0.001f);
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


    public void Restart()
    {
        PlayerPrefs.SetString("isDead", "false");
        PlayerPrefs.SetInt("restart", 1);
        PlayerPrefs.SetInt("instruction", 1);
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
