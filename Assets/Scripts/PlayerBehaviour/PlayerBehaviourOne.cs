using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourOne : Player
{
    public bool IsRunning;
    public Rigidbody rb;
    public float speed;
    public float rotationSpeed;
    public Shops shop;
    public Animator anim;
    float gravity;
    float moveHorizontal;
    float moveVertical;
    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(transform.parent.gameObject);

    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementHandler();
        useButtonHandler();
    }

    void movementHandler()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 MoveDirection = new Vector3(-moveHorizontal, 0, -moveVertical);
        anim.SetFloat("Speed", MoveDirection != Vector3.zero ? 1 : 0);
        MoveDirection.Normalize();
        rb.velocity = MoveDirection * speed;

        if (MoveDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(MoveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed);
        }
    }

    void useButtonHandler()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Submit"))
        {
            if (canBuy)
            {
                shop.openUi();
            }
        }
    }

}
