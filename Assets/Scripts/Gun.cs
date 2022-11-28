
using UnityEngine;

public class Gun : MonoBehaviour
{


   
    public float range = 100f;

    public int damageAmount = 20;

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
                enemy.TakeDamage(damageAmount);
                return;
                
                  
                

            }

           

           
        }

    }
}

