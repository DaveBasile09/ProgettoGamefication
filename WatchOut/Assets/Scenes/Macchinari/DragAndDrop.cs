using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IDragHandler, IEndDragHandler
{
    
    private float x=0;
    private float y=0;
    private string nome;
    public GameObject M500F;
    public GameObject M100F;
    public GameObject M500;
    public GameObject M100;
    public GameObject Testo;
    
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.name == "500" && other.transform.name=="FessuraBanconote")
        {
           
            Testo.SetActive(true);
            StartCoroutine(wait());
            gameObject.SetActive(false);
            M500.SetActive(true);
            M500F.SetActive(false);
            M100F.SetActive(false);
            M100.SetActive(false);
            
        }
        if (gameObject.name == "500F" && other.transform.name=="FessuraBanconote")
        {
            Testo.SetActive(true);
            StartCoroutine(wait());
            gameObject.SetActive(false);
            M500F.SetActive(true);
            M100F.SetActive(false);
            M500.SetActive(false);
            M100.SetActive(false);
        } 
        if (gameObject.name == "100" && other.transform.name=="FessuraBanconote")
        {
            Testo.SetActive(true);
            StartCoroutine(wait());
            gameObject.SetActive(false);
            M100.SetActive(true);
            M500F.SetActive(false);
            M100F.SetActive(false);
            M500.SetActive(false);
        } 
        if (gameObject.name == "100F" && other.transform.name=="FessuraBanconote")
        {
            Testo.SetActive(true);
            StartCoroutine(wait());
            gameObject.SetActive(false);
            M100F.SetActive(true);
            M500F.SetActive(false);
            M500.SetActive(false);
            M100.SetActive(false);
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
        nome = transform.name;
        M500F.SetActive(false);
        M100F.SetActive(false);
        M500.SetActive(false);
        M100.SetActive(false);
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
