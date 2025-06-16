using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    // public Bullet bullet;
    public Vector2 direccion;
    public float speed = 1.0f;  
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private int bouncecount = 0;
    private int maxbcecount = 0;
    // Start is called before the first frame update
    void Start()
    {    
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        
       rb.velocity = Direction.normalized*speed;
    }

    public void SetDirction(Vector2 dir)
    {
        Direction = dir.normalized;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {

            return;
            bouncecount++;
        }
        if (bouncecount == maxbcecount) 
        {

            Destroy(gameObject);
        
        
        }
   
    
    }




}
