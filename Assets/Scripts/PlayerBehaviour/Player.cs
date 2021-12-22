using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool canBuySheep;
    private bool canBuyWolf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool getCanBuySheep() {
        return this.canBuySheep;
    }
    public bool getCanBuyWolf() {
        return this.canBuyWolf;
    } 

    public bool canBuy(string other) {
        if(other == "shopSheep") {
            canBuySheep = true;
            return canBuySheep;
        } else if(other == "shopWolf") {
            canBuyWolf = true;
            return canBuyWolf;
        }
        return false;
    }

    public bool cannotBuy(string other) {
        if(other == "shopSheep") {
            canBuySheep = false;
            return canBuySheep;
        } else if(other == "shopWolf") {
            canBuyWolf = false;
            return canBuyWolf;
        }
        return true;
    }

    private void OnTriggerEnter(Collider other)
    {
        canBuy(other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        cannotBuy(other.name);
    }
}
