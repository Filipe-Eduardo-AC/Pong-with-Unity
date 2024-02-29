using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;
    private bool hasCollided = false;
    public Rigidbody2D rb;


    private void Start()
    {
       LaunchBall();
    }

    private void LaunchBall()
    {
        float randomDirectionX = Random.Range(0, 2) == 0 ? -1 : 1;
        float randomDirectionY = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * randomDirectionX, speed * randomDirectionY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasCollided)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                float relativePosition = transform.position.y - collision.transform.position.y;
                float verticalDirection = Mathf.Sign(relativePosition);
                float horizontalDirection = Mathf.Sign(rb.velocity.x);

                Vector2 force = new Vector2(horizontalDirection, verticalDirection) * speed * 0.8f;
                rb.AddForce(force, ForceMode2D.Impulse);
            }
            else
            {
                Vector2 normal = collision.GetContact(0).normal;
                Vector2 reflectedVelocity = Vector2.Reflect(rb.velocity, normal).normalized;
                rb.velocity = reflectedVelocity * speed;
            }

            hasCollided = true;
        }
    }
}
