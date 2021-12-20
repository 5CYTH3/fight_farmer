using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    public int currentMoney;
    public Farm myFarm;


    public void Start()
    {
        myFarm = GetComponent<Farm>();
        StartCoroutine("GenerateMoneyOverTime");

    }

    public void CreateBank(int amount)
    {
        currentMoney = amount;
    }

    public int getMoney()
    {
        return this.currentMoney;
    }

    public void buySheep()
    {
        if (currentMoney >= 25)
        {
            this.currentMoney = currentMoney - 25;
            myFarm.spawnSheep();
        }
    }

    public void buyWolf()
    {
        if(this.currentMoney >= 75)
        {
            this.currentMoney = this.currentMoney - 75;
            myFarm.spawnWolf();
        }
    }

    public void addMoney(int MoneytoAdd)
    {
        this.currentMoney += MoneytoAdd;
    }

    IEnumerator GenerateMoneyOverTime()
    {
        while (true) {
            this.currentMoney += (myFarm.numberOfSheep * 5);
            yield return new WaitForSeconds(15f);
        }
    }
}
