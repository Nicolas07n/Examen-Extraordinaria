using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : Bullet
{
    public override void OnHit(GameObject hitGameObject)
    {
        throw new System.NotImplementedException();
    }

    public NormalBullet(Sprite NormalBulletSprite, Rigidbody2D rb) : base (50, 0, Resources.Load<Sprite>("./Resource/NormalBullet",)
    {



    }

    public override void Hit()
    {


    }







}
