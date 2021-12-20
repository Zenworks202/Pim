using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelsPanel : MonoBehaviour
{
    public void First()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Sec()
    {
        SceneManager.LoadScene("Second");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
