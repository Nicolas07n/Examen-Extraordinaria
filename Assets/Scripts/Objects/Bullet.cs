using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletType { NORMAL_BULLET, FREEZING_BULLET }

// programa aqui la clase Bullet
public abstract class Bullet
{
    protected float speed;
    protected Sprite sprite;

    public Bullet()
    {

    } 
    
    public Bullet (Sprite sprite , float speed)
    {


        this.sprite = sprite;
        this.speed = speed;
    }

    public abstract void OnHit (GameObject hitGameObject);


    public Sprite GetSprite() 
    {
     return sprite;
    
    }


}
