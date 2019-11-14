using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButton : MonoBehaviour
{
    public void RestartGame()
    {
        ManejodeEscenas.instance.RestartGame();
    }
}
