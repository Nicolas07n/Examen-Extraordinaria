using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmoManager
{
    public static AmmoManager instance;

    private AmmoManager()
    {
        
    }

    public static AmmoManager GetInstance()
    {
       return null; // borrar cuando se implemente el metodo
    }

    public void AddRandomBullet()
    {
        
    }

    // devuelve y elimina el objeto de la estructura de datos
    public Bullet GetFrontBullet()
    {
        return null; // borrar cuando se implemente el metodo
    }

    // devuelve pero no elimina el objeto de la estructura de datos
    public Bullet PeerFrontBullet()
    {
        return null; // borrar cuando se implemente el metodo
    }
}
