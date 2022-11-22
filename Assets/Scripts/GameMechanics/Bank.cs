using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{

    public GameObject entityListenerObject;
    private EntityListener entityListener;

    public int currentMoney;
    public Farm myFarm;

    private GameObject sheep;
    private GameObject wolf;
    private GameObject bigHornSheep;

    public void Start() {
        myFarm = GetComponent<Farm>();
        entityListener = entityListenerObject.GetComponent<EntityListener>();

        StartCoroutine("GenerateMoneyOverTime");

        sheep = entityListener.getSheep();
        wolf = entityListener.getWolf();
        bigHornSheep = entityListener.getBigHornSheep();

    }

    public void CreateBank(int amount) {
        currentMoney = amount;
    }

    public int getMoney() {
        return this.currentMoney;
    }

    public void buySheep() {
        if (currentMoney >= 25)
        {
            this.currentMoney = currentMoney - 25;
            myFarm.spawnEntity(sheep, "animal");
        }
    }

    public void buyWolf() {
        if(this.currentMoney >= 75)
        {
            this.currentMoney = this.currentMoney - 75;
            myFarm.spawnEntity(wolf, "wolf");
        }
    }

    public void addMoney(int MoneytoAdd) {
        this.currentMoney += MoneytoAdd;
    }

    IEnumerator GenerateMoneyOverTime() {
        while (true) {
            this.currentMoney += (myFarm.numberOfSheep * 5);
            yield return new WaitForSeconds(15f);
        }
    }
}
