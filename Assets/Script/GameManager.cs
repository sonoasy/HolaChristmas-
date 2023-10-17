using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject;
    public bool isAction;
    public int talkIndex;

    public void Action(GameObject scanObj)
    {

        scanObject = scanObj;
        talkText.text = "이것은" + scanObject.name + "이다";
        // Debug.Log(scanObject.name);
        if (scanObject.tag == "Cat") Debug.Log(scanObject.name);
    }
        /*if (isAction)
        {
            isAction = false;
        }
        else
        {
            isAction = true;
            
            ObjData objData = scanObject.GetComponent<ObjData>();
            Talk(objData.id, objData.isNpc);
        }
        talkPanel.SetActive(isAction);
    }
    
    void Talk(int id,bool isNpc)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if (talkData == null)
        {
            isAction = false;
            return;
        }
        
        if (isNpc)
        {
            talkText.text = talkData;

        }
        else
        {
            talkText.text = talkData;
        }
        isAction = true;
        talkIndex++;
    }
        */
}
