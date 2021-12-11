using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float rotationSpeed;
    public bool IsRunning;
    public Animator anim;
    private bool canBuy;
    Bank mySold;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mySold = GetComponent<Bank>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 MoveDirection = new Vector3(moveHorizontal, 0.0F, moveVertical);
        anim.SetFloat("Speed", MoveDirection!=Vector3.zero?1:0);
        MoveDirection.Normalize();
        rb.velocity = MoveDirection * speed;
        
        if(MoveDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(MoveDirection,Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed);
        }


        //Gestion Trigger

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(mySold.getMoney());
         
            if (canBuy == true)
            {
                mySold.buySheep();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "uglyVan")
        {
            canBuy = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "uglyVan")
        {
            canBuy = false;
        }
    }
}
