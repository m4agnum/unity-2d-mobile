public class shooting : MonoBehaviour
{
    //variables 
    public GameObject bullet;
    public Transform firepoint;
    public float bulletforce = 10f;
    public GameObject shotgun;

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
