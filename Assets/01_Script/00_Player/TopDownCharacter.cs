using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class TopDownCharacter : PlayerController
{
    public override void Move(Vector2 direction)
    {
        rb.linearVelocity = direction * speed;
    }
}
