using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Transform firePoint;          // Point from where the bullet will be fired
    [SerializeField] ObjectPoolManager poolManager; // Reference to the ObjectPoolManager


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))        // Check for fire input
        {
            Shoot();                                // Call the Shoot method
        }
    }


    void Shoot()
    {
        poolManager.SpawnFromPool("Bullet", firePoint.position, firePoint.rotation); // Spawn a bullet from the pool
       // AudioManagerForMusicandShooting.instance.PlayShoot(); // Play shooting sound
      // FindObjectOfType<AnotherAudioManager>().Play("Shoot"); // Play shooting sound
    }
}
