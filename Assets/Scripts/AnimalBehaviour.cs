using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody animalBody;
    private Transform rotateTo;
    private Transform rotateFrom;


    void Start()
    {
        this.animalBody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        // this.animalBody.MoveRotation(Quaternion.Slerp(this.rotateFrom.rotation, this.rotateTo.rotation, Time.deltaTime / 1));
    }
}
