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
    public static HashSet<int> scelteId=new HashSet<int>() ;
    void Start()
    {
        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
        GameObject.Find("500").SetActive(DragAndDrop.v1);
        GameObject.Find("100").SetActive(DragAndDrop.v2);
        scelteId.Clear();
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
            scelteId.Remove(y);
            t.text = "";
        }
        else
        {
            scelteId.Add(y);
            t.text = "X";
        }

       
    }

    public static void reset()
    {
        scelteId = new HashSet<int>();
    }
   

  

       
    
}
