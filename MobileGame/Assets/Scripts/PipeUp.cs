using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeUp : MonoBehaviour
{

    private Character character;
    public GameObject pipeDown;
    public GameObject groundUp;
    public GameObject groundDown;
    public GameObject score;
    public GameObject coin;


    // Start is called before the first frame update
    void Start()
    {
        character = FindObjectOfType<Character>();

    }

    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.x - transform.position.x > 15)
        {
      //    float xRan = Random.Range(0, 1);
          float yRan = Random.Range(-3, 3);
          float coinGo = Random.Range(1, 4);
          float xCoinRan = Random.Range(-1.5f, 1.5f);
          float yCoinRan = Random.Range(-1, 1);
      //    float gapRan = Random.Range(0, 1);

          Instantiate(gameObject, new Vector2(character.transform.position.x + 15, -6 + yRan), transform.rotation);
          Instantiate(pipeDown, new Vector2(character.transform.position.x + 15, 6 + yRan), transform.rotation);
          Instantiate(score, new Vector2(character.transform.position.x + 17, yRan), transform.rotation);
          if (coinGo == 1)
          {
            Instantiate(coin, new Vector2(character.transform.position.x + 15 + xCoinRan, yRan + yCoinRan), transform.rotation);
          }
          Destroy(gameObject);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "Player")
      {

        character.Death();

      }
    }
}
