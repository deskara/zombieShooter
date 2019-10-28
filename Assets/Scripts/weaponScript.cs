using UnityEngine;
public class weaponScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform leftBulletSpawn;
    public Transform rightBulletSpawn;
    public float fireTime = 0.5f;
    private bool isFiring = false;
    private void SetFiring()
    {
        isFiring = false;
    }
    //LeftFire handles firing out of the left gun
    private void LeftFire()
    {
        isFiring = true;
        Instantiate(bulletPrefab, leftBulletSpawn.position, leftBulletSpawn.rotation);
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
        Invoke("SetFiring", fireTime);
    }
    //RightFire handles firing out of the right gun
    private void RightFire()
    {
        isFiring = true;
        Instantiate(bulletPrefab, rightBulletSpawn.position, rightBulletSpawn.rotation);
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
        Invoke("SetFiring", fireTime);
    }
    private void Update()
    {
        // 0 is the left mouse button
        if (Input.GetMouseButton(0))
        {
            if (!isFiring)
            {
                LeftFire();
            }
        }
        // 1 is the right mouse button
        else if (Input.GetMouseButton(1)) 
        {
            if (!isFiring)
            {
                RightFire();
            }

        }
    }
}