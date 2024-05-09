using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static int score = 0;
    [SerializeField] Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
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
}
