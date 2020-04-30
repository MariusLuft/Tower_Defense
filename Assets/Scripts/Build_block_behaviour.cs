using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Build_block_behaviour : MonoBehaviour
{
    public GameObject TowerPrefab;

    private void OnMouseUpAsButton()
    {
        GameObject g = (GameObject)Instantiate(TowerPrefab);
        g.transform.position = transform.position + UnityEngine.Vector3.up;
    }
}
