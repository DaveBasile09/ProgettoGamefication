using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IDragHandler,IEndDragHandler
{
    
    private float x=0;
    private float y=0;
    public GameObject Mezza100F;
    public GameObject Mezza500F;
    public GameObject Mezza100;
    public GameObject Mezza500;
    
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("preso");
    }

    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        
    }

   
    public void OnDrag(PointerEventData eventData)
    {
        
        transform.position = Input.mousePosition;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        
        Vector3 temp = new Vector3(x,y,0);
        transform.position=temp;
    }
    
}
