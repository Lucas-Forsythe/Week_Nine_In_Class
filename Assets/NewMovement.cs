using UnityEngine;
using UnityEngine.InputSystem;

public class NewMovement : MonoBehaviour
{
    Vector2 movePlayer;
    Rigidbody2D rb;
    public float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myMove();
    }

    void OnMove(InputValue value)
    {
        movePlayer = value.Get<Vector2>();
        Debug.Log(movePlayer);
    }

    void myMove()
    {
        rb.linearVelocity = new Vector2(movePlayer.x * moveSpeed, rb.linearVelocity.y);
    }
}

