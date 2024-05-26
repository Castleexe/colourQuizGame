using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    static int score = 0;
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();

        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            updateHighScore();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void resetScore()
    {
        score = 0;
    }

    public void updateHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}

