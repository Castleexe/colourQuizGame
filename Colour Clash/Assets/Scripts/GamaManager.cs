using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class GamaManager : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    [SerializeField] Image questionImage;
    [SerializeField] float timeBetweenQuestions = 1f;

    [SerializeField] Text trueAnswerText;
    [SerializeField] Text falseAnswerText;

    [SerializeField] Animator animator;

    Score score;

    
    private void Start()
    {
        score = GetComponent<Score>();
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }
        SetCurrentQuestion();
        
    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count());
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        questionImage.sprite = currentQuestion.sprite;

        if (currentQuestion.isTrue)
        {
            trueAnswerText.text = "CORRECT";
            falseAnswerText.text = "INCORRECT";
        }
        else
        {
            trueAnswerText.text = "INCORRECT";
            falseAnswerText.text = "CORRECT";
        }
    }

    IEnumerator TransitionToNextQuestion ()
    {
        unansweredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestions);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectTrue()    
    {
        animator.SetTrigger("True");
        if (currentQuestion.isTrue)
        {
            Debug.Log("CORRECT!");
            score.addScore();
        }
        else
        {
            Debug.Log("WRONG! BOO HOO");
            SceneManager.LoadScene("GameOver");
        }
        StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectFalse()
    {
        animator.SetTrigger("False");
        if (!currentQuestion.isTrue)
        {
            Debug.Log("CORRECT!");
            score.addScore();
        }
        else
        {
            Debug.Log("WRONG! BOO HOO");
            SceneManager.LoadScene("GameOver");
        }
        StartCoroutine(TransitionToNextQuestion());
    }
}
