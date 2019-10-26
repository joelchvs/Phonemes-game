using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public static ShowScore instance;
    public Text score;

public void Start()
    {
        instance=this;
    score.text=""+GameManager.instance.score;
    }

    // public void updateScore(int points)
    // {
    //     score.text=""+points;
    // }
}
