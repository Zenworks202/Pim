using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinP : MonoBehaviour
{
    [SerializeField]
    GameObject FinishPanel;
    void Start()
    {
        FinishPanel.SetActive(false);
    }
    public void Menuu()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }


}