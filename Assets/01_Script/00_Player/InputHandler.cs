using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public PlayerController actualPlayer;    
    public Vector2 inputDirection;
    public Vector2 lastDirection = Vector2.right;

    // Update is called once per frame
    void Update()
    {
        inputDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") ).normalized;      
        actualPlayer.Move(inputDirection);
        if(inputDirection.magnitude > 0)
        {
            lastDirection = inputDirection;
        }
    }

    
}
