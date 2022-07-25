using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float speed;
    private Vector2 vector;

    public int walkCount;
    private int currentWalkCount; // 이동시키고싶은 픽셀 수
    private bool canMove = true;

    void Start()
    {
        
    }

    IEnumerator MoveCoroutine()
    {
        vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        while (walkCount > currentWalkCount)
        {
            if (vector.x != 0)
            {
                transform.Translate(vector.x * speed, 0, 0);
            }
            else if (vector.y != 0)
            {
                transform.Translate(0, vector.y * speed, 0);
            }
            currentWalkCount++;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(0.1f);
        currentWalkCount = 0;
        canMove = true;
    }
    void Update()
    {
        if (canMove)
        {           
            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                canMove = false;
                StartCoroutine(MoveCoroutine());
            }
        }
    }


}

