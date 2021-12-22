using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityListener : MonoBehaviour
{
    public GameObject wolf;
    public GameObject cow;
    public GameObject sheep;
    public GameObject bigHornSheep;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject getWolf() {
        return this.wolf;
    }

    public GameObject getCow() {
        return this.cow;
    }

    public GameObject getBigHornSheep() {
        return this.bigHornSheep;
    }

    public GameObject getSheep() {
        return this.sheep;
    }

}
