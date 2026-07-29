using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle_Handler : MonoBehaviour

{

    public float speed = 5;

    public GameObject Right_wall;

    public GameObject Left_wall;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        paddleMovenment();
    }

    void paddleMovenment(){

        if (Keyboard.current.dKey.isPressed)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        else if (Keyboard.current.aKey.isPressed)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        else if (Keyboard.current.leftArrowKey.isPressed)
        {
             transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    void wallCollisions()
    {
        
        Vector3 new_position = transform.position;

        //new_position.x = Mathf.Clamp(new_position.x, Left_wall.transform.x)


    }
}
