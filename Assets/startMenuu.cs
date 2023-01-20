using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenuu : MonoBehaviour
{
    public AudioSource onclickaudio;
    public void Startbtn()
    {
        onclickaudio.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quitbtn()
    {
        onclickaudio.Play();
        Application.Quit();
    }
}
