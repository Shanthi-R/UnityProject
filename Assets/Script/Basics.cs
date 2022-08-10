using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basics : MonoBehaviour
{
    public float movespeed = 5f;
    public GameObject enemy;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movement * Time.deltaTime * movespeed;


    }
    private void OnTriggerEnter2D(Collider2D other) { 
        if(other.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}

    
