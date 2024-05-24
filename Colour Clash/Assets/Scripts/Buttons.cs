using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    Score score;
    [SerializeField] GameObject colourTheoryPanel;
    [SerializeField] GameObject HowToPlayPanel;
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

    public void enableColourTheory()
    {
        colourTheoryPanel.SetActive(true);
    }

    public void disableColourTheory() 
    {
        colourTheoryPanel.SetActive(false);
    }

    public void enableHowToPlay()
    {
        HowToPlayPanel.SetActive(true);
    }

    public void disableHowToPlay()
    {
        HowToPlayPanel.SetActive(false);
    }
}
