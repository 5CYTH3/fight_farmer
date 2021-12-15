using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterFarmHouse : MonoBehaviour
{

    public Camera farmCam;
    public Camera mainCam;
    private bool isColliding;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isColliding = false;

    }
    private void OnTriggerEnter(Collider other)
    {

        if (isColliding) return;
        if(mainCam.name == "Player1Camera" && other.gameObject.layer == 8)
        {
            mainCam.enabled = false;
            farmCam.enabled = true;
        }
        else if(mainCam.name == "Player2Camera" && other.gameObject.layer == 9)
        {
            mainCam.enabled = false;
            farmCam.enabled = true;
        }
        isColliding = true;
    }
    

    private void OnTriggerExit(Collider other)
    {
        if (isColliding) return;
        isColliding = true;
        if (mainCam.name == "Player1Camera" && other.gameObject.layer == 8)
        {

            mainCam.enabled = true;
            farmCam.enabled = false;
        }
        else if(mainCam.name == "Player2Camera" && other.gameObject.layer == 9)
        {
            mainCam.enabled = true;
            farmCam.enabled = false;
        }
    }

}
