using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Freezingbullet : Bullet
{
    public Freezingbullet()
    {

    }

    public Freezingbullet( Sprite Freezingbullet , Rigidbody2D rb ) : base (35 , Resources.Load<Sprite>("./ResourcesFreezingbullet"))
    {
        this.speed = 35;


    }

    public override void Move()
    {
        rb.velocity = new Vector2(Mathf.Sin(Time,time)* speed,speed);
    }
}
