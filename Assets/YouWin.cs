using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    public AudioSource onclickaudio;
    public void playAgainbtn()
    {
        onclickaudio.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    }
    public void exitbtn()
    {
        onclickaudio.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }
}
