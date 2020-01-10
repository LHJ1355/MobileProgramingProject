using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScript : MonoBehaviour
{
    public GameObject JoyStick, HP, Panel, InGame;
    public GameObject GameOverImage, RestartButton;

    public void reStart()
    {
        GameObject[] Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i = 0; i < Enemy.Length; i++)
        {
            Destroy(Enemy[i]);
        }
        GameOverImage.SetActive(false);
        RestartButton.SetActive(false);

    }
    public void gameStart()
    {
        Time.timeScale = 1;
        JoyStick.SetActive(true);
        HP.SetActive(true);
        Panel.SetActive(false);
        InGame.SetActive(true);
    }
    void Awake()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
