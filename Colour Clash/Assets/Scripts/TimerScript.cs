using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerScript : MonoBehaviour
{
    Image timerBar;
    float maxTime = 7f;
    float timeLeft;
    // Use this for initialization
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }
    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    

}