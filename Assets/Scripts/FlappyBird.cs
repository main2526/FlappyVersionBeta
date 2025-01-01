using UnityEngine;
using UnityEngine.InputSystem;

public class FlappyBird : MonoBehaviour
{
    [SerializeField]  private Rigidbody2D rb2D;
    [SerializeField]  private float speed = 2;

    void Start()
    {
    }

    void Update()
    {
        if (Touchscreen.current?.primaryTouch.press.isPressed== true  || Mouse.current.leftButton.isPressed)
        {
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindAnyObjectByType<GameManager>().GameOver();
    }
}
