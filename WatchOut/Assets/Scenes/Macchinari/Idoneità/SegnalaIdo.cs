using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class SegnalaIdo : MonoBehaviour
{
    public static HashSet<int> scelte=new HashSet<int>() ;
    void Start()
    {
        GameObject.Find("500").SetActive(DragAndDrop.v1);
        GameObject.Find("100").SetActive(DragAndDrop.v2);
        scelte.Clear();
    }

    public void toggleManager()
    {
        switch (EventSystem.current.currentSelectedGameObject.name)
        {
            case "pulsante1":   toggleX("X1");  
                break;
            case "pulsante2":   toggleX("X2");  
                break;
            case "pulsante3":   toggleX("X3");  
                break;
            case "pulsante4":   toggleX("X4");  
                break;
        }
    }
    
    
    private void toggleX(string X)
    {
        Text t = GameObject.Find(X).GetComponent<Text>();
        String x=(EventSystem.current.currentSelectedGameObject.name);
        int y= (int)(x[x.Length - 1]-'0');
        if (t.text == "X")
        {
            scelte.Remove(y);
            t.text = "";
        }
        else
        {
            scelte.Add(y);
            t.text = "X";
        }

       
    }

    private void stampa()
    {
        foreach (var x  in scelte)
        {
            Debug.Log(x);
        }
    }
   

       
    
}
