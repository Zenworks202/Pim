using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Point : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }



    public void Exit()
    {
        Application.Quit();
    }

}