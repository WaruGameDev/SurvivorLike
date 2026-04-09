using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public PlayerController actualPlayer;    
    public Vector2 inputDirection;

    // Update is called once per frame
    void Update()
    {
        inputDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") ).normalized;      
        actualPlayer.Move(inputDirection);
    }
}
