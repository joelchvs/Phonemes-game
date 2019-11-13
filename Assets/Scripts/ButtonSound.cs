using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public void PlaySound()
    {
        GameManager.instance.ClickSound();
    }
}
