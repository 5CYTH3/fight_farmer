using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shops : MonoBehaviour {
    private string[] itemArr = new string[3];
    public ShopUI shopUI;

    public void openUi() {
        shopUI.gameObject.SetActive(true);
        shopUI.gameObject.transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(shopUI.gameObject, new Vector3(1, 1, 1), 0.5f);
    }

}
