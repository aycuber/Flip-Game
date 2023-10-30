using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int value;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
      if(trigger.gameObject.tag == "Player")
      {

        FindObjectOfType<GameManager>().AddScore(value);
        Destroy(gameObject);

      }
    }
}
