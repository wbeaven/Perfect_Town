using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int coinTotal;
    public static int gemTotal;

    public static void AddCoin()
    {
        coinTotal++;
    }
    public static void RemoveCoin(int amount)
    {
        coinTotal -= amount;
    }
    public static void AddGem()
    {
        gemTotal++;
    }

    public static void RemoveGem(int amount)
    {
        gemTotal -= amount;
    }

}