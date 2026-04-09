using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public InputHandler actualInput;

    public List<PlayerController> playerControllers;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            actualInput.actualPlayer = playerControllers[0];
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
             actualInput.actualPlayer = playerControllers[1];
        }
    }
}
