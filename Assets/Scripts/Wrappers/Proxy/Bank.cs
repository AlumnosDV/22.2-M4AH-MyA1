using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    int money = int.MaxValue;

    public int GetMoney(int quant)
    {
        int result = 0;
        if (quant <= money)
        {
            result = quant;
            money -= quant;
        }
        return result;
    }
}
