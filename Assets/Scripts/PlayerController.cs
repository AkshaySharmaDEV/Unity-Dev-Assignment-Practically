using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnim;
    
    public float rotateSpeed;
    public bool walking;
    public Transform playerTransfrom;
    
    
   

    // Update is called once per frame
    void Update()
    {


        if(Input.GetKeyDown(KeyCode.W))
        {
            playerAnim.Play("Walk");
            
            walking = true;
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            
            playerAnim.Play("Idle");
            walking = false;
        }
        
        if(Input.GetKeyDown(KeyCode.S))
        {
            playerAnim.Play("WalkBack");
            
            
        }

        if(Input.GetKeyUp(KeyCode.S))
        {
            
            playerAnim.Play("Idle");
            
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }

    

        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.Play("Jump");
    
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
             Application.Quit();
    
        }

        

        if(walking == true)
        {
            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                
                playerAnim.Play("Sprint");
                
            }
            if(Input.GetKeyUp(KeyCode.LeftShift))
            {
                
                playerAnim.Play("Idle");
            }
            
        }


    }
}
