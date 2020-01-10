using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{
    public GameObject player;
    private Transform cam;

    float dist = -3.0f;
    float height = 3.0f;
    float dampRotate = 5.0f;

    /*Vector3 castDir;
    RaycastHit hit;
    GameObject obstacle;
    GameObject prevHitObject = null;*/

    /*void obstacleManager(GameObject currentHitObject)
    {
        Renderer prevR, currentR;
        Color prevColor, currentColor;

        prevR = prevHitObject.GetComponent<Renderer>();
        prevColor = prevR.material.color;

        if(currentHitObject.tag == "Player")
        {
            if(prevHitObject.tag == "Player")
            {
                return;
            }
            else
            {
                prevColor.a = 1.0f;
                prevR.material.color = prevColor;
           }
        }
        else
        {
            currentR = currentHitObject.GetComponent<Renderer>();
            currentColor = currentR.material.color;
            currentColor.a = 0.2f;
            currentR.material.color = currentColor;
            //currentHitObject.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.2f);
            if(prevHitObject != currentHitObject)
            {
                prevColor.a = 1.0f;
                prevR.material.color = prevColor;
           }
        }
        
    }*/

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Transform>();
        //prevHitObject = player;
    }

    // Update is called once per frame
    void Update()
    {
        float currYAngle = Mathf.LerpAngle(cam.eulerAngles.y, player.transform.eulerAngles.y, dampRotate * Time.deltaTime);

        Quaternion rot = Quaternion.Euler(0, currYAngle, 0);

        cam.position = player.transform.position - (/*rot *  */Vector3.forward * dist) + (Vector3.up * height);

        cam.LookAt(player.transform);

        

        /*castDir = (player.transform.position - cam.position).normalized;

        if(Physics.Raycast(cam.position, castDir, out hit, Mathf.Infinity))
        {
            obstacle = hit.transform.gameObject;
            //if (!hit.collider.CompareTag("Player"))
            obstacleManager(obstacle);
            prevHitObject = obstacle;
        }*/
    }
}
