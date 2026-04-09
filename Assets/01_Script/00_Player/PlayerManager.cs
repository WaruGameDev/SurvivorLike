using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public InputHandler actualInput;

    public List<PlayerController> playerControllers;

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
