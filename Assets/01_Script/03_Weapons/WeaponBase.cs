using UnityEngine;
[System.Serializable]
public class WeaponAttributtes
{
    public float damage;
    public float projectileCount;
    public float sizeScale;
    public float fireRate = 1;    
    public float projectileSpeed;    
}

public class  WeaponBase : MonoBehaviour
{
    public WeaponAttributtes currentWeaponAttributtes;
    public WeaponSO currentWeapon;
    public float currentFireRate = 0;
    public int currentLevel = 0;

    public void LevelUpWeapon()
    {
        currentLevel ++;
        currentWeaponAttributtes = currentWeapon.atributesPerLevel[currentLevel];
    }

    public virtual void Shot()
    {
        
    }
    private void Update()
    {
        if(currentFireRate < currentWeaponAttributtes.fireRate)
        {
            currentFireRate += Time.deltaTime;
           
        }
        if(currentFireRate >= currentWeaponAttributtes.fireRate && currentLevel >0)
        {
            Shot();   
            currentFireRate = 0;     
        }
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            LevelUpWeapon();
        }
    }
}
