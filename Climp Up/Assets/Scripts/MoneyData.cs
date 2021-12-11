using UnityEngine;

public static class MoneyData
{
    private static int coin = 999;
    private static int shopPrice = 1;
    private static int levl = 1;

    public static int Levl
    {
        get => levl;
        set => levl = value;
    }

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
