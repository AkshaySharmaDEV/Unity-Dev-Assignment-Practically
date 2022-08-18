using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnTrigger : MonoBehaviour
{

    public Rigidbody rb;
    public float strength;
    public Transform direction;

    
    
    void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.name == "Ch38_Shoes")
        {
            rb.AddForce(direction.forward * strength);
        

        }
    }

    
}
