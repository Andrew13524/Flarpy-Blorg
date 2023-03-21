using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public int FlapStrength;

    private bool birdIsAlive;
    private LogicManager logicManager;

    private void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        birdIsAlive = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            rigidBody2D.velocity = Vector2.up * FlapStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            birdIsAlive = false;
            logicManager.GameOver();
        }
    }
}
