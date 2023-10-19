using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public float playerSpeed;
    public void Awake()
    {
        playerSpeed = gameObject.GetComponent<player>().speed;
    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("slow"))
        {

            Debug.Log(gameObject.name + " is triggered by " + collision.gameObject.name);
            gameObject.GetComponent<player>().speed /= 2.0f;

        }
        if (collision.CompareTag("score"))
        {

            Debug.Log(gameObject.name + " is triggered by " + collision.gameObject.name);
            gameObject.GetComponent<player>().score += 1;
        
        }
        if (collision.CompareTag("fast"))
        {
            Debug.Log(gameObject.name + " is triggeredby " + collision.gameObject.name);
            gameObject.GetComponent<player>().speed *= 10.0f;
        }
        if (collision.CompareTag("hurt"))
        {
            Debug.Log(gameObject.name + " is triggeredby " + collision.gameObject.name);
            gameObject.GetComponent<player>().score -= 1;
        }
    }

    // Update is called once per frame
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(gameObject.name + " is no longer triggered by " + collision.gameObject.name);
        gameObject.GetComponent<player>().speed = playerSpeed;
    }
}
