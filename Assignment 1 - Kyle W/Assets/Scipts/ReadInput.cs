using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    private string input;
    public GameObject textDisplay;

    public void ReadStringInput(string s)
    {
        input = s;
        textDisplay.GetComponent<Text>().text = s;
    }

}
