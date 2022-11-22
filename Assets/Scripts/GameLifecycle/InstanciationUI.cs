using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InstanciationUI : MonoBehaviour
{
    public Text playerMoney;
    public Text numberOfSheep;
    public Text timeLeftUi;

    public GameObject player;
    public GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        leftPlayerMoney.text = player.GetComponent<Bank>().getMoney().ToString();
        numberOfSheep.text = player.GetComponent<Farm>().numberOfSheep.ToString();
        timeLeftUi.text = gameController.GetComponent<Timer>().getTimeLeft();

    }

}
