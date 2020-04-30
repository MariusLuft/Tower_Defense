using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Behaviour : MonoBehaviour
{
    public float speed = 10;
    public Transform target;
    private void FixedUpdate()
    {
        if (target)
        {
            Vector3 dir = target.position - transform.position;
            GetComponent<Rigidbody>().velocity = dir.normalized * speed;
        }
        else
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Health health = GetComponentInChildren<Health>();
        if (health)
        {
            health.decrease();
            Destroy(gameObject);
        }
    }
}
