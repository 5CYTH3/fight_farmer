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
    private RaycastHit Hit;
    public Animator animator;

    void Start()
    {
        this.animalBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        animator.SetFloat("Speed", 1);

    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "fence" || other.gameObject.tag == "barn") {
            transform.Rotate(Vector3.up * UnityEngine.Random.Range(90, 180));
        } else {
            Physics.IgnoreLayerCollision(6, 6);
        }
    }
}
