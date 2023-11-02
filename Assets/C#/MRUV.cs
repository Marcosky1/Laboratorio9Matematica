using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MRUV : MonoBehaviour
{
    public float initialSpeed = 2.0f;
    public float acceleration = 1.0f;
    private Rigidbody2D rb;

    private Vector2 initialPosition;
    private bool isMoving = false;
    public Button controlButton;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(initialSpeed, 0);
        initialPosition = transform.position;
        controlButton.onClick.AddListener(ToggleMovement);
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            rb.velocity += Vector2.right * acceleration * Time.deltaTime;
        }
    }

    void ToggleMovement()
    {
        if (isMoving)
        {
            rb.velocity = Vector2.zero;
            transform.position = initialPosition;
        }
        else
        {
            rb.velocity = new Vector2(initialSpeed, 0);
        }
        isMoving = !isMoving;
    }
}

