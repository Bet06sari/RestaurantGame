using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Animator animPlayer;
    private player _player;
    public void ChineseButton()
    {
        if (player.instance._currentName=="c")
        {
            Debug.Log("t");
            
            animPlayer.SetTrigger("isTrue");
            
        }
        else
        {
            Debug.Log("f");
            animPlayer.SetTrigger("isFalse");
        }
    }
    public void MexicoButton()
    {
        if (player.instance._currentName=="m")
        {
            Debug.Log("t");
            animPlayer.SetTrigger("isTrue");
            
        }
        else
        {
            Debug.Log("f");
            animPlayer.SetTrigger("isFalse");
        }
    }
    public void ItalyButton()
    {
        if (player.instance._currentName=="i")
        {
            Debug.Log("t");
            animPlayer.SetTrigger("isTrue");
            
        }
        else
        {
            Debug.Log("f");
            animPlayer.SetTrigger("isFalse");
        }
    }
}
