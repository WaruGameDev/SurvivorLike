using UnityEngine;
using UnityEngine.Jobs;

public class Katana : WeaponBase
{
    public KatanaProjectile katanaProjectile;

    public override void Shot()
    {
        Vector2 direction = PlayerManager.instance.actualInput.lastDirection;      

        KatanaProjectile projectile = Instantiate(katanaProjectile, transform.position,Quaternion.Euler(direction) );
        projectile.direction = direction;
    }
}
