using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float speed, jumpForce, sphereRadius;
    public LayerMask groundLayer;

    private Rigidbody2D _rb;
    private SpriteRenderer _spriteRenderer;
    private Animator animator;
    private float x, y, jump;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        jump = Input.GetAxisRaw("Jump");

        _spriteRenderer.flipX = x < 0;
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(x * speed, _rb.velocity.y);

        if (jump != 0 && IsGrounded())
        {          
            _rb.AddForce(new Vector2(0, jumpForce * _rb.gravityScale));
        }
    }

    private bool IsGrounded()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y - _spriteRenderer.bounds.size.y/2), sphereRadius, groundLayer);

        return hits.Length > 0;
    }

    private void OnDrawGizmos()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(new Vector2(transform.position.x, transform.position.y - _spriteRenderer.bounds.size.y / 2), sphereRadius);
    }
}
