using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    
    public Text cointText;
    private void FixedUpdate()
    {
        cointText.text = "Coin: " + MoneyData.Coin;
    }
    public void MainLoad()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
    public void MenuLoad()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
