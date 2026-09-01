using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text highscoreText;
    public GameObject scoreShowtxt;
    public Text scoretext;

    public int Highscore = 0;
    public int Score = 0;

    void Start()
    {   
        scoretext.text = Score.ToString();
        highscoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

        Debug.Log(Highscore);
    }

    public void CheckHighscore()
    {

        if (Score > PlayerPrefs.GetInt("HighScore",0))
        {

            PlayerPrefs.SetInt("HighScore", Score);
            highscoreText.text = Score.ToString();

            if (Score > Highscore)
            {
                highscoreText.text = Score.ToString();
            }
        }

    }

    public void Update()
    {
        CheckHighscore();
    }

    //points ads
    public void AddPoint() //food
    {
        Score += 1;
        scoretext.text = Score.ToString();       
    }

    public void ShowScore()
    {
        scoreShowtxt.SetActive(true);
    }
    public void HideScore()
    {
        scoreShowtxt.SetActive(false);
    }
}
