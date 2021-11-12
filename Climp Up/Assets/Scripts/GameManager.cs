using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public GameObject RPuck, LPuck,Coin_1;
   public Text failText, restartText, menuText;
   public Button restartButton, menuButton;
   private Vector3 StartPosRight, StartPosLeft, StartCoin_1Pos;
   private int StartCoin;
   

   private void Start()
   {
      StartPosLeft = LPuck.transform.position;
      StartPosRight = RPuck.transform.position;
      StartCoin_1Pos = Coin_1.transform.position;
      StartCoin = MoneyData.Coin;
   }

   public void LoseGame()
   {
      restartText.text = "Restart";
      Time.timeScale = 0;
      EnableTextAndButton(true);
      MoneyData.Coin = StartCoin;
   }
   public void Restart()
   {
      Time.timeScale = 1;
      RPuck.transform.position = StartPosRight;
      LPuck.transform.position = StartPosLeft;
      Coin_1.GetComponent<MeshRenderer>().enabled = true;
      Coin_1.GetComponent<CapsuleCollider>().isTrigger = false;
      EnableTextAndButton(false);

   }

   public void Finish()
   {
      restartText.text = "Victory!!";
      restartButton.onClick.AddListener(Restart);
      EnableTextAndButton(true);
      failText.enabled = false;
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
