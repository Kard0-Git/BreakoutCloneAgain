using UnityEngine;

public class Ball_Handler : MonoBehaviour
{

    Rigidbody2D rb;

    public float speed = 8;

    Vector2 dir = new Vector2(0,-1);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
         MoveBall();
    }

    // Update is called once per frame
    


    void MoveBall()
    {
        rb.linearVelocity = dir * speed;
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if(collision.gameObject.tag == "Player")
    //     {
    //         dir.x = 0;
    //     }
    // }


}
