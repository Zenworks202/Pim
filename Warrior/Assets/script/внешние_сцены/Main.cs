using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Lele()
    {
        SceneManager.LoadScene("Levels");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
