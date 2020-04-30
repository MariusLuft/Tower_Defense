using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster_Behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject Castle = GameObject.Find("Castle");
        if (Castle)
            GetComponent<NavMeshAgent>().destination = Castle.transform.position;
    }

    private void OnTriggerEnter(Collider co)
    {
        if (co.name == "Castle") {
            co.GetComponentInChildren<Health>().decrease();
            Destroy(gameObject);
        }

    }
}
