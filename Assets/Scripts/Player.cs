using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 4f;
    float xMove;
    float yMove;
    float speedModifier = 1.75f;

    public bool isRunning, invOpen, paused = false;

    public GameObject camManager, targetCam, uiManager;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            uiManager.GetComponent<UIManager>().EnableUI("pause", paused);

            if (paused)
            {
                rb.simulated = false;
            }
            else
            {
                rb.simulated = true;
            }
        }

        if (!paused)
        {
            xMove = Input.GetAxis("Horizontal");
            yMove = Input.GetAxis("Vertical");

            if (xMove == 0)
            {
                rb.velocity = new Vector2(0, yMove * playerSpeed);
            }

            if (yMove == 0)
            {
                rb.velocity = new Vector2(xMove * playerSpeed, 0);
            }

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) && !isRunning)
            {
                isRunning = true;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift) && isRunning)
            {
                isRunning = false;
            }

            if (isRunning)
            {
                playerSpeed = 4f * speedModifier;
            }
            else
            {
                playerSpeed = 4f;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.transform.position.Set(-8, 54, 0);
            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                if (invOpen)
                {
                    invOpen = false;
                    uiManager.GetComponent<UIManager>().EnableUI("inventory", false);
                }
                else
                {
                    invOpen = true;
                    uiManager.GetComponent<UIManager>().EnableUI("inventory", true);                
                }
            }

            rb.velocity = new Vector2(xMove * playerSpeed, yMove * playerSpeed);
        }
    }
}
