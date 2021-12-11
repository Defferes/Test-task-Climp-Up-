using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class GameManager : MonoBehaviour
{
   public Text failText, restartText, menuText, levelText;
   public Button restartButton, menuButton;
   private int StartCoin;
   

   private void Start()
   {
      StartCoin = MoneyData.Coin;
   }

   private void Update()
   {
      levelText.text = "Level: " + MoneyData.Levl;
      if (Application.platform == RuntimePlatform.Android)
      {
         if (Input.GetKey(KeyCode.Escape))
         {
            restartButton.onClick.SetPersistentListenerState(0,UnityEventCallState.Off);
            restartButton.onClick.SetPersistentListenerState(1,UnityEventCallState.RuntimeOnly);
            Time.timeScale = 0;
            EnableTextAndButton(true);
            failText.enabled = false;
            restartText.text = "Continue";
         }
      }
   }

   public void LoseGame()
   {
      failText.text = "Fail";
      restartText.text = "Restart";
      restartButton.onClick.SetPersistentListenerState(0,UnityEventCallState.RuntimeOnly);
      restartButton.onClick.SetPersistentListenerState(1,UnityEventCallState.Off);
      Time.timeScale = 0;
      EnableTextAndButton(true);
      MoneyData.Coin = StartCoin;
      MoneyData.Levl = 1;
   }
   public void MenuLoad()
   {
      MoneyData.Coin = StartCoin;
      SceneManager.LoadScene("Menu");
      Time.timeScale = 1;
   }
   public void Restart()
   {
      Time.timeScale = 1;
      SceneManager.LoadScene("Mains");
   }

   public void Finish()
   {
      Time.timeScale = 0;
      failText.text = "Victory";
      restartText.text = "Next level";
      MoneyData.Levl++;
      restartButton.onClick.SetPersistentListenerState(0,UnityEventCallState.RuntimeOnly);
      restartButton.onClick.SetPersistentListenerState(1,UnityEventCallState.Off);
      EnableTextAndButton(true);
      failText.enabled = false;
   }

   public void Continue()
   {
      Time.timeScale = 1;
      EnableTextAndButton(false);
   }
   public void EnableTextAndButton(bool flag)
   {
      failText.enabled = flag;
      restartText.enabled = flag;
      restartButton.enabled = flag;
      restartButton.image.enabled = flag;
      menuText.enabled = flag;
      menuButton.enabled = flag;
      menuButton.image.enabled = flag;
   }
}
