// ball.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject[] balls;
    public float wallSpeedReduction = 0.90f;

    private void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(this.tag))
        {
            Vector3 ball1Pos = this.transform.position;
            Vector3 ball2Pos = col.gameObject.transform.position;
            int balltag = int.Parse(col.gameObject.tag);
            if (ball1Pos.y <= ball2Pos.y && balltag < 7)
            {
                Instantiate(balls[balltag + 1], ball1Pos, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
        else
        {
            this.rb.velocity *= this.wallSpeedReduction;
        }
    }
}
