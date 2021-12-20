using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

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
        TimeSpan t = TimeSpan.FromSeconds(UnityEngine.Mathf.Round(timeLeft));
        string timeLeftFormatted = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);

        TimeLeftUi.text = timeLeftFormatted;

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
