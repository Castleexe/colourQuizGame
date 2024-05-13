using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        score.resetScore();
        SceneManager.LoadScene("MainLevel");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
