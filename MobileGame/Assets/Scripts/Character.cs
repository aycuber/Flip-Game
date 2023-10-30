using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public float flapHeight;
    public GameObject pipe_up;
    public GameObject pipe_down;
    public GameObject groundUp;
    public GameObject groundDown;
    public GameObject score;
    public GameObject coin;
    public Sprite turtle;
    public Sprite bananana;
    public Sprite ufo;
    public Sprite pirateship;
    public Sprite dolphin;
    public Sprite car;
    public Sprite key;
    public Sprite mushroom;
    public Sprite lolipop;
    public Sprite watermelon;
    public Sprite crab;
    public Sprite ladyBug;
    public Sprite controller;
    public Sprite flower;
    public Sprite rainbow;
    public Sprite glasses;
    public Sprite smiley;
    float startTime;
    bool canDoThis;
    float startTime2;
    public GameObject dieEffect;
    public GameObject gasEffect;
    public GameObject fireEffect;
    public static bool characterDeath = false;
    public AudioSource sound;
    public AudioSource backgroundSound;
    // Start is called before the first frame update


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        BuildLevel();
        rb.gravityScale = 1;
        startTime = Time.time;
        canDoThis = false;
        characterDeath = false;
        if (PlayerPrefs.GetInt("Sprite", 0) == 0)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = turtle;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 1)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = bananana;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 2)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = ufo;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 3)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = pirateship;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 4)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = dolphin;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 5)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = car;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 6)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = key;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 7)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = mushroom;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 8)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = lolipop;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 9)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = watermelon;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 10)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = crab;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 11)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = ladyBug;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 12)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = controller;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 13)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = flower;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 14)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = rainbow;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 15)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = glasses;
        }
        if (PlayerPrefs.GetInt("Sprite", 0) == 16)
        {
          this.gameObject.GetComponent<SpriteRenderer>().sprite = smiley;
        }

    }



    void BuildLevel()
    {
      Instantiate(groundDown, new Vector3(0f, 10), transform.rotation);
      Instantiate(groundUp, new Vector3(0f, -12), transform.rotation);


      float aRans = Random.Range(4, 6);
      float coinYes = Random.Range(1, 4);
      float coinY = Random.Range(-1, 1);
      float coinX = Random.Range(-1.5f, 1.5f);
      Instantiate(pipe_down, new Vector3(4, aRans), transform.rotation);
      Instantiate(pipe_up, new Vector3(4, aRans - 12), transform.rotation);
      Instantiate(score, new Vector3(6, aRans - 6), transform.rotation);
      if (coinYes == 1)
      {
        Instantiate(coin, new Vector3(4 + coinX, aRans - 6 + coinY), transform.rotation);
      }

      float cRans = Random.Range(4, 8);
      float coinYesc = Random.Range(1, 4);
      float coinYc = Random.Range(-1, 1);
      float coinXc = Random.Range(-1.5f, 1.5f);
      Instantiate(pipe_down, new Vector3(10, cRans), transform.rotation);
      Instantiate(pipe_up, new Vector3(10, cRans - 12), transform.rotation);
      Instantiate(score, new Vector3(12, cRans - 6), transform.rotation);
      if (coinYesc == 1)
      {
        Instantiate(coin, new Vector3(10 + coinXc, cRans - 6 + coinYc), transform.rotation);
      }

      float eRans = Random.Range(4, 8);
      float coinYese = Random.Range(1, 4);
      float coinYe = Random.Range(-1, 1);
      float coinXe = Random.Range(-1.5f, 1.5f);
      Instantiate(pipe_down, new Vector3(16, eRans), transform.rotation);
      Instantiate(pipe_up, new Vector3(16, eRans - 12), transform.rotation);
      Instantiate(score, new Vector3(18, eRans - 6), transform.rotation);
      if (coinYese == 1)
      {
        Instantiate(coin, new Vector3(16 + coinXe, eRans - 6 + coinYe), transform.rotation);
      }

      float gRans = Random.Range(4, 8);
      float coinYesg = Random.Range(1, 4);
      float coinYg = Random.Range(-1, 1);
      float coinXg = Random.Range(-1.5f, 1.5f);
      Instantiate(pipe_down, new Vector3(22, gRans), transform.rotation);
      Instantiate(pipe_up, new Vector3(22, gRans - 12), transform.rotation);
      Instantiate(score, new Vector3(24, gRans - 6), transform.rotation);
      if (coinYesg == 1)
      {
        Instantiate(coin, new Vector3(22 + coinXg, gRans - 6 + coinYg), transform.rotation);
      }

      float iRans = Random.Range(4, 8);
      float coinYesi = Random.Range(1, 4);
      float coinYi = Random.Range(-1, 1);
      float coinXi = Random.Range(-1.5f, 1.5f);
      Instantiate(pipe_down, new Vector3(28, iRans), transform.rotation);
      Instantiate(pipe_up, new Vector3(28, iRans - 12), transform.rotation);
      Instantiate(score, new Vector3(30, aRans - 6), transform.rotation);
      if (coinYesi == 1)
      {
        Instantiate(coin, new Vector3(28 + coinXi, iRans - 6 + coinYi), transform.rotation);
      }




    }

    // Update is called once per frame
    void Update()
    {
        //r.sharedMaterial.color = Random.ColorHSV();

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
          rb.gravityScale = (-rb.gravityScale);
          Flip();
        }
        Vector2 moveDirection = rb.velocity;
        if (moveDirection != Vector2.zero) {
             float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
             transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        if (!canDoThis && Time.time - startTime > 5)
        {
          canDoThis = true;
        }
        if (canDoThis)
        {
          rb.gravityScale = rb.gravityScale * 1.05f;
          moveSpeed = moveSpeed * 1.05f;
          startTime = Time.time;
          canDoThis = false;
        }
        if (transform.position.y > 5 || transform.position.y < -6)
        {
          Death();

        }

    }


    public void Death()
    {
      if (!characterDeath)
      {
        rb.velocity = Vector3.zero;
        Instantiate(dieEffect, transform.position, transform.rotation);
        sound.Play();
        backgroundSound.Stop();
        transform.localScale = new Vector2(0, 0);
        gasEffect.transform.localScale = new Vector2(0, 0);
        fireEffect.transform.localScale = new Vector2(0, 0);
        characterDeath = true;
        StartCoroutine(DeathWait());
      }

    }
    IEnumerator DeathWait()
    {
      yield return new WaitForSeconds(0.5f);
      SceneManager.LoadScene("RetryScene");
    }
    void Flip()
    {
      Vector3 theScale = transform.localScale;
      theScale.y *= -1;
      transform.localScale = theScale;
    }

}
