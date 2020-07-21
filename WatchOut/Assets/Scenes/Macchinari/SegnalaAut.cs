using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SegnalaAut : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {

        GameObject.Find("500").SetActive(DragAndDrop.v1);
        GameObject.Find("100").SetActive(DragAndDrop.v2);
        GameObject.Find("500F").SetActive(DragAndDrop.v3);
        GameObject.Find("100F").SetActive(DragAndDrop.v4);
        
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
        Text t=GameObject.Find(X).GetComponent<Text>();
        if (t.text=="X")
            t.text="";
        else  
            t.text = "X"; 
    }

   
}
