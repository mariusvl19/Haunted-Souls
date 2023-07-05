using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ManualWeapon : Weapon_Base
{
    [SerializeField] protected int magazineSize;
    [SerializeField] public int currentRounds;
    private Camera fpsCam;
    protected float weaponRange = 50f;         // Distance in Unity units over which the player can fire
    protected float hitForce = 100f;
    [SerializeField] protected int weaponDamage = 1;
    [SerializeField] protected GameObject projectile;
    [SerializeField] protected GameObject spawnPoint;
    [SerializeField] protected ParticleSystem muzzleFlash;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip gunSound;


    void Start()
    {
        fpsCam = GetComponentInParent<Camera>();
    }
    protected virtual void Reload()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentRounds = magazineSize;
        }
    }

    protected virtual void Fire()
    {
        timer += Time.deltaTime;
       

        if (currentRounds < 1)
        {
            return;
        }
        
       

        if (Input.GetMouseButtonDown(0))
        {
            if (timer > fireRate)
            {
                muzzleFlash.Play();
                _audioSource.PlayOneShot(gunSound);
                // Create a vector at the center of our camera's viewport
                //Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
                RaycastHit hit;

                GameObject bullet = Instantiate(projectile, spawnPoint.transform.position, spawnPoint.transform.rotation);

                bullet.AddComponent(typeof(Rigidbody));

                Rigidbody _rb = bullet.GetComponent<Rigidbody>();
                _rb.useGravity = false;
                _rb.AddForce(spawnPoint.transform.forward * 10, ForceMode.Impulse);

                currentRounds--;
                timer = 0;

                if (Physics.Raycast(spawnPoint.transform.position, spawnPoint.transform.forward, out hit, weaponRange))
                {
                    // Get a reference to a health script attached to the collider we hit
                    HorrorMutant_HealthScript health = hit.collider.GetComponent<HorrorMutant_HealthScript>();
                    // If there was a health script attached
                    if (health != null)
                    {
                        // Call the damage function of that script, passing in our weaponDamage variable
                        health.EnemyTakesDamage(weaponDamage);
                    }

                    // Check if the object we hit has a rigidbody attached
                    if (hit.rigidbody != null)
                    {
                        // Add force to the rigidbody we hit, in the direction from which it was hit
                        hit.rigidbody.AddForce(-hit.normal * hitForce);
                    }
                }
            }
        }
    }
}




