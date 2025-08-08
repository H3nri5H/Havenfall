using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;         // Bewegungsgeschwindigkeit
    private Vector2 _move;           // Eingabe (x,y)
    private Rigidbody2D _rb;         // Referenz auf Rigidbody2D

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Wird vom Player Input Event aufgerufen
    public void OnMove(InputValue value)
    {
        _move = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        _rb.linearVelocity = _move * speed;
    }
}