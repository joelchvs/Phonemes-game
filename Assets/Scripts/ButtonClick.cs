using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonClick : MonoBehaviour
{
    public static ButtonClick instance;
    [SerializeField]
    
     public void Start()
    {
        instance=this;
        
        
    }

    public void clickButtonDown()
    {
        String buttonName = EventSystem.current.currentSelectedGameObject.name;
        String correctAnswer= GameManager.instance.correctAnswer;
        Debug.Log("buttonName is: "+buttonName);
        Debug.Log("correctAnswer is: "+GameManager.instance.correctAnswer);
        if(String.Equals(buttonName,correctAnswer))
        {
            Debug.Log("CORRECTO!!!!!!!!");
            GameManager.instance.score+=5;
            if(GameManager.instance.currentPhoneme!=3)
            {
                GameManager.instance.SetCurrentPhoneme();
                GameManager.instance.SetOptions();
            }
            else
            {
                
                ManejodeEscenas.instance.PlayGame();
            }
        }
        else
        {
            if( GameManager.instance.score>(-5))
            {
                GameManager.instance.score--;
                StartCoroutine(setWrongText());
            }
        }
    }

    private IEnumerator setWrongText()
{
        
        GameObject.Find("wronganswertext").GetComponentInChildren<Text>().text="WRONG!";
        yield return new WaitForSeconds(1f);
        GameObject.Find("wronganswertext").GetComponentInChildren<Text>().text="";
    
}
      
}

