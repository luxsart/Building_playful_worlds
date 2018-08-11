using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer_Script : MonoBehaviour {

	public int timeLeft = 59;
    public Text countdownText;
 
    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }
 
    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("00:" + timeLeft);
 
        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
        }
    }
 
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
