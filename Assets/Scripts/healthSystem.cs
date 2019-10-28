using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }
public class healthSystem : MonoBehaviour
{
    public int health = 10;
    public int damage = 5;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;
    public void TakeDamage(int damage)
    {
        health -= damage;
        onDamaged.Invoke(health);
        if (health < 1)
        {
            onDie.Invoke();
            //As there are no listeners for the onDie I'm currently just destroying the Zombie.
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("An attempt to make the player take damage was made");
        //This makes the other entity run the "take damage" method
        collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
    }

   
}
