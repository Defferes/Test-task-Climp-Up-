using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Text ShopText;

    private void Update()
    {
        //ShopText.text = Convert.ToString(MoneyData.ShopPrice);
    }

    public void ClickOn()
    {
        if (MoneyData.ShopPrice <= MoneyData.Coin)
        {
            MoneyData.Coin -= MoneyData.ShopPrice;
            MoneyData.ShopPrice *= 2;
        }
    }
}
