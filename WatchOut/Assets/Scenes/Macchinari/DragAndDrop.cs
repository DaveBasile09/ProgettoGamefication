using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DragAndDrop : MonoBehaviour, IDragHandler, IEndDragHandler
{
    
    private float x=0;
    private float y=0;
    public GameObject Mezza;
    public GameObject Testo;
    public GameObject Fessura;
    private static GameObject ultimo;
    public static bool v1=true;
    public static bool v2=true;
    public static bool v3=true;
    public static bool v4=true;
   
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.gameObject == Fessura)
        {
            if(ultimo!=null)
                ultimo.SetActive(false);
            GameObject obj=Instantiate(Testo,transform.parent);
            Destroy(obj,5);
            gameObject.SetActive(false);
            Disa(gameObject);
            Mezza.SetActive(true);
            ultimo = Mezza;
            
            
        }
    }

    void Disa(GameObject b)
    {
        switch (b.transform.name)
        {
            case "500": v1 = false;
                        break;
            case "100": v2 = false;
                        break;
            case "500F": v3 = false;
                        break;
            case "100F": v4 = false;
                        break;
            
        }
        
        
    }
   
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        Mezza.SetActive(false);
    }

   
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position=new Vector3(x,y,0);
    }

   
    
}

