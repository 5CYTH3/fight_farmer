using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool canBuy;
    void Start() {

    }

    private void OnTriggerEnter(Collider other) {
        if(other.name == "shop") {
            canBuy = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.name == "shop") {
            canBuy = false;
        }
    }
}
