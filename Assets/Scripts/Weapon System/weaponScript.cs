using UnityEngine;
public class weaponScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform leftBulletSpawn;
    public Transform rightBulletSpawn;
    public float rightfireTime = 0.25f;
    public float leftfireTime = 0.25f;
    private bool rightisFiring = false;
    private bool leftisFiring = false;
    private void SetLeftFiring()
    {
        leftisFiring = false;
    }
    private void SetRightFiring()
    {
        rightisFiring = false;
    }
    //LeftFire handles firing out of the left gun
    private void LeftFire()
    {
        if (!leftisFiring)
        {
            leftisFiring = true;
            Instantiate(bulletPrefab, leftBulletSpawn.position, leftBulletSpawn.rotation);
            bulletPrefab.GetComponent<bulletScript>().setDamage(PlayerPrefs.GetInt("damage"));
            if(PlayerPrefs.GetString("equippedLeftWeapon") != "piercingRifle")
            {
                bulletPrefab.GetComponent<bulletScript>().setType("standard");
            }
            else
            {
                bulletPrefab.GetComponent<bulletScript>().setType("piercing");
                bulletPrefab.GetComponent<bulletScript>().setMoveSpeed(900);
            }
            if (GetComponent<AudioSource>() != null)
            {
                GetComponent<AudioSource>().Play();
            }
            Invoke("SetLeftFiring", leftfireTime);
        }

    }
    //RightFire handles firing out of the right gun
    private void RightFire()
    {
        if (!rightisFiring)
        {
            rightisFiring = true;
            Instantiate(bulletPrefab, rightBulletSpawn.position, rightBulletSpawn.rotation);
            bulletPrefab.GetComponent<bulletScript>().setDamage(PlayerPrefs.GetInt("damage"));
            if (PlayerPrefs.GetString("equippedRightWeapon") != "piercingRifle")
            {
                bulletPrefab.GetComponent<bulletScript>().setType("standard");
            }
            else
            {
                bulletPrefab.GetComponent<bulletScript>().setType("piercing");
            }
            if (GetComponent<AudioSource>() != null)
            {
                GetComponent<AudioSource>().Play();
            }
            Invoke("SetRightFiring", rightfireTime);

        }

    }
    private void FixedUpdate()
    {
        // 0 is the left mouse button
        if (Input.GetMouseButton(0))
        {
            LeftFire();
            if(PlayerPrefs.GetString("fireState") == "Both")
            {
                RightFire();
            }

        }
        // 1 is the right mouse button
        //If is used instead of else if as it allows for both to be fired at the same time.
        if (Input.GetMouseButton(1)) 
        {
            RightFire();
            if (PlayerPrefs.GetString("fireState") == "Both")
            {
                LeftFire();
            }

        }
    }
}