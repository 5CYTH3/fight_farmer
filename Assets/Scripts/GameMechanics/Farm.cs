using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Farm : MonoBehaviour
{
    public int numberOfSheep;
    public int numberOfWolf;

    public Transform SpawnPoint;
    public Transform SpawnPointWolf;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void spawnEntity(GameObject entity, string spawnPoint) {
        if (spawnPoint == "wolf") {
            Instantiate(entity, SpawnPointWolf.position, SpawnPointWolf.rotation);
            numberOfWolf++;
        } else if (spawnPoint == "animal") {
            Instantiate(entity, SpawnPoint.position, SpawnPoint.rotation);
            numberOfSheep++;
        }
    }

}
