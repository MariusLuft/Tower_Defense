using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Script : MonoBehaviour
{
    //monster
    public GameObject monsterPrefab;
    //delay time 
    public float interval = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnNext", interval, interval);
    }

    void spawnNext()
    {
        Instantiate(monsterPrefab, transform.position, Quaternion.identity);
    }
}
