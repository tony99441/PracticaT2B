using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegamanPlayer : MonoBehaviour
{
    
    private Rigidbody2D MegamanRb;
    private SpriteRenderer MegamanSr;
    private Animator MegamanAnimator;
    
    public bool grounded;

    private bool DobleJumped;
    

    public float FuerzaSalto ;

    public Transform balaPosition;

    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        MegamanRb = GetComponent<Rigidbody2D>();
        MegamanSr = GetComponent<SpriteRenderer>();
        MegamanAnimator = GetComponent<Animator>();
        
    }

 


    // Update is called once per frame
    void Update()
    {
        if (grounded)
            DobleJumped = false;
       
        PlayerMovement();
        PlayerJump();
        PlayerDisparo();
    }
    public void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MegamanSr.flipX = false;
            MegamanRb.velocity = new Vector2(10, MegamanRb.velocity.y);
           

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MegamanSr.flipX = true;
            MegamanRb.velocity = new Vector2(-10, MegamanRb.velocity.y);
           
        }
        MegamanAnimator.SetFloat("estado",Mathf.Abs(MegamanRb.velocity.x));
        
    }

    public void PlayerJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            MegamanRb.velocity = new Vector2(MegamanRb.velocity.x,FuerzaSalto);
        }
       
        MegamanAnimator.SetFloat("Salto",Mathf.Abs(MegamanRb.velocity.y));
        // Cuando presione la tecla derecha cambia la animación.
        // Input.GetKey() // mientras mantenga presionado
        // Input.GetKeyUp() // Cuando suelto la tecla
        // Input.GetKeyDown // Cuando presiono por primera vez
    }

    public void PlayerDisparo()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bala, balaPosition.position, balaPosition.rotation);
        }
    }
    
}
