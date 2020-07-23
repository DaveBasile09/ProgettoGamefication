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
    /**
     * x -> coordinate di x iniziali per il drag and drop
     * y -> coordinate di y iniziali per il drag and drop
     * Mezza -> Mezza banconota relativa a quella del drag and drop   
     * Testo -> Testo "girare banconota nei 4 versi"
     * Fessura -> GameObjet per l'inserimento delle banconote
     * V -> V del macchinario, implica che è andato a buon fine
     * X -> X del macchinario, implica che è andato a male
     * ultimo -> ultima banconota provata
     * v1 -> stato banconota 500   
     * v2 -> stato banconota 100
     * v3 -> stato banconota 500F
     * v4 -> stato banconota 100F
     * testoN -> aka testo Neutro  , "inserici soldi nella macchina"
     * testoR -> aka testo Risultato  , in base al risultato delle banconote vere o false
     */
    private float x=0;
    private float y=0;
    public GameObject Mezza;
    public GameObject Testo;
    public GameObject Fessura;
    public GameObject V;
    public GameObject X;
    private static GameObject ultimo;
    public static bool v1=true;
    public static bool v2=true;
    public static bool v3=true;
    public static bool v4=true;
    public GameObject testoN;
    public GameObject testoFalse;
    public GameObject testoVere;
    
   
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.gameObject == Fessura)
        {
            if(ultimo!=null)
                ultimo.SetActive(false);
            GameObject obj=Instantiate(Testo,transform.parent);
            Destroy(obj,1);
            contorno();
            gameObject.SetActive(false);
            Disa(gameObject);
            Mezza.SetActive(true);
            ultimo = Mezza;
            
            
        }
    }

    private void contorno()
    {
        testoN.SetActive(false);
        switch (gameObject.name)
        {
            case "500": V.SetActive(true);
                        X.SetActive(false);
                        testoFalse.SetActive(false);
                        testoVere.SetActive(true);
                        break;
            case "100": V.SetActive(false);
                        X.SetActive(true);
                        testoFalse.SetActive(true);
                        testoVere.SetActive(false);
                        break;
            case "500F": V.SetActive(true);
                         X.SetActive(false); 
                         testoFalse.SetActive(false);
                         testoVere.SetActive(true);
                         break;
            case "100F": V.SetActive(false);
                         X.SetActive(true); 
                         testoFalse.SetActive(true);
                         testoVere.SetActive(false);
                         break;
                
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
        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
        Mezza.SetActive(false);
        GameObject.Find("500").SetActive(DragAndDrop.v1);
        GameObject.Find("100").SetActive(DragAndDrop.v2);
        GameObject.Find("500F").SetActive(DragAndDrop.v3);
        GameObject.Find("100F").SetActive(DragAndDrop.v4);
        V.SetActive(false);
        X.SetActive(false);
        testoN.SetActive(true);
        testoFalse.SetActive(false);
        testoVere.SetActive(false);
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

