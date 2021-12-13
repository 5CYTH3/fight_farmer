using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour
{
    public int numberOfSheep;
    public GameObject sheep;
    public Transform SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(numberOfSheep);
    }

    public void spawnSheep() {
        Debug.Log("Sheep Spawn");
        Instantiate(sheep, SpawnPoint.position,SpawnPoint.rotation) ;
    }
}
