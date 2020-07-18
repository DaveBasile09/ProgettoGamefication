using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IDragHandler, IEndDragHandler
{
    
    private float x=0;
    private float y=0;
    public GameObject Mezza;
    public GameObject Testo;
    
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.name == "FessuraBanconote")
        {
            if(!Testo.activeInHierarchy)
                Testo.SetActive(true);
                StopCoroutine(wait());
                gameObject.SetActive(false);
                Mezza.SetActive(true);
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5f);
        Testo.SetActive(false);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("inizio");
        x = transform.position.x;
        y = transform.position.y;
        Mezza.SetActive(false);
        Testo.SetActive(false);
        StartCoroutine(wait());
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
