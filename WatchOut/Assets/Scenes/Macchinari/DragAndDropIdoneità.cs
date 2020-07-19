using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropIdoneità : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private float x=0;
    private float y=0;
    
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
        transform.position=new Vector3(x,y,0);
    }
    
    
    
    
}
