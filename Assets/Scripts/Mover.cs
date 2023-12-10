using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    public GameObject finisher;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool gameStatus = finisher.GetComponent<Finisher>().gameEnded;
        if(gameStatus == false)
        {
            MovePlayer();
        }
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game!!!\tMove your player with WASD.\tDon't hit the walls!");
    }

    void MovePlayer()
    {
        // float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        // float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        // transform.Translate(xValue,0,zValue);
        
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        ForceMode forceMode = ForceMode.VelocityChange;
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(moveSpeed * Time.deltaTime, 0, 0, forceMode);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-moveSpeed * Time.deltaTime, 0, 0, forceMode);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, moveSpeed * Time.deltaTime, forceMode);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -moveSpeed * Time.deltaTime, forceMode);
        }
    }
}
