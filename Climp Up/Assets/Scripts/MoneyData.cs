using UnityEngine;

public static class MoneyData
{
    private static int coin = 999;
    private static int shopPrice = 1;

    public static int ShopPrice
    {
        get => shopPrice;
        set => shopPrice = value;
    }

    public static int Coin
    {
        get => coin;
        set => coin = value;
    }
}
