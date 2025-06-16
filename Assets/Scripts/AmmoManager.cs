using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AmmoManager
{
    public static AmmoManager instance;
    private int numeroPelotas = 0;
    public int NumeroPelotas=>numeroPelotas;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            GraphElementScopeExtensions
        }
   
        else
        {
            Destroy(gameObject);


        }
    
    
    
    
    }  


    public void RegistrarNumeroPelotas()
    {


        numeroPelotas++;
    }





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
