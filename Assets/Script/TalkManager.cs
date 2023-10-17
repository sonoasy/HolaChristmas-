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
        talkData.Add(100,new string[]{"���Ͽ� ���� �ִ°� ������?","���� ���� �ʵ��� ������"});
    }

    public string GetTalk(int id,int talkIndex)
    {
        if (talkIndex == talkData[id].Length) return null;
        return talkData[id][talkIndex];
    }
}
