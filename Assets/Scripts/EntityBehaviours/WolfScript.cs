using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfScript : MonoBehaviour
{
    private int health;

    // Start is called before the first frame update
    void Start()
    {
        health = Random.Range(2, 4);
    }

    private void Update()
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "sheep")
        {
            health--;
            Destroy(collision.gameObject);
            
        }
    }
}
