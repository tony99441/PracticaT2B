using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody2D BalaRb;
    public float VelocidadBala;
    public float vidaBala;

    private GameObject player;
    private SpriteRenderer playerSr;
    

    void Awake()
    {
        BalaRb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
        playerSr =player.GetComponent<SpriteRenderer>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        if (!playerSr.flipX)
        {
            BalaRb.velocity=new Vector2(VelocidadBala,BalaRb.velocity.y);
        }
        else
        {
            BalaRb.velocity=new Vector2(-VelocidadBala,BalaRb.velocity.y);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,vidaBala);
    }
}
