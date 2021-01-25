using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timesUpText;
    public Text counterText;
    [HideInInspector]
    public int time;
    [HideInInspector]
    private static bool isOver;

    // Start is called before the first frame update
    void Start()
    {
        // timer is set for 10 seconds
        time = 12;
        counterText.text = "Time: 10";
        // start the timer
        StartCoroutine(timer());
        isOver = false;
    }

    void Update()
    {
        // check if the game has ended
        isOver = gameObject.GetComponent<QTEController>().isGameOver;
        // if the game has ended,
        if (isOver == true)
        {
            // stop the countdown
            StopAllCoroutines();
        }
    }

    void updateTime()
    {
        counterText.text = "Time: " + time;
    }

    IEnumerator timer()
    {
        // count down by one second
        yield return new WaitForSeconds(1.0f);
        time--;
        // reflect this change
        if (time < 11)
        {
            updateTime();
        }
        // when time runs out,
        if (time == 0)
        {
            // alert the player
            timesUpText.text = "Time's Up!";
            // end the game
            QTEController instance = gameObject.GetComponent<QTEController>();
            instance.gameOver();
            yield break;
        }
        // call this function to count down another second
        StartCoroutine(timer());
    }
}
