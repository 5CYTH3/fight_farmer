using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    public int Money;
    public Farm myFarm;

    public void Start()
    {
        myFarm = GetComponent<Farm>();        
    }

    public void CreateBank(int Montant)
    {
        Money = Montant;
    }

    public int getMoney()
    {
        return Money;
    }

    public void buySheep()
    {
        if (Money >= 5)
        {
            Money = Money - 5;
            myFarm.spawnSheep();
        }
    }
}
