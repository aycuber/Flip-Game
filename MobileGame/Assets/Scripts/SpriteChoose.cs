using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChoose : MonoBehaviour
{
    public RectTransform selected;
    public Text coin;
    public GameObject wantToBuyObj;
    public GameObject spritesObj;
    public GameObject colorsObj;
    int cost;
    string sprite;
    int number;
    public CanvasGroup ufo;
    public CanvasGroup ufoCost;
    public CanvasGroup bananana;
    public CanvasGroup banananaCost;
    public CanvasGroup pirateship;
    public CanvasGroup pirateshipCost;
    public CanvasGroup dolphin;
    public CanvasGroup dolphinCost;
    public CanvasGroup car;
    public CanvasGroup carCost;
    public CanvasGroup key;
    public CanvasGroup keyCost;
    public CanvasGroup mushroom;
    public CanvasGroup mushroomCost;
    public CanvasGroup lolipop;
    public CanvasGroup lolipopCost;
    public CanvasGroup watermelon;
    public CanvasGroup watermelonCost;
    public CanvasGroup crab;
    public CanvasGroup crabCost;
    public CanvasGroup ladyBug;
    public CanvasGroup ladyBugCost;
    public CanvasGroup controller;
    public CanvasGroup controllerCost;
    public CanvasGroup flower;
    public CanvasGroup flowerCost;
    public CanvasGroup rainbow;
    public CanvasGroup rainbowCost;
    public CanvasGroup glasses;
    public CanvasGroup glassesCost;
    public CanvasGroup smiley;
    public CanvasGroup smileyCost;
    //private Character character;
    void Start()
    {
      wantToBuyObj.SetActive(false);
      spritesObj.SetActive(false);
      colorsObj.SetActive(false);
      if (PlayerPrefs.GetInt("Sprite", 0) == 0)
      {
        selected.anchoredPosition = new Vector2(-750, 0);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 1)
      {
        selected.anchoredPosition = new Vector2(-250, 0);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 2)
      {
        selected.anchoredPosition = new Vector2(-500, 0);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 3)
      {
        selected.anchoredPosition = new Vector2(0, 0);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 4)
      {
        selected.anchoredPosition = new Vector2(250, 0);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 5)
      {
        selected.anchoredPosition = new Vector2(500, 0);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 6)
      {
        selected.anchoredPosition = new Vector2(750, 0);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 7)
      {
        selected.anchoredPosition = new Vector2(-500, -150);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 8)
      {
        selected.anchoredPosition = new Vector2(-250, -150);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 9)
      {
        selected.anchoredPosition = new Vector2(0, -150);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 10)
      {
        selected.anchoredPosition = new Vector2(250, -150);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 11)
      {
        selected.anchoredPosition = new Vector2(500, -150);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 12)
      {
        selected.anchoredPosition = new Vector2(-500, -300);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 13)
      {
        selected.anchoredPosition = new Vector2(-250, -300);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 14)
      {
        selected.anchoredPosition = new Vector2(0, -300);
      }
      if (PlayerPrefs.GetInt("Sprite", 0) == 15)
      {
        selected.anchoredPosition = new Vector2(250, -300);
      }



      if (PlayerPrefs.GetInt("UfoYes", 1) == 2)
      {
          ufo.alpha = 1;
          ufoCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("BanananaYes", 1) == 2)
      {
          bananana.alpha = 1;
          banananaCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("PirateshipYes", 1) == 2)
      {
          pirateship.alpha = 1;
          pirateshipCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("DolphinYes", 1) == 2)
      {
          dolphin.alpha = 1;
          dolphinCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("CarYes", 1) == 2)
      {
          car.alpha = 1;
          carCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("KeyYes", 1) == 2)
      {
          key.alpha = 1;
          keyCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("MushroomYes", 1) == 2)
      {
          mushroom.alpha = 1;
          mushroomCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("LolipopYes", 1) == 2)
      {
          lolipop.alpha = 1;
          lolipopCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("WatermelonYes", 1) == 2)
      {
          watermelon.alpha = 1;
          watermelonCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("CrabYes", 1) == 2)
      {
          crab.alpha = 1;
          crabCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("LadyBugYes", 1) == 2)
      {
          ladyBug.alpha = 1;
          ladyBugCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("ControllerYes", 1) == 2)
      {
          controller.alpha = 1;
          controllerCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("FlowerYes", 1) == 2)
      {
          flower.alpha = 1;
          flowerCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("RainbowYes", 1) == 2)
      {
          rainbow.alpha = 1;
          rainbowCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("GlassesYes", 1) == 2)
      {
          glasses.alpha = 1;
          glassesCost.alpha = 0;
      }
      if (PlayerPrefs.GetInt("SmileyYes", 1) == 2)
      {
          smiley.alpha = 1;
          smileyCost.alpha = 0;
      }

    }





      //character = FindObjectOfType<Character>();

    public void Turtle()
    {
        selected.anchoredPosition = new Vector2(-750, 0);
        PlayerPrefs.SetInt("Sprite", 0);
    }

    public void Bananana()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("BanananaYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(-250, 0);
          PlayerPrefs.SetInt("Sprite", 1);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 9)
        {
          cost = 10;
          sprite = "BanananaYes";
          number = 1;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Ufo()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("UfoYes", 1) == 2)
        {
            selected.anchoredPosition = new Vector2(-500, 0);
            PlayerPrefs.SetInt("Sprite", 2);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 4)
        {
          cost = 5;
          sprite = "UfoYes";
          number = 2;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Pirateship()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("PirateshipYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(0, 0);
          PlayerPrefs.SetInt("Sprite", 3);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 14)
        {
          cost = 15;
          sprite = "PirateshipYes";
          number = 3;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Dolphin()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("DolphinYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(250, 0);
          PlayerPrefs.SetInt("Sprite", 4);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 24)
        {
          cost = 25;
          sprite = "DolphinYes";
          number = 4;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Car()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("CarYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(500, 0);
          PlayerPrefs.SetInt("Sprite", 5);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 49)
        {
          cost = 50;
          sprite = "CarYes";
          number = 5;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Key()
    {
        selected.anchoredPosition = new Vector2(750, 0);
        PlayerPrefs.SetInt("Sprite", 6);
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("KeyYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(750, 0);
          PlayerPrefs.SetInt("Sprite", 6);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 79)
        {
          cost = 80;
          sprite = "KeyYes";
          number = 6;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Mushroom()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("MushroomYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(-500, -150);
          PlayerPrefs.SetInt("Sprite", 7);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 99)
        {
          cost = 100;
          sprite = "MushroomYes";
          number = 7;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Lolipop()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("LolipopYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(-250, -150);
          PlayerPrefs.SetInt("Sprite", 8);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 149)
        {
          cost = 150;
          sprite = "LolipopYes";
          number = 8;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Watermelon()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("WatermelonYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(0, -150);
          PlayerPrefs.SetInt("Sprite", 9);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 199)
        {
          cost = 200;
          sprite = "WatermelonYes";
          number = 9;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Crab()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("CrabYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(250, -150);
          PlayerPrefs.SetInt("Sprite", 10);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 274)
        {
          cost = 275;
          sprite = "CrabYes";
          number = 10;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void LadyBug()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("LadyBugYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(500, -150);
          PlayerPrefs.SetInt("Sprite", 11);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 349)
        {
          cost = 350;
          sprite = "LadyBugYes";
          number = 11;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Controller()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("ControllerYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(-500, -300);
          PlayerPrefs.SetInt("Sprite", 12);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 449)
        {
          cost = 450;
          sprite = "ControllerYes";
          number = 12;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Flower()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("FlowerYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(-250, -300);
          PlayerPrefs.SetInt("Sprite", 13);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 549)
        {
          cost = 550;
          sprite = "FlowerYes";
          number = 13;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
        else
        {
          Debug.Log("Insert animation here saying you are too poor");
        }
    }
    public void Rainbow()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("RainbowYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(0, -300);
          PlayerPrefs.SetInt("Sprite", 14);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 699)
        {
          cost = 700;
          sprite = "RainbowYes";
          number = 14;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
    }
    public void Glasses()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("GlassesYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(250, -300);
          PlayerPrefs.SetInt("Sprite", 15);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 849)
        {
          cost = 850;
          sprite = "GlassesYes";
          number = 15;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
    }
    public void Smiley()
    {
        //1 = false and 2 = true
        if (PlayerPrefs.GetInt("SmileyYes", 1) == 2)
        {
          selected.anchoredPosition = new Vector2(500, -300);
          PlayerPrefs.SetInt("Sprite", 16);
        }
        else if (PlayerPrefs.GetInt("Coin", 0) > 998)
        {
          cost = 999;
          sprite = "SmileyYes";
          number = 16;
          wantToBuyObj.SetActive(true);
          spritesObj.SetActive(false);
          colorsObj.SetActive(false);
        }
    }








    public void WantToBuyYes()
    {
      PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin", 0) - cost);
      PlayerPrefs.SetInt("Sprite", number);
      PlayerPrefs.SetInt(sprite, 2);
      coin.text = "  " + PlayerPrefs.GetInt("Coin", 0).ToString();
      if (number == 1)
      {
        bananana.alpha = 1;
        banananaCost.alpha = 0;
        Bananana();
      }
      if (number == 2)
      {
        ufo.alpha = 1;
        ufoCost.alpha = 0;
        Ufo();
      }
      if (number == 3)
      {
        pirateship.alpha = 1;
        pirateshipCost.alpha = 0;
        Pirateship();
      }
      if (number == 4)
      {
        dolphin.alpha = 1;
        dolphinCost.alpha = 0;
        Dolphin();
      }
      if (number == 5)
      {
        car.alpha = 1;
        carCost.alpha = 0;
        Car();
      }
      if (number == 6)
      {
        key.alpha = 1;
        keyCost.alpha = 0;
        Key();
      }
      if (number == 7)
      {
        mushroom.alpha = 1;
        mushroomCost.alpha = 0;
        Mushroom();
      }
      if (number == 8)
      {
        lolipop.alpha = 1;
        lolipopCost.alpha = 0;
        Lolipop();
      }
      if (number == 9)
      {
        watermelon.alpha = 1;
        watermelonCost.alpha = 0;
        Watermelon();
      }
      if (number == 10)
      {
        crab.alpha = 1;
        crabCost.alpha = 0;
        Crab();
      }
      if (number == 11)
      {
        ladyBug.alpha = 1;
        ladyBugCost.alpha = 0;
        LadyBug();
      }
      if (number == 12)
      {
        controller.alpha = 1;
        controllerCost.alpha = 0;
        Controller();
      }
      if (number == 13)
      {
        flower.alpha = 1;
        flowerCost.alpha = 0;
        Flower();
      }
      if (number == 14)
      {
        rainbow.alpha = 1;
        rainbowCost.alpha = 0;
        Rainbow();
      }
      if (number == 15)
      {
        glasses.alpha = 1;
        glassesCost.alpha = 0;
        Glasses();
      }
      if (number == 16)
      {
        smiley.alpha = 1;
        smileyCost.alpha = 0;
        Smiley();
      }
    }
    public void Reset()
    {
      PlayerPrefs.SetInt("UfoYes", 1);
      PlayerPrefs.SetInt("BanananaYes", 1);
      PlayerPrefs.SetInt("PirateshipYes", 1);
      PlayerPrefs.SetInt("DolphinYes", 1);
      PlayerPrefs.SetInt("CarYes", 1);
      PlayerPrefs.SetInt("KeyYes", 1);
      PlayerPrefs.SetInt("MushroomYes", 1);
      PlayerPrefs.SetInt("LolipopYes", 1);
      PlayerPrefs.SetInt("WatermelonYes", 1);
      PlayerPrefs.SetInt("CrabYes", 1);
      PlayerPrefs.SetInt("LadyBugYes", 1);
      PlayerPrefs.SetInt("ControllerYes", 1);
      PlayerPrefs.SetInt("FlowerYes", 1);
      PlayerPrefs.SetInt("RainbowYes", 1);
      PlayerPrefs.SetInt("GlassesYes", 1);
      PlayerPrefs.SetInt("SmileyYes", 1);
    }
}
