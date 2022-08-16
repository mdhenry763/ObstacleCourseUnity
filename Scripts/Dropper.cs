using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody physics;
    [SerializeField] float waitingTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        physics = GetComponent<Rigidbody>();

        renderer.enabled = false;
        physics.useGravity = false;    
    }

    // Update is called once per frame
    void Update()
    {
        float timeSecs = Time.time;
        if(timeSecs > waitingTime){
            renderer.enabled = true;
            physics.useGravity = true;   
           
        }
            
    }
}
