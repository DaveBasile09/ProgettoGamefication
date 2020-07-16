using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IDragHandler,IEndDragHandler
{

    private float x;
    private float y;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        x = transform.position.x;
        y = transform.position.y;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        Vector3 temp = new Vector3(x,y,0);
        transform.position=temp;
    }
    
}
