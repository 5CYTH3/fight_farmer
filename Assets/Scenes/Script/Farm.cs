using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Farm : MonoBehaviour
{
    public int numberOfSheep;
    public int numberOfWolf;
    public GameObject sheep;
    public GameObject wolf;

    public Transform SpawnPoint;
    public Transform SpawnPointWolf;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(numberOfSheep);
    }

    public void spawnSheep()
    {

        Instantiate(sheep, SpawnPoint.position, SpawnPoint.rotation);
        numberOfSheep++;
    }
    public void spawnWolf()
    {
        Instantiate(wolf, SpawnPointWolf.position, SpawnPointWolf.rotation);
        numberOfWolf++;

    }


}
