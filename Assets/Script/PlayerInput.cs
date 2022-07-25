using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            gameObject.transform.Translate(Vector2.up);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            gameObject.transform.Translate(Vector2.down);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            gameObject.transform.Translate(Vector2.right);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            gameObject.transform.Translate(Vector2.left);
    }
}

