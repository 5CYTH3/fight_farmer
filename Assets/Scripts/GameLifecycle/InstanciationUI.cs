using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiGestion : MonoBehaviour
{
    public Text leftPlayerMoney;
    public Text rightPlayerMoney;
    public Text NumberOfSheepRight;
    public Text NumberOfSheepLeft;
    public GameObject player1;
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftPlayerMoney.text = player1.GetComponent<Bank>().getMoney().ToString();
        rightPlayerMoney.text = player2.GetComponent<Bank>().getMoney().ToString();
        NumberOfSheepRight.text = player2.GetComponent<Farm>().numberOfSheep.ToString();
        NumberOfSheepLeft.text = player1.GetComponent<Farm>().numberOfSheep.ToString();

    }

}
