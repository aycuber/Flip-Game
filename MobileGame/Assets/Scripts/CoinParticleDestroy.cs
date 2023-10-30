using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinParticleDestroy : MonoBehaviour
{

    private Character character;
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
}
