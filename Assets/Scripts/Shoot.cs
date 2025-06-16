using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform firepoint;//LO que hago con el fire point es crear un empty(Objeto vacio) hijo del personaje para que lo siga , y que sea desde ahi donde se instancia la bala 
    public float fireRate = 0.3f;
    private float nextFireTime;

    private void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextFireTime) 
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        
        
        
        }


    }

    void Shoot()
    {

        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, Quaternion.identity);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - firepoint.position; 
        bullet.GetComponent<Bullet>().SetDirection(direction);
    }

}
