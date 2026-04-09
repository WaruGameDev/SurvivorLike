using UnityEngine;

public class TopDownCarController : PlayerController
{
    
    // Update is called once per frame
   public override void Move(Vector2 direction)
   {
        transform.Rotate(-transform.forward * direction.x);
        transform.Translate(transform.right * direction.y * Time.deltaTime);
    }
}
