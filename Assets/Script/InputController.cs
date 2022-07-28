using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public List<GameObject> player = new();
    public PlayerInput _input;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void MoveUp()
    {
        for (int i = 0; i < player.Count; i++)
        {
            player[i].transform.Translate(Vector3.up);
        }
        StartCoroutine(MoveCoroutine());
    }

    public void MoveDown()
    {
        for (int i = 0; i < player.Count; i++)
        {
            player[i].transform.Translate(Vector3.down);
        }
        StartCoroutine(MoveCoroutine());
    }

    public void MoveLeft()
    {
        for (int i = 0; i < player.Count; i++)
        {
            player[i].transform.Translate(Vector3.left);
        }
        StartCoroutine(MoveCoroutine());
    }

    public void MoveRight()
    {
        for (int i = 0; i < player.Count; i++)
        {
            player[i].transform.Translate(Vector3.right);
        }
        StartCoroutine(MoveCoroutine());
    }

    public void AddList()
    {


    }

    public void RemoveList()
    {
        for (int i = 0; i < player.Count; i++)
        {
            player.Remove(player[i]);
        }
    }

    IEnumerator MoveCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        //canMove = true;
    }
}
