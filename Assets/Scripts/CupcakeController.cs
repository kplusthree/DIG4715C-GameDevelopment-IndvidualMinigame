using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupcakeController : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = -10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void dropped()
    {
        rb.AddForce(new Vector2(0, speed), ForceMode2D.Impulse);
    }
}
