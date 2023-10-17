using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
   
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
        
    }

  
    void GenerateData()
    {
        talkData.Add(100,new string[]{"지하에 무언가 있는것 같은데?","길을 잃지 않도록 조심해"});
    }

    public string GetTalk(int id,int talkIndex)
    {
        if (talkIndex == talkData[id].Length) return null;
        return talkData[id][talkIndex];
    }
}
