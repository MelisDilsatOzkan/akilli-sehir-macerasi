using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void ExitButton()
    {
        SceneManager.LoadScene(0);
    }
    public void Game1()
    {
        SceneManager.LoadScene(1);
    }
    public void Game2()
    {
        SceneManager.LoadScene(2);
    }
}

        
