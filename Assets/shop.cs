using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public RectTransform uiBox;

    Player enterPlayer;
   
    public void Enter()
    {
        enterPlayer = enterPlayer;
        uiBox.anchoredPosition = Vector3.zero;
    }

    
    public void Exit()
    {
        uiBox.anchoredPosition = Vector3.down*1000;
    }
}
