using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QTEController : MonoBehaviour
{
    public GameObject keyBox;
    public GameObject passFailBox;
    public Text restartText;
    public Text gameOverText;
    public Text scoreText;
    public Text introText;
    public Text introText2;
    [HideInInspector]
    public int QTEGen;
    [HideInInspector]
    public int score;
    [HideInInspector]
    public int counter;
    [HideInInspector]
    public int passFailGen;
    [HideInInspector]
    public bool waitingForKey;
    [HideInInspector]
    public bool correctKey;
    [HideInInspector]
    public bool countingDown;
    [HideInInspector]
    public bool restart;
    [HideInInspector]
    public bool isGameOver;
    [HideInInspector]
    public bool introActive;

    public GameObject Elon;
    public GameObject Cupcake;
    public GameObject Cupcake1;
    public GameObject Cupcake2;
    public GameObject Cupcake3;
    public GameObject Cupcake4;
    public GameObject Cupcake5;
    public GameObject Cupcake6;
    public GameObject Cupcake7;
    public GameObject Cupcake8;
    public GameObject Cupcake9;

    public AudioClip startingSound;
    public AudioClip monch;
    public AudioClip splat;
    public AudioClip winSound;
    public AudioClip loseSound;
    public AudioClip backgroundMusic;
    public AudioSource musicSource;
    public AudioSource soundSource;

    void Start()
    {
        // set everything to 0 or empty
        score = 0;
        counter = 0;
        isGameOver = false;
        restart = false;
        waitingForKey = true;
        restartText.text = "";
        gameOverText.text = "";
        scoreText.text = "Score: " + score;
        introText.text = "Press the matching letters to eat the cupcakes!";
        introText2.text = "Eat at least 5 to win!";
        introActive = true;
        StartCoroutine(introCountDown());
        soundSource.clip = startingSound;
        soundSource.Play();
    }

    void Update() 
    {
        // checks if the player is trying to quit the game
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        // checks if the game has ended
        if (isGameOver == true)
        {
            // prompts restart
            restartText.text = "Press 'R' to Restart";
            restart = true;
            // prevents other process from continuing
            StopAllCoroutines();
            Destroy(passFailBox, 0);
        }

        // checks if game has been restarted
        if (restart == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        // if no key is present generate one
        if (waitingForKey == true && introActive == false)
        {
            // generate one of 9 possible keys
            QTEGen = Random.Range(1, 10);
            // start the 3 second countdown for the current key
            countingDown = true;
            StartCoroutine(countDown());
            // assign key based on generation
            if (QTEGen == 1)
            {
                keyBox.GetComponent<Text>().text = "[Q]";
            }
            else if (QTEGen == 2)
            {
                keyBox.GetComponent<Text>().text = "[W]";
            }
            else if (QTEGen == 3)
            {
                keyBox.GetComponent<Text>().text = "[E]";
            }
            else if (QTEGen == 4)
            {
                keyBox.GetComponent<Text>().text = "[A]";
            }
            else if (QTEGen == 5)
            {
                keyBox.GetComponent<Text>().text = "[S]";
            }
            else if (QTEGen == 6)
            {
                keyBox.GetComponent<Text>().text = "[D]";
            }
            else if (QTEGen == 7)
            {
                keyBox.GetComponent<Text>().text = "[Z]";
            }
            else if (QTEGen == 8)
            {
                keyBox.GetComponent<Text>().text = "[X]";
            }
            else if (QTEGen == 9)
            {
                keyBox.GetComponent<Text>().text = "[C]";
            }
            // turn key assignment off now that you have a key
            waitingForKey = false;
        }

        // based on what key was assigned,
        if (QTEGen == 1)
        {
            //test to see if the player pressed a key
            if (Input.anyKeyDown)
            {
                // and test to see if it was the correct key
                if (Input.GetButtonDown("QKey"))
                {
                    correctKey = true;
                }
                else
                {
                    correctKey = false;
                }
                StartCoroutine(keyPressing());
            }
        }
        else if (QTEGen == 2)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("WKey"))
                {
                    correctKey = true;
                }
                else
                {
                    correctKey = false;
                }
                StartCoroutine(keyPressing());
            }
        }
        else if (QTEGen == 3)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("EKey"))
                {
                    correctKey = true;
                }
                else
                {
                    correctKey = false;
                }
                StartCoroutine(keyPressing());
            }
        }
        else if (QTEGen == 4)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("AKey"))
                {
                    correctKey = true;
                }
                else
                {
                    correctKey = false;
                }
                StartCoroutine(keyPressing());
            }
        }
        else if (QTEGen == 5)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("SKey"))
                {
                    correctKey = true;
                }
                else
                {
                    correctKey = false;
                }
                StartCoroutine(keyPressing());
            }
        }
        else if (QTEGen == 6)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("DKey"))
                {
                    correctKey = true;
                }
                else
                {
                    correctKey = false;
                }
                StartCoroutine(keyPressing());
            }
        }
        else if (QTEGen == 7)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("ZKey"))
                {
                    correctKey = true;
                }
                else
                {
                    correctKey = false;
                }
                StartCoroutine(keyPressing());
            }
        }
        else if (QTEGen == 8)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("XKey"))
                {
                    correctKey = true;
                }
                else
                {
                    correctKey = false;
                }
                StartCoroutine(keyPressing());
            }
        }
        else if (QTEGen == 9)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("CKey"))
                {
                    correctKey = true;
                }
                else
                {
                    correctKey = false;
                }
                StartCoroutine(keyPressing());
            }
        }

        // There are 10 cupcakes, when something happens to all 10, end the game
        if (counter >= 10)
        {
            musicSource.Stop();
            gameOver();
        }
    }

    IEnumerator keyPressing()
    {
        // set QTEGen to a number outside the range (9)
        QTEGen = 10;
        // if the player hit the right key,
        if (correctKey == true)
        {
            ElonController instance = Elon.GetComponent<ElonController>();
            instance.doTheMonch();
            instance.shootSprinkles();
            soundSource.clip = monch;
            soundSource.Play();

            if (counter == 0)
            {
                Destroy(Cupcake);
            }
            else if (counter == 1)
            {
                Destroy(Cupcake1);
            }
            else if (counter == 2)
            {
                Destroy(Cupcake2);
            }
            else if (counter == 3)
            {
                Destroy(Cupcake3);
            }
            else if (counter == 4)
            {
                Destroy(Cupcake4);
            }
            else if (counter == 5)
            {
                Destroy(Cupcake5);
            }
            else if (counter == 6)
            {
                Destroy(Cupcake6);
            }
            else if (counter == 7)
            {
                Destroy(Cupcake7);
            }
            else if (counter == 8)
            {
                Destroy(Cupcake8);
            }
            else if (counter == 9)
            {
                Destroy(Cupcake9);
            }

            // generate a number (1-3) to pick which success quote you get
            passFailGen = Random.Range(1, 4);
            if (passFailGen == 1)
            {
                passFailBox.GetComponent<Text>().text = "Yummy!";
            }
            else if (passFailGen == 2)
            {
                passFailBox.GetComponent<Text>().text = "Good Job!";
            }
            else if (passFailGen == 3)
            {
                passFailBox.GetComponent<Text>().text = "Nom Nom!";
            }
            // increase score
            score++;
            updateScore();
            // update the counter to reflect that a cupcake was eaten
            counter++;
        }
        // if the player hit the wrong key,
        else if (correctKey == false)
        {
            ElonController instance = Elon.GetComponent<ElonController>();
            instance.doTheMonch();
            soundSource.clip = splat;
            soundSource.Play();

            if (counter == 0)
            {
                CupcakeController instance2 = Cupcake.GetComponent<CupcakeController>();
                instance2.dropped();
            }
            else if (counter == 1)
            {
                CupcakeController instance2 = Cupcake1.GetComponent<CupcakeController>();
                instance2.dropped();
            }
            else if (counter == 2)
            {
                CupcakeController instance2 = Cupcake2.GetComponent<CupcakeController>();
                instance2.dropped();
            }
            else if (counter == 3)
            {
                CupcakeController instance2 = Cupcake3.GetComponent<CupcakeController>();
                instance2.dropped();
            }
            else if (counter == 4)
            {
                CupcakeController instance2 = Cupcake4.GetComponent<CupcakeController>();
                instance2.dropped();
            }
            else if (counter == 5)
            {
                CupcakeController instance2 = Cupcake5.GetComponent<CupcakeController>();
                instance2.dropped();
            }
            else if (counter == 6)
            {
                CupcakeController instance2 = Cupcake6.GetComponent<CupcakeController>();
                instance2.dropped();
            }
            else if (counter == 7)
            {
                CupcakeController instance2 = Cupcake7.GetComponent<CupcakeController>();
                instance2.dropped();
            }
            else if (counter == 8)
            {
                CupcakeController instance2 = Cupcake8.GetComponent<CupcakeController>();
                instance2.dropped();
            }
            else if (counter == 9)
            {
                CupcakeController instance2 = Cupcake9.GetComponent<CupcakeController>();
                instance2.dropped();
            }

            // // generate a number (1-3) to pick which failure quote you get
            passFailGen = Random.Range(1, 4);
            if (passFailGen == 1)
            {
                passFailBox.GetComponent<Text>().text = "Oh No!";
            }
            else if (passFailGen == 2)
            {
                passFailBox.GetComponent<Text>().text = "Stinky!";
            }
            else if (passFailGen == 3)
            {
                passFailBox.GetComponent<Text>().text = "Dropped It!";
            }
            // update the counter to reflect that a cupcake was dropped
            counter++;
        }

        countingDown = false;
        // wait so changes aren't insatnt
        yield return new WaitForSeconds(0.25f);
        // clear texts
        passFailBox.GetComponent<Text>().text = "";
        keyBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.25f);
        waitingForKey = true;
        // stop all background processes
        StopAllCoroutines();
    }

    IEnumerator countDown()
    {
        // set a 3 second countdown for the current key
        yield return new WaitForSeconds(3.0f);
        if (countingDown == true)
        {
            // set QTEGen to a number outside the range (9)
            QTEGen = 10;
            // alert the player that they were too slow
            passFailBox.GetComponent<Text>().text = "Too Slow!";
            countingDown = false;
            // wait so changes aren't insatnt
            yield return new WaitForSeconds(0.5f);
            // clear texts
            passFailBox.GetComponent<Text>().text = "";
            keyBox.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(0.25f);
            // set a new key to be generated
            waitingForKey = true;
        }
    }

    IEnumerator introCountDown()
    {
        // set a 2 second countdown for the intro
        yield return new WaitForSeconds(2.0f);
        introActive = false;
        Destroy(introText);
        Destroy(introText2);
        musicSource.clip = backgroundMusic;
        musicSource.Play();
    }

    public void gameOver()
    {
        musicSource.Stop();
        // if the player has at least 5 points,
        if (score >= 5)
        {
            // they win
            gameOverText.text = "You Did It! Good Job!";
            soundSource.clip = winSound;
            soundSource.Play();
        }
        else
        {
            // otherwise they lose
            gameOverText.text = "Oh No! You're Still Hungry";
            soundSource.clip = loseSound;
            soundSource.Play();
        }
        // either way the game is over
        isGameOver = true;
    }

    void updateScore()
    {
        scoreText.text = "Score: " + score;
    }
}
