using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Joystick joyStick;
    float moveSpeed = 3.0f;

    public void Init()
    {
        this.transform.position = new Vector3(12.0f, 0.5f, -2.0f);
    }
    void Start()
    {
        Init();
    }
    // Update is called once per frame
    void Update()
    {
        if(joyStick.Vertical != 0 || joyStick.Horizontal != 0)
        {
            this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            this.transform.rotation = Quaternion.Euler(0f, Mathf.Atan2(joyStick.Horizontal, joyStick.Vertical) * Mathf.Rad2Deg, 0f);
        }
    }
}
