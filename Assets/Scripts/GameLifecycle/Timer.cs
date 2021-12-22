using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    private TimeSpan t;
    private string timeLeftFormatted;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        t = TimeSpan.FromSeconds(UnityEngine.Mathf.Round(timeLeft));
        timeLeftFormatted = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);

        if (timeLeft < 0)
        {
            GameOver();
        }
    }

    public string getTimeLeft() {
        return this.timeLeftFormatted;
    } 
    public void GameOver()
    {
        SceneManager.LoadScene("EndGame");
    }
}
