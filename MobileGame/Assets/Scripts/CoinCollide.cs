using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollide : MonoBehaviour
{
    public int value;
    private Character character;
    public GameObject coinParticle;
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
        Destroy(gameObject);
      }
    }
    private void OnTriggerEnter2D(Collider2D trigger)
    {
      if(trigger.gameObject.tag == "Player")
      {
        FindObjectOfType<GameManager>().AddCoin(value);
        Instantiate(coinParticle, transform.position, transform.rotation);
        Destroy(gameObject);

      }
    }
}
