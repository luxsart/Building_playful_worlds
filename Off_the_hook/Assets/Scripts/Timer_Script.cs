using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer_Script : MonoBehaviour {

	public int timeLeft = 59;
    public Text countdownText;
    public bool sceneSwitch = false;
 
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
            sceneSwitch = true;
        }

        if (sceneSwitch == true)
        {
            if (Score_ui_script.scoreValue <= Score_ui_script_p2.scoreValue)
            {
                SceneManager.LoadScene(3);
            }
            else
            {
                SceneManager.LoadScene(2);
            }        
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
