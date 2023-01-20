using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class forButtons : MonoBehaviour
{
    public static forButtons instance;
    public AudioSource onclickaudio;
   
    public TMP_Text health;
    public TMP_Text scoreText;
    public int score= 0;
    int healthpoint = 5;
    public Button redImage;
    public Button blueImage;
    public Button greenImage;
    public Button yellowImage;
    private void Awake()
    {
        scoreText.text = "Score: " + score.ToString();
        health.text = "Health : " + healthpoint.ToString();
    }
    public void Update()
    {
        if(healthpoint == 0)
        {
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (score == 30)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
    public void blue_onclick()
    {
        onclickaudio.Play();
        if (BallManagerrr.bm.isBlue)
        {
            if (blueImage.image.color == BallManagerrr.bm.cl)
            {
                score++;
                scoreText.text = "Score: "+score.ToString();
                Debug.Log("blue Color");
            }
            else
            {
                healthpoint--;
                health.text = "Health : "+healthpoint.ToString();
            }

        }
        BallManagerrr.bm.isBlue = false;


    }
    public void green_onclick()
    {
        onclickaudio.Play();
        if (BallManagerrr.bm.isGreen)
        {
            if (greenImage.image.color == BallManagerrr.bm.cl)
            {
                score++;
                scoreText.text = "Score: " + score.ToString();
                Debug.Log("green Color");
            }
            else
            {
                healthpoint--;
                health.text = "Health : " + healthpoint.ToString();
            }
        }
        BallManagerrr.bm.isGreen = false;


    }
    public void yellow_onclick()
    {
        onclickaudio.Play();
        if (BallManagerrr.bm.isYellow)
        {
            if (yellowImage.image.color == BallManagerrr.bm.cl)
            {
                score++;
                scoreText.text = "Score: " + score.ToString();
                Debug.Log("yellow Color");
            }
            else
            {
                healthpoint--;
                health.text = "Health : " + healthpoint.ToString();
            }
        }
        BallManagerrr.bm.isYellow = false;  
    }
    public void red_onclick()
    {
        onclickaudio.Play();
        if (BallManagerrr.bm.isRed)
        {
            if (redImage.image.color == BallManagerrr.bm.cl)
            {
                score++;
                scoreText.text = "Score: " + score.ToString();
                Debug.Log("red Color");
            }
            else
            {
                healthpoint--;
                health.text = "Health : " + healthpoint.ToString();
            }
        }
        BallManagerrr.bm.isRed = false;   
    }
}

