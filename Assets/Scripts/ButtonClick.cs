using System.Collections;
using System.Collections.Generic;

using System;
using UnityEngine;

using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public void clickButtonDown()
    {
        if(String.Equals(GameObject.Find("boton0").GetComponentInChildren<Text>().text,"0"))
        {
            Debug.Log("CORRECTO!!!!!!!!");
        }
    }
}
