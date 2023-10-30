using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreShow : MonoBehaviour
{
    public Text score;
    public Text highScore;
    public Text coin;
    public ParticleSystem particleOne;
    public ParticleSystem particleTwo;
    public ParticleSystem particleThree;
    public ParticleSystem particleFour;
    // Start is called before the first frame update
    void Start()
    {
      score.text = "" + GameManager.currentScore;
      PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin", 0) + GameManager.currentCoin);
      coin.text = "  " + PlayerPrefs.GetInt("Coin", 0).ToString();
      highScore.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
      if (GameManager.currentScore > PlayerPrefs.GetInt("HighScore", 0))
      {
        PlayerPrefs.SetInt("HighScore", GameManager.currentScore);
        highScore.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        particleOne.Play();
        particleTwo.Play();
        particleThree.Play();
        particleFour.Play();
      }
      GameManager.currentScore = 0;
      GameManager.currentCoin = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
