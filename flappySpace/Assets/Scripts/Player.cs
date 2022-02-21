using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Settings")]
    public float velocity;
    public float speed = 2;
    private Rigidbody2D rb;

    //public GameObject effect;
    public GameManager GameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Jump mechanic
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * velocity;
            //rb.velocity += Vector2.right * speed * Time.deltaTime;
            //Instantiate(effect, transform.position, Quaternion.identity);
        }

        //if (Score.score >= 200)
        //{
        //    rb.velocity += Vector2.right * (speed * 2) * Time.deltaTime;
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.GameOver();
    }

    // show game over screen if player is outside of screen resolution
     void OnBecameInvisible()
    {
        GameManager.GameOver();
    }
}
