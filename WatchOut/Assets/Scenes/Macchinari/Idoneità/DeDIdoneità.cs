using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;


public class DeDIdoneità : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private float x = 0;
    private float y = 0;
    public GameObject mezza1;
    public GameObject mezza2;
    public GameObject Fessura;
    public GameObject percLogore;
    public GameObject percBuone;
    private static GameObject ultimo1;
    private static GameObject ultimo2;
    private static GameObject ultimoLogore;
    private static GameObject ultimoBuone;
    public static bool v1=true;
    public static bool v2=true;
    
    
    public static void reset()
    {
        v1 = true;
        v2 = true;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.gameObject == Fessura)
        {
            if (ultimo1 != null)
            {
                ultimo1.SetActive(false);
                ultimo2.SetActive(false);
            }

            if (ultimoBuone!=null)
            {
                ultimoBuone.SetActive(false);
                ultimoLogore.SetActive(false);
            }
            Disa(gameObject);
            mezza1.SetActive(true);
            mezza2.SetActive(true);
            percBuone.SetActive(true);
            percLogore.SetActive(true);
            ultimo1 = mezza1;
            ultimo2 = mezza2;
            gameObject.SetActive(false);
            percLogore.SetActive(true);
            percBuone.SetActive(true);
            ultimoBuone = percBuone;
            ultimoLogore = percLogore;

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
           }
        
        
    }

    void Start()
    {
        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
        x = transform.position.x;
        y = transform.position.y;
        mezza1.SetActive(false);
        mezza2.SetActive(false);
        percBuone.SetActive(false);
        percLogore.SetActive(false);
        
        GameObject.Find("500").SetActive(DeDIdoneità.v1);
        GameObject.Find("100").SetActive(DeDIdoneità.v2);
       
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