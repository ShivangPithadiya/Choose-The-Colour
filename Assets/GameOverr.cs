using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverr : MonoBehaviour
{
    public AudioSource gameover;
    public AudioSource onclickaudio;
    private void Awake()
    {
        gameover.Play();
    }
    public void playAgainbtn()
    {
        onclickaudio.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void exitbtn()
    {
        onclickaudio.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
