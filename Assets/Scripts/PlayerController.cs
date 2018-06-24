using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private int count;
    public float speed;
    public Text countText;
    public Text winText;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        //// Get input (pc)
        //var mvH = Input.GetAxis("Horizontal");
        //var mvV = Input.GetAxis("Vertical");

        // Get input (phone)
        var mvH = Input.acceleration.x;
        var mvV = Input.acceleration.y;

        // Aply transformation
        rb2d.AddForce(new Vector2(mvH, mvV) * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
            if (count >= 15) winText.text = "You win!";
        }
    }

    void SetCountText()
    {
        countText.text = "count: " + count.ToString();
    }
}
