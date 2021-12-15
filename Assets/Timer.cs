using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text TimeLeftUi;
    public float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        
        TimeLeftUi.text = UnityEngine.Mathf.Round(timeLeft).ToString();
        if (timeLeft < 0)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("EndGame");
    }
}
