using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//"CoinScript.cs" will reference this script as a score updater
public class ScoreTextScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static int coinAmount;
    // Start is called before the first frame update
    void Start()
    {
       //Grabs references for text from object
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString();
    }
}
