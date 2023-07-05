using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : ManualWeapon
{
    private void Update()
    {
        Fire();
        Reload();
    }

    protected override void Fire()
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
                int spawnOffset = -1;
                for (int i = 0; i < 2; i++)
                {
                    Vector3 spawnPos = transform.position;
                    spawnPos.z += 2;
                    spawnPos.x += spawnOffset;
                    spawnOffset++;

                    GameObject bullet = Instantiate(projectile, spawnPos, Quaternion.identity);

                    bullet.AddComponent(typeof(Rigidbody));

                    Rigidbody _rb = bullet.GetComponent<Rigidbody>();
                    _rb.useGravity = false;
                    _rb.AddForce(bullet.transform.forward * 10, ForceMode.Impulse);
                }

                currentRounds--;
                timer = 0;
            }
        }
    }
}

