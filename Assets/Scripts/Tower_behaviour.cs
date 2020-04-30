using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_behaviour : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float rotationspeed = 35;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationspeed, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Monster_Behaviour>())
        {
            GameObject g = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<Bullet_Behaviour>().target = other.transform; 
        }
    }
}
