using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectManager : MonoBehaviour
{

    public GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("BABA");

    }

    // Update is called once per frame
    void Update()
    {

    }
}