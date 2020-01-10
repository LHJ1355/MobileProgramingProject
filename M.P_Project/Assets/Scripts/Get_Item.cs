using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Item : MonoBehaviour
{
    public GameObject ItemSpawnPoint;
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "ItemLocation")
        {
            ItemSpawnPoint.GetComponent<activeItem>().RandomIndex();
        }
    }
}
