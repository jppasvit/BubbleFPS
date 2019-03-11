using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform bulletSpawn;

    public GameObject bulletPrefab;

    public int bulletVelocity;

    
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletVelocity;

        // TODO Implements DESTROY of BulletBubble in BulletBubble
        // Destroy the bullet after 2 seconds
        //Destroy(bullet, 4.0f);
    }

    void OnDrawGizmos()
    {
        if (bulletSpawn != null)
        {
            Debug.DrawLine(bulletSpawn.position, bulletSpawn.position + bulletSpawn.transform.forward, Color.red);
        }
    }
}
