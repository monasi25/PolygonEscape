﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class director : MonoBehaviour
{

    public GameObject Starcount;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Starcount.GetComponent<Text>().text = "Stars " + score.ToString() + " / 75";
    }

    public void starget()
    {
        score++;
    }
}
