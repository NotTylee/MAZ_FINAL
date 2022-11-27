
using UnityEngine;

public class Gun : MonoBehaviour
{


    public float damage = 10f;
    public float range = 100f;
  
  

    public Camera fpscamera;
    public ParticleSystem muzzleflash;
   

   

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            
            Shoot();
        }

    }

    void Shoot()
    {
        muzzleflash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpscamera.transform.position, fpscamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

           

           
        }

    }
}

