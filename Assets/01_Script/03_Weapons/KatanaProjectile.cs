using UnityEngine;

public class KatanaProjectile : Projectile
{    
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
