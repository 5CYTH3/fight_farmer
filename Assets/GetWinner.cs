using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetWinner : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public int player1Money;
    public int player2Money;
    public Text GagnantText;
    
    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.Find("Player");
        player2 = GameObject.Find("Player2");
        player1Money = player1.GetComponentInChildren<Bank>().getMoney();
        player2Money = player2.GetComponentInChildren<Bank>().getMoney();
    }

    // Update is called once per frame
    void Update()
    {
        if(player1Money > player2Money)
        {
            GagnantText.text = "Player 1 est gagnant";
        }
        else if(player1Money < player2Money)
        {
            GagnantText.text = "Player 2 est gagnant";
        }
        else
        {
            GagnantText.text = "Egalité";
        }
    }
}
