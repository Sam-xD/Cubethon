using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bruh : MonoBehaviour
{
    public Rigidbody rb;
   
    public int sideforce=5;
    public int forwardforce=2000;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.position.y < 5)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        rb.AddForce(0,0,forwardforce*Time.deltaTime);
        if (Input.GetKey("left"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("right"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
    }
}
