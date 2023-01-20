using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BallManagerrr : MonoBehaviour
{
    public AudioSource balleffect;
   public static BallManagerrr bm;
    public SpriteRenderer ball;
    public Color cl;
    public bool isRed = false;
    public bool isGreen = false;
    public bool isBlue = false;
    public bool isYellow = false;

    
    // public static GameManager game_manager;
    private Rigidbody2D rb;
    public PaddleManagerrr instance;
    private Vector3 paddleToBallVector;
    private bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        bm = this;
        rb = GetComponent<Rigidbody2D>();
        paddleToBallVector = this.transform.position - instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cl = ball.color;
        if (!hasStarted)
        {
            this.transform.position = instance.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                this.rb.velocity = new Vector2(Random.Range(-10f,10f),8f);
                    
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        balleffect.Play();
        if (collision.gameObject.CompareTag("left"))
        {
            //this.rb.velocity = new Vector2(Random.Range(-4f,4f), 7f);

            ball.color = Color.red;
            allTrue();
        }
        if (collision.gameObject.CompareTag("right"))
        {
            //this.rb.velocity = new Vector2(3f, 8f);
            ball.color = Color.blue;
            allTrue();
        }
        if (collision.gameObject.CompareTag("bottom"))
        {
           this.rb.velocity = new Vector2(Random.Range(-8f, 8f), 8f);
            ball.color = Color.yellow;
            allTrue();
        }
        if (collision.gameObject.CompareTag("up"))
        {
            //this.rb.velocity = new Vector2(4f, 7f);

            ball.color = Color.green;
            allTrue();
        }
    }
    public void allTrue()
    {
        isRed = true;
        isBlue = true;
        isGreen = true;
        isYellow = true;
    }
   
}
