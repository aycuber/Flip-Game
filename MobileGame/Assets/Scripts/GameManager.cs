using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static int currentScore;
    public Text scoreText;
    public static int currentCoin;
    public Text coinText;
    public AudioSource sound;
    public Animator anim;
    public Animator animTwo;
    public void AddScore(int scoreToAdd)
    {
      currentScore += scoreToAdd;
      scoreText.text = "" + currentScore;
      anim.Play("TextPulse2");
    }
    public void AddCoin(int coinToAdd)
    {
      sound.Play();
      currentCoin += coinToAdd;
      coinText.text = "  " + currentCoin;
      animTwo.Play("TextPulse3");
    }
}
