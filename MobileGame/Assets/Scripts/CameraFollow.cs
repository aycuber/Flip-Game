using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Rigidbody2D rb;
    float startTime;
    bool canDoThis;


    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1;
        rb.constraints = RigidbodyConstraints2D.None;
        startTime = Time.time;
        canDoThis = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
          rb.gravityScale = (-rb.gravityScale);
        }
        if (!canDoThis && Time.time - startTime > 5)
        {
          canDoThis = true;
        }
        if (canDoThis)
        {
          Debug.Log("Can Do This");
          rb.gravityScale = rb.gravityScale * 1.05f;
          moveSpeed = moveSpeed * 1.05f;
          startTime = Time.time;
          canDoThis = false;
        }
        if (Character.characterDeath)
        {
          rb.constraints = RigidbodyConstraints2D.FreezePositionY;
          rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        }

        //transform.position = new Vector3 (rb.velocity.x, character.position.y + offset.y, offset.z);

    }
}
