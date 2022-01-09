using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    private void Start() {
        gameObject.SetActive(false);
    }
    public void stopAnimation() {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.35f).setOnComplete(DestroyItem);
    }

    public void DestroyItem() {
        Destroy(gameObject);
    }
}
