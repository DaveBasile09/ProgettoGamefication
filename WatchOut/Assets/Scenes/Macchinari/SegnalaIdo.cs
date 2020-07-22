using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class SegnalaIdo : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        GameObject.Find("500").SetActive(DragAndDrop.v1);
        GameObject.Find("100").SetActive(DragAndDrop.v2);
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
    
    //EventSystem.current.currentSelectedGameObject.name
    public void toggleX(string X)
    {
        HashSet<int> scelte = new HashSet<int>();
        Text t = GameObject.Find(X).GetComponent<Text>();
        Debug.Log(cambiascenaIdoneita.ultimo);
        String x=(EventSystem.current.currentSelectedGameObject.name);
        Debug.Log(x);
        int y= (int)(x[x.Length - 1]-'0');
        Debug.Log(y);
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
        Debug.Log(scelte.ToString());
        Debug.Log(scelte.Count);
       
    }

   

       
    
}
