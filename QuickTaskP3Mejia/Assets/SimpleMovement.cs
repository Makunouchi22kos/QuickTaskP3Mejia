using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class SimpleMovement : MonoBehaviour
{
    public float speed;
    public float Move;
    public float jump;
    public TextMeshProUGUI WINTEXT;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal"); 

        rb.velocity = new Vector2(Move * speed, rb.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }

    private void OnTriggerEnter2d(Collider2D collison)
    {
        if (collison.tag == "Win")
        {
            WINTEXT.gameObject.SetActive(true);
        }
    }
}
