using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Player localPlayer;

    void Awake(){
        GameManager.Instance.OnLocalPlayerJoined += HandleOnLocalPlayerJoined;;        
    }

    void HandleOnLocalPlayerJoined(Player player)
    {
        localPlayer=player;
    }
}
