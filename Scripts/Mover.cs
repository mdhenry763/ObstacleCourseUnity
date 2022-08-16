using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 2.0f;  
    [SerializeField] float yValue = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();                  
    }

    // Update is called once per frame
    void Update()
    {   
        MovePlayer();
       // transform.Translate(xValue,-yValue,zValue);     
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        
    }
    
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float jump = Input.GetAxis("Jump") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,jump,zValue); 
    }

}
