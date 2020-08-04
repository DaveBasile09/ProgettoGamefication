using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndgameManager : MonoBehaviour
{
    public static int[] soldi=new int[6];
    public static int[] reputazione = new int[6];
    public static bool gameOver = false;
    private string valutazioneTot;
    public GameObject gO;
    public static string v = "";
    // Start is called before the first frame update
    void Start()
    {
        if (gameOver) { showTarm(); }
        Text w = (Text)GameObject.Find("tua").GetComponent("Text");
        w.text = v;
        Text t0 =(Text) GameObject.Find("Soldi1").GetComponent("Text");
        t0.text = System.Convert.ToString(soldi[0])+"/-65";
        if (soldi[0] != -65||reputazione[0]!=190) ((Text)GameObject.Find("controllodatimaster").GetComponent("Text")).color = new Color(1, 0, 0, 1);
        Text t1 =(Text) GameObject.Find("Soldi2").GetComponent("Text");
        t1.text = System.Convert.ToString(soldi[1])+"/20";
        if (soldi[1] != 20 || reputazione[1] != 140) ((Text)GameObject.Find("testidiidoneità").GetComponent("Text")).color = new Color(1, 0, 0, 1);
        Text t2 =(Text) GameObject.Find("Soldi3").GetComponent("Text");
        t2.text = System.Convert.ToString(soldi[2]) + "/120";
        if (soldi[2] != 120 || reputazione[2] != 220) ((Text)GameObject.Find("testidiautenticità").GetComponent("Text")).color = new Color(1, 0, 0, 1);
        Text t3 =(Text) GameObject.Find("Soldi4").GetComponent("Text");
        t3.text = System.Convert.ToString(soldi[3])+"/-20";
        if(soldi[3]!=-20 || reputazione[3] !=55) ((Text)GameObject.Find("analisisimec").GetComponent("Text")).color = new Color(1, 0, 0, 1);
        Text t4 = (Text)GameObject.Find("Soldi5").GetComponent("Text");
        t4.text = System.Convert.ToString(soldi[4])+"/-20";
        if (soldi[4] != -20 || reputazione[4] != 80) ((Text)GameObject.Find("analisinormativainterna").GetComponent("Text")).color = new Color(1, 0, 0, 1);
        Text t5 = (Text)GameObject.Find("Soldi6").GetComponent("Text");
        t5.text = System.Convert.ToString(soldi[5])+"/-15";
        if (soldi[5] != -15 || reputazione[5] != 50) ((Text)GameObject.Find("analsicontratti").GetComponent("Text")).color = new Color(1, 0, 0, 1);
        Text s0 =(Text) GameObject.Find("Reputazione1").GetComponent("Text");
        s0.text = System.Convert.ToString(reputazione[0])+"/190";
        Text s1 =(Text) GameObject.Find("Reputazione2").GetComponent("Text");
        s1.text = System.Convert.ToString(reputazione[1]) + "/140"; ;
        Text s2 =(Text) GameObject.Find("Reputazione3").GetComponent("Text");
        s2.text = System.Convert.ToString(reputazione[2]) + "/220"; ;
        Text s3 = (Text)GameObject.Find("Reputazione4").GetComponent("Text");
        s3.text = System.Convert.ToString(reputazione[3])+"/55";
        Text s4 = (Text)GameObject.Find("Reputazione5").GetComponent("Text");
        s4.text = System.Convert.ToString(reputazione[4])+"/80";
        Text s5 = (Text)GameObject.Find("Reputazione6").GetComponent("Text");
        s5.text = System.Convert.ToString(reputazione[5])+"/50";


        int totale = HomeManager.soldi + HomeManager.reputazione;
        if (v.Equals("1")) {totale += 0;}
        if (v.Equals("2")) {totale += 50;}
        if (v.Equals("3")) {totale += 300;}
        if (v.Equals("4")) {totale += 50;}
        Text valutazione=(Text)GameObject.Find("valutazione").GetComponent("Text");
        valutazione.text= System.Convert.ToString(totale);

        if(!gameOver)MainMenu.v1 = valutazione.text;


    }

    public void tornaMappa()
    {
        if (!gameOver)MainMenu.b1 = true;
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }
    public static void reset()
    {


    soldi = new int[6];
    reputazione = new int[6];
     gameOver = false;
     
     v = "";
}
    public void showTarm()
    {
        StartCoroutine(ShowAndHide(gO, 2.5f));
    }


    IEnumerator ShowAndHide(GameObject go, float delay)
    {
        go.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.SetActive(false);
    }
}
