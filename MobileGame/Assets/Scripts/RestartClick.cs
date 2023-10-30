using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartClick : MonoBehaviour
{

    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }




}
