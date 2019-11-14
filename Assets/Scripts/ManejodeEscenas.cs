using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 using UnityEngine.UI;

public class ManejodeEscenas : MonoBehaviour
{
    public static ManejodeEscenas instance;

public void Start()
    {
        instance=this;
    }
    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartGame()
    {
         UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
    }
}
