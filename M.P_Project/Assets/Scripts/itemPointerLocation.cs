using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPointerLocation : MonoBehaviour
{
    GameObject Player;
    GameObject Destination;
    Transform Pointer;
    Vector3 dist = new Vector3(0.0f, -1.0f, 0.0f);
    Vector3 itemDirection;
    // Start is called before the first frame update
    void Start()
    {
        Pointer = GetComponent<Transform>();
        Player = Pointer.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Pointer.position = Player.transform.position - dist;

        Destination = GameObject.FindWithTag("ItemLocation");
        itemDirection = (Player.transform.position - Destination.transform.position).normalized;
        this.transform.forward = itemDirection;
    }
}
