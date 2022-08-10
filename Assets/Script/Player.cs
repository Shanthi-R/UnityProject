

using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{


    public float JumpForce;
    float score;
    [SerializeField]
    bool isGrounded = false;
    bool isAlive = true;
    Rigidbody2D RB;
    public TextMeshProUGUI scoreText;
    private SpriteRenderer sr;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;
    }
    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;

    }


    void Update()
    {
       
        if (Input.GetKeyUp(KeyCode.Space))

        {
            RB.velocity = new Vector2(RB.velocity.x, 10f);
            {
                if (Input.GetKey(KeyCode.A))

                {
                    RB.velocity = new Vector2(-5, RB.velocity.y);
                    transform.localScale = new Vector2(-1, 1);
                }

                if (Input.GetKey(KeyCode.D))

                {
                    RB.velocity = new Vector2(5, RB.velocity.y);
                    transform.localScale = new Vector2(1, 1);
                }

                if (Input.GetKeyUp(KeyCode.Space))

                {
                    RB.velocity = new Vector2(RB.velocity.x, 8f);
                }
            }
           


        }
        
        
        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"collision");
        if (collision.gameObject.CompareTag("ground"))
        {
            if (isGrounded == false)
            {
                isGrounded = true;
            }
        }

        if (collision.gameObject.CompareTag("spike"))
        {
            isAlive = false;
            Time.timeScale = 0;
            SceneManager.LoadScene("LoseScreen");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "scorepoint")
        {
            score++;
            scoreText.text = score.ToString();
        }

    }
}
        

        
           
        

    



  







   
