using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    private PlayerInput _player;
    private Rigidbody2D _rigidbody;

    private Vector2 vector;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D Collision)
    {
        Debug.Log("Ãæµ¹");
        if (vector.x != 0)
        {
            transform.Translate(vector.x * _player.speed, 0, 0);
        }
        else if (vector.y != 0)
        {
            transform.Translate(0, vector.y * _player.speed, 0);
        }

    }
}
