using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    //variables 
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firepoint;
    [SerializeField] private float bulletforce = 10f;
    [SerializeField] private GameObject shotgun;

    void Update()
    {
        //inputs (mine are for mobile , you can change them )
        if (Input.touchCount > 0 )
        {
            Touch touch = Input.GetTouch(1);


            if (touch.phase == TouchPhase.Began && Time.time >= NextFire)
            {
                //(fire rate) you can change for you preference
                NextFire = Time.time + 3f / fireRate;
                shoot();
            }
        }
    }


    public void shoot()
    {
        //the direction 
        GameObject b = Instantiate(bullet, firepoint.position, firepoint.rotation);
        Rigidbody rb = b.GetComponent<Rigidbody>();
        // force 
        rb.AddForce(firepoint.up * bulletforce, ForceMode.Impulse);

        // here you can add your damage system .....

    }
}
