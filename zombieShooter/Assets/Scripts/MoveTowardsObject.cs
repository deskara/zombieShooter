using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script handles making an enemy move towards the player.
public class MoveTowardsObject : MonoBehaviour
{
    public Transform target;
    public float speed = 5.0f;
    private void FixedUpdate()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f);
        }
    }
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

}
