using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float xInput;
    public float yInput;
    public bool zInput;
    public InputController _controller;

    private bool canMove = true;

    void Update()
    {
        if(canMove)
        {
            canMove = false;
            xInput = Input.GetAxis("Horizontal");
            yInput = Input.GetAxis("Vertical");

            zInput = Input.GetKeyDown(KeyCode.Z);

            StartCoroutine(MoveCoroutine());
        }
    }

    IEnumerator MoveCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        canMove = true;
    }
}
