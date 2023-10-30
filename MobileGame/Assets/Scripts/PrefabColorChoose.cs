using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabColorChoose : MonoBehaviour
{
    public RectTransform selected;
    void Start()
    {
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 1)
      {
        selected.anchoredPosition = new Vector2(-480, 350);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 2)
      {
        selected.anchoredPosition = new Vector2(-480, 190);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 3)
      {
        selected.anchoredPosition = new Vector2(-320, 350);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 4)
      {
        selected.anchoredPosition = new Vector2(-320, 190);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 5)
      {
        selected.anchoredPosition = new Vector2(-160, 350);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 6)
      {
        selected.anchoredPosition = new Vector2(-160, 190);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 7)
      {
        selected.anchoredPosition = new Vector2(0, 350);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 8)
      {
        selected.anchoredPosition = new Vector2(0, 190);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 9)
      {
        selected.anchoredPosition = new Vector2(160, 350);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 10)
      {
        selected.anchoredPosition = new Vector2(160, 190);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 11)
      {
        selected.anchoredPosition = new Vector2(320, 350);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 12)
      {
        selected.anchoredPosition = new Vector2(320, 190);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 13)
      {
        selected.anchoredPosition = new Vector2(480, 350);
      }
      if (PlayerPrefs.GetInt("SpriteColor", 0) == 14)
      {
        selected.anchoredPosition = new Vector2(480, 190);
      }
    }
    public void ColorOne()
    {
      PlayerPrefs.SetInt("SpriteColor", 1);
      selected.anchoredPosition = new Vector2(-480, 350);
    }
    public void ColorTwo()
    {
      PlayerPrefs.SetInt("SpriteColor", 2);
      selected.anchoredPosition = new Vector2(-480, 190);
    }
    public void ColorThree()
    {
      PlayerPrefs.SetInt("SpriteColor", 3);
      selected.anchoredPosition = new Vector2(-320, 350);
    }
    public void ColorFour()
    {
      PlayerPrefs.SetInt("SpriteColor", 4);
      selected.anchoredPosition = new Vector2(-320, 190);
    }
    public void ColorFive()
    {
      PlayerPrefs.SetInt("SpriteColor", 5);
      selected.anchoredPosition = new Vector2(-160, 350);
    }
    public void ColorSix()
    {
      PlayerPrefs.SetInt("SpriteColor", 6);
      selected.anchoredPosition = new Vector2(-160, 190);
    }
    public void ColorSeven()
    {
      PlayerPrefs.SetInt("SpriteColor", 7);
      selected.anchoredPosition = new Vector2(0, 350);
    }
    public void ColorEight()
    {
      PlayerPrefs.SetInt("SpriteColor", 8);
      selected.anchoredPosition = new Vector2(0, 190);
    }
    public void ColorNine()
    {
      PlayerPrefs.SetInt("SpriteColor", 9);
      selected.anchoredPosition = new Vector2(160, 350);
    }
    public void ColorTen()
    {
      PlayerPrefs.SetInt("SpriteColor", 10);
      selected.anchoredPosition = new Vector2(160, 190);
    }
    public void ColorEleven()
    {
      PlayerPrefs.SetInt("SpriteColor", 11);
      selected.anchoredPosition = new Vector2(320, 350);
    }
    public void ColorTwelve()
    {
      PlayerPrefs.SetInt("SpriteColor", 12);
      selected.anchoredPosition = new Vector2(320, 190);
    }
    public void ColorThirteen()
    {
      PlayerPrefs.SetInt("SpriteColor", 13);
      selected.anchoredPosition = new Vector2(480, 350);
    }
    public void ColorFourteen()
    {
      PlayerPrefs.SetInt("SpriteColor", 14);
      selected.anchoredPosition = new Vector2(480, 190);
    }

}
