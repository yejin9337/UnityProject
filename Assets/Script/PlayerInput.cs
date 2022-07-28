using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public InputController _controller;

    

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _controller.MoveUp();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _controller.MoveDown();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _controller.MoveLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _controller.MoveRight();
        }
    }
}

