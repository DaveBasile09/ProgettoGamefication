using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropIdoneità : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private float x=0;
    private float y=0;
    public GameObject Fessura;
    public GameObject mezza1;
    public GameObject mezza2;
    private static GameObject ultimo1;
    private static GameObject ultimo2;

    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.gameObject == Fessura)
        {
            if(ultimo1!=null && ultimo2!=null)
                ultimo1.SetActive(false);
                ultimo2.SetActive(false);
            gameObject.SetActive(false);
            mezza1.SetActive(true);
            mezza2.SetActive(true);
            ultimo1 = mezza1;
            ultimo2 = mezza2;
        }
    }

    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        mezza1.SetActive(false);
        mezza2.SetActive(false);
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
