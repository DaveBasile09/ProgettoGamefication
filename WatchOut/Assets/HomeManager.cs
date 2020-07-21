using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeManager : MonoBehaviour
{
    public static bool controllo1 = false;
    public static bool controllo2 = false;
    public static bool controllo3 = false;
    public static bool controllo4 = false;
    public static bool controllo5 = false;
    public static bool controllo6 = false;
    public GameObject fatto1;
    public GameObject nfatto1;
    public GameObject fatto2;
    public GameObject nfatto2;
    public GameObject fatto3;
    public GameObject nfatto3;
    public GameObject fatto4;
    public GameObject nfatto4;
    public GameObject fatto5;
    public GameObject nfatto5;
    public GameObject fatto6;
    public GameObject nfatto6;

    // Start is called before the first frame update
    void Start()
    {

        if (controllo6)
        {
            fatto6.SetActive(true);
            nfatto6.SetActive(false);

        }
        if (controllo1)
        {
            fatto1.SetActive(true);
            nfatto1.SetActive(false);

        }
        if (controllo2)
        {
            fatto2.SetActive(true);
            nfatto2.SetActive(false);

        }
        if (controllo3)
        {
            fatto3.SetActive(true);
            nfatto3.SetActive(false);

        }
        if (controllo4)
        {
            fatto4.SetActive(true);
            nfatto4.SetActive(false);

        }
        if (controllo5)
        {
            fatto5.SetActive(true);
            nfatto5.SetActive(false);

        }


    }
    public void chiediOperatore()
    {
        SceneManager.LoadScene("Chiedi_operatore", LoadSceneMode.Single);
    }
    
}
