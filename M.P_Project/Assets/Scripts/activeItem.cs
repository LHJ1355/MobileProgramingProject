using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class activeItem : MonoBehaviour
{
    int num;
    int index, cnt, prevIndex;
    GameObject[] ItemSpawn;
    public Text Score;

    public void RandomIndex()
    {
        prevIndex = index;
        if(index != -1)
        {
            ItemSpawn[index - 1].SetActive(false);
        }
        
        index = Random.Range(1, num + 1);
        while(index == prevIndex)
        {
            index = Random.Range(1, num + 1);
        }
        ItemSpawn[index - 1].SetActive(true);
        cnt += 1;
        Score.text = "SCORE : " + cnt;
    }
    public void Init()
    {
        index = -1;
        cnt = -1;
        for (int i = 0; i < ItemSpawn.Length; i++)
        {
            ItemSpawn[i].SetActive(false);
        }
        RandomIndex();
    }
    void Awake()
    {
        ItemSpawn = GameObject.FindGameObjectsWithTag("ItemLocation");
        num = ItemSpawn.Length;
    }
    void Start()
    {
        Init();
    }
}
