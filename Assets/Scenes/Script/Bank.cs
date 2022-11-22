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
        StartCoroutine("GenerateMoneyOverTime");

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
        if (Money >= 25)
        {
            Money = Money - 25;
            myFarm.spawnSheep();
        }
    }

    public void buyWolf()
    {
        if(Money >= 75)
        {
            Money = Money - 75;
            myFarm.spawnWolf();
        }
    }

    public void addMoney(int MoneytoAdd)
    {
        Money += MoneytoAdd;
    }

    IEnumerator GenerateMoneyOverTime()
    {
        while (true)
        {
            Money += (myFarm.numberOfSheep * 5);
            yield return new WaitForSeconds(15f);
        }
    }
}
