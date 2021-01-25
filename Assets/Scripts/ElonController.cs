using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElonController : MonoBehaviour
{
    public Animator animator;
    // access QTE script
    public GameObject QTESystem;
    public ParticleSystem sprinkles;

    [HideInInspector]
    private static bool isOver;
    [HideInInspector]
    private static int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // accessing Elon script
        isOver = QTESystem.GetComponent<QTEController>().isGameOver;

        if (isOver == true)
        {
            score = QTESystem.GetComponent<QTEController>().score;

            if (score >= 5)
            {
                beHappy();
            }
            else
            {
                beSad();
            }
        }
    }

    public void doTheMonch()
    {
        animator.SetTrigger("isEating");
    }

    public void shootSprinkles()
    {
        sprinkles.Emit(20);
    }

    public void beHappy ()
    {
        animator.SetBool("isOver", true);
        animator.SetBool("score", true);
    }

    public void beSad()
    {
        animator.SetBool("isOver", true);
        animator.SetBool("score", false);
    }
}
