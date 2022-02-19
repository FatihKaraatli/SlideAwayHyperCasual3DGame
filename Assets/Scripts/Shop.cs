using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    public GameObject shop;
    public GameObject[] cars;
    public GameObject[] carPhotos;
    public GameObject[] buyButtons;
    public GameObject[] chooseButtons;
    public GameObject[] prices;
    public GameObject money;
    public TextMeshProUGUI moneyText;

    int photoIndex = 0;
    int currentCarIndex = 0;

    public GameObject tus;
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("skill", 0);
        //PlayerPrefs.SetFloat("money", 999999);
        //PlayerPrefs.SetString("buyjett", "false");
        //PlayerPrefs.SetInt("currentcarindex", 0);
        currentCarIndex = PlayerPrefs.GetInt("currentcarindex");
        
        for (int i = 0; i < carPhotos.Length; i++)
        {
            if (i == 0)
            {
                carPhotos[i].SetActive(true);
            }
            else
            {
                carPhotos[i].SetActive(false);
            }
        }

        for (int i = 0; i < cars.Length; i++)
        {
            if (i == currentCarIndex)
            {
                cars[i].SetActive(true);
            }
            else
            {
                cars[i].SetActive(false);
            }
        }

        prices[0].SetActive(false);
        buyButtons[0].SetActive(false);
        chooseButtons[0].SetActive(true);
    }

    void Update()
    {
        //Debug.Log("Money: " + PlayerPrefs.GetFloat("money"));
        moneyText.text = "Money: " + PlayerPrefs.GetFloat("money").ToString();
        for (int i = 0; i < cars.Length; i++)
        {
            if (i == PlayerPrefs.GetInt("currentcarindex"))
            {
                cars[i].SetActive(true);
            }
            else
            {
                cars[i].SetActive(false);
            }
        }
    }

    public void ClassicBuyButton()
    {
        
    }
    public void BlueCarBuyButton()
    {
        if (PlayerPrefs.GetFloat("money") >= 500)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - 500);
            PlayerPrefs.SetInt("currentcarindex", 1);
            PlayerPrefs.SetString("buybluecar", "true");
        }
        if (PlayerPrefs.GetString("buybluecar") == "true")
        {
            prices[1].SetActive(false);
            buyButtons[1].SetActive(false);
            chooseButtons[1].SetActive(true);
        }
        else
        {
            prices[1].SetActive(true);
            buyButtons[1].SetActive(true);
            chooseButtons[1].SetActive(false);
        }
    }
    public void TaxiBuyButton()
    {
        if (PlayerPrefs.GetFloat("money") >= 700)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - 700);
            PlayerPrefs.SetInt("currentcarindex", 2);
            PlayerPrefs.SetString("buytaxi", "true");
        }
        if (PlayerPrefs.GetString("buytaxi") == "true")
        {
            prices[2].SetActive(false);
            buyButtons[2].SetActive(false);
            chooseButtons[2].SetActive(true);
        }
        else
        {
            prices[2].SetActive(true);
            buyButtons[2].SetActive(true);
            chooseButtons[2].SetActive(false);
        }
    }
    public void TruckBuyButton()
    {
        if (PlayerPrefs.GetFloat("money") >= 1000)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - 1000);
            PlayerPrefs.SetInt("currentcarindex", 3);
            PlayerPrefs.SetString("buytruck", "true");
        }
        if (PlayerPrefs.GetString("buytruck") == "true")
        {
            prices[3].SetActive(false);
            buyButtons[3].SetActive(false);
            chooseButtons[3].SetActive(true);
        }
        else
        {
            prices[3].SetActive(true);
            buyButtons[3].SetActive(true);
            chooseButtons[3].SetActive(false);
        }
    }
    public void PoliceBuyButton()
    {
        if (PlayerPrefs.GetFloat("money") >= 1500)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - 1500);
            PlayerPrefs.SetInt("currentcarindex", 4);
            PlayerPrefs.SetString("buypolice", "true");
        }
        if (PlayerPrefs.GetString("buypolice") == "true")
        {
            prices[4].SetActive(false);
            buyButtons[4].SetActive(false);
            chooseButtons[4].SetActive(true);
        }
        else
        {
            prices[4].SetActive(true);
            buyButtons[4].SetActive(true);
            chooseButtons[4].SetActive(false);
        }
    }
    public void MustangBuyButton()
    {
        if (PlayerPrefs.GetFloat("money") >= 2000)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - 2000);
            PlayerPrefs.SetInt("currentcarindex", 5);
            PlayerPrefs.SetString("buymustang", "true");
        }
        if (PlayerPrefs.GetString("buymustang") == "true")
        {
            prices[5].SetActive(false);
            buyButtons[5].SetActive(false);
            chooseButtons[5].SetActive(true);
        }
        else
        {
            prices[5].SetActive(true);
            buyButtons[5].SetActive(true);
            chooseButtons[5].SetActive(false);
        }
    }
    public void OffroadBuyButton()
    {
        if (PlayerPrefs.GetFloat("money") >= 2400)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - 2400);
            PlayerPrefs.SetInt("currentcarindex", 6);
            PlayerPrefs.SetString("buyoffroad", "true");
        }
        if (PlayerPrefs.GetString("buyoffroad") == "true")
        {
            prices[6].SetActive(false);
            buyButtons[6].SetActive(false);
            chooseButtons[6].SetActive(true);
        }
        else
        {
            prices[6].SetActive(true);
            buyButtons[6].SetActive(true);
            chooseButtons[6].SetActive(false);
        }
    }
    public void BagettiBuyButton()
    {
        if (PlayerPrefs.GetFloat("money") >= 5000)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - 5000);
            PlayerPrefs.SetInt("currentcarindex", 7);
            PlayerPrefs.SetString("buybagetti", "true");
        }
        if (PlayerPrefs.GetString("buybagetti") == "true")
        {
            prices[7].SetActive(false);
            buyButtons[7].SetActive(false);
            chooseButtons[7].SetActive(true);
        }
        else
        {
            prices[7].SetActive(true);
            buyButtons[7].SetActive(true);
            chooseButtons[7].SetActive(false);
        }
    }
    public void RocketBuyButton()
    {
        if (PlayerPrefs.GetFloat("money") >= 7500)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - 7500);
            PlayerPrefs.SetInt("currentcarindex", 8);
            PlayerPrefs.SetString("buyrocket", "true");
        }
        if (PlayerPrefs.GetString("buyrocket") == "true")
        {
            prices[8].SetActive(false);
            buyButtons[8].SetActive(false);
            chooseButtons[8].SetActive(true);
        }
        else
        {
            prices[8].SetActive(true);
            buyButtons[8].SetActive(true);
            chooseButtons[8].SetActive(false);
        }
    }
    public void GalaxyBuyButton()
    {
        if (PlayerPrefs.GetFloat("money") >= 10000)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - 10000);
            PlayerPrefs.SetInt("currentcarindex", 9);
            PlayerPrefs.SetString("buygalaxy", "true");
        }
        if (PlayerPrefs.GetString("buygalaxy") == "true")
        {
            prices[9].SetActive(false);
            buyButtons[9].SetActive(false);
            chooseButtons[9].SetActive(true);
        }
        else
        {
            prices[9].SetActive(true);
            buyButtons[9].SetActive(true);
            chooseButtons[9].SetActive(false);
        }
    }
    public void JettBuyButton()
    {
        if (PlayerPrefs.GetFloat("money") >= 15000)
        {
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - 15000);
            PlayerPrefs.SetInt("currentcarindex", 10);
            PlayerPrefs.SetString("buyjett", "true");
        }
        if (PlayerPrefs.GetString("buyjett") == "true")
        {
            prices[10].SetActive(false);
            buyButtons[10].SetActive(false);
            chooseButtons[10].SetActive(true);
        }
        else
        {
            prices[10].SetActive(true);
            buyButtons[10].SetActive(true);
            chooseButtons[10].SetActive(false);
        }
    }



    public void ClassicChooseButton()
    {
        PlayerPrefs.SetInt("currentcarindex", 0);
    }
    public void BlueCarChooseButton()
    {
        PlayerPrefs.SetInt("currentcarindex", 1);
    }
    public void TaxiChooseButton()
    {
        PlayerPrefs.SetInt("currentcarindex", 2);
    }
    public void TruckChooseButton()
    {
        PlayerPrefs.SetInt("currentcarindex", 3);
    }
    public void PoliceChooseButton()
    {
        PlayerPrefs.SetInt("currentcarindex", 4);
    }
    public void MustangChooseButton()
    {
        PlayerPrefs.SetInt("currentcarindex", 5);
    }
    public void OffroadChooseButton()
    {
        PlayerPrefs.SetInt("currentcarindex", 6);
    }
    public void BagettiChooseButton()
    {
        PlayerPrefs.SetInt("currentcarindex", 7);
    }
    public void RocketChooseButton()
    {
        PlayerPrefs.SetInt("currentcarindex", 8);
    }
    public void GalaxyChooseButton()
    {
        PlayerPrefs.SetInt("currentcarindex", 9);
    }
    public void JettChooseButton()
    {
        PlayerPrefs.SetInt("currentcarindex", 10);
    }









    public void Back()
    {
        shop.SetActive(false);
    }

    public void Right()
    {
        photoIndex++;
        if (photoIndex > 10)
        {
            photoIndex = 0;
        }
        for (int i = 0; i < carPhotos.Length; i++)
        {
            if (i == photoIndex)
            {
                carPhotos[i].SetActive(true);
            }
            else
            {
                carPhotos[i].SetActive(false);
            }
        }

        if (photoIndex == 0)
        {
            for(int i = 0; i < prices.Length; i++)
            {
                if (i == 0)
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(true);
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 1)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 1)
                {
                    if (PlayerPrefs.GetString("buybluecar") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 2)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 2)
                {
                    if (PlayerPrefs.GetString("buytaxi") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 3)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 3)
                {
                    if (PlayerPrefs.GetString("buytruck") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 4)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 4)
                {
                    if (PlayerPrefs.GetString("buypolice") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 5)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 5)
                {
                    if (PlayerPrefs.GetString("buymustang") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 6)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 6)
                {
                    if (PlayerPrefs.GetString("buyoffroad") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 7)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 7)
                {
                    if (PlayerPrefs.GetString("buybagetti") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 8)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 8)
                {
                    if (PlayerPrefs.GetString("buyrocket") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 9)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 9)
                {
                    if (PlayerPrefs.GetString("buygalaxy") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 10)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 10)
                {
                    if (PlayerPrefs.GetString("buyjett") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }

    }

    public void Left()
    {
        photoIndex--;
        if (photoIndex < 0)
        {
            photoIndex = 10;
        }
        for (int i = 0; i < carPhotos.Length; i++)
        {
            if (i == photoIndex)
            {
                carPhotos[i].SetActive(true);
            }
            else
            {
                carPhotos[i].SetActive(false);
            }
        }


        if (photoIndex == 0)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 0)
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(true);
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 1)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 1)
                {
                    if (PlayerPrefs.GetString("buybluecar") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 2)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 2)
                {
                    if (PlayerPrefs.GetString("buytaxi") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 3)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 3)
                {
                    if (PlayerPrefs.GetString("buytruck") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 4)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 4)
                {
                    if (PlayerPrefs.GetString("buypolice") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 5)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 5)
                {
                    if (PlayerPrefs.GetString("buymustang") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 6)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 6)
                {
                    if (PlayerPrefs.GetString("buyoffroad") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 7)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 7)
                {
                    if (PlayerPrefs.GetString("buybagetti") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 8)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 8)
                {
                    if (PlayerPrefs.GetString("buyrocket") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 9)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 9)
                {
                    if (PlayerPrefs.GetString("buygalaxy") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }
        else if (photoIndex == 10)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 10)
                {
                    if (PlayerPrefs.GetString("buyjett") == "true")
                    {
                        prices[i].SetActive(false);
                        buyButtons[i].SetActive(false);
                        chooseButtons[i].SetActive(true);
                    }
                    else
                    {
                        prices[i].SetActive(true);
                        buyButtons[i].SetActive(true);
                        chooseButtons[i].SetActive(false);
                    }
                }
                else
                {
                    prices[i].SetActive(false);
                    buyButtons[i].SetActive(false);
                    chooseButtons[i].SetActive(false);
                }
            }
        }



    }


}
