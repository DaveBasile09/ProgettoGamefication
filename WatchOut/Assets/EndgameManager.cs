using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndgameManager : MonoBehaviour
{
    public static int[] soldi=new int[6];
    public static int[] reputazione = new int[6];
    // Start is called before the first frame update
    void Start()
    {
        Text t3 =(Text) GameObject.Find("Soldi3").GetComponent("Text");
        t3.text = System.Convert.ToString(soldi[3]);
        Text t4 = (Text)GameObject.Find("Soldi4").GetComponent("Text");
        t4.text = System.Convert.ToString(soldi[4]);
        Text t5 = (Text)GameObject.Find("Soldi5").GetComponent("Text");
        t5.text = System.Convert.ToString(soldi[5]);
        Text s3 = (Text)GameObject.Find("Reputazione3").GetComponent("Text");
        s3.text = System.Convert.ToString(reputazione[3]);
        Text s4 = (Text)GameObject.Find("Reputazione4").GetComponent("Text");
        s4.text = System.Convert.ToString(reputazione[4]);
        Text s5 = (Text)GameObject.Find("Reputazione5").GetComponent("Text");
        s5.text = System.Convert.ToString(reputazione[5]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
