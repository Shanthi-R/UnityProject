using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "enemy")
        {
            Debug.Log("Game Over");
        }
    }
    private SpriteRenderer sr;
    public Transform target;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.green;


    }


    void Update()
    {

    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            SceneManager.LoadScene("LoseScreen");
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            transform.Rotate(0f, 180f, 0f);
        }
           
        }
    }

    
        