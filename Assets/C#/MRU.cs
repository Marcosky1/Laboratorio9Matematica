using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MRU : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;

    private Vector2 initialPosition;
    private bool isMoving = false;
    public Button controlButton;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);

        initialPosition = transform.position;
        controlButton.onClick.AddListener(ToggleMovement);
    }

    private void ToggleMovement()
    {
        if (isMoving)
        {
            rb.velocity = Vector2.zero;
            transform.position = initialPosition;
        }
        else
        {
            rb.velocity = new Vector2(speed, 0);
        }
        isMoving = !isMoving;
    }
}

