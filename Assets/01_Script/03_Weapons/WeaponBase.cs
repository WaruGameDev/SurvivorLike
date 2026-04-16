using UnityEngine;

public class WeaponBase : MonoBehaviour
{
    public float damage;
    public float projectileCount;
    public float sizeScale;
    public float fireRate = 1;
    private float currentFireRate = 0;
    public float projectileSpeed;
    
    public virtual void Shot()
    {
        
    }
    private void Update()
    {
        if(currentFireRate < fireRate)
        {
            currentFireRate += Time.deltaTime;
            if(currentFireRate >= fireRate)
            {
                Shot();   
                currentFireRate = 0;     
            }
        }
    }
}
