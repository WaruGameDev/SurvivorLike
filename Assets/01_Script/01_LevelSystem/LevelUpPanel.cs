using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelUpPanel : MonoBehaviour
{
    public Image iconLevelUp;
    public TextMeshProUGUI nameItemLevelUp;
    public TextMeshProUGUI descriptionItemLevelUp;
    public Button levelUpButton;
    public WeaponSO actualWeapon;
    //mejoras

    public void SetUpInfo(WeaponSO weaponSO)
    {
        actualWeapon = weaponSO;
        iconLevelUp.sprite = weaponSO.iconWeapon;
        nameItemLevelUp.text = weaponSO.nameWeapon;
        descriptionItemLevelUp.text = weaponSO.descriptionItem;
        
    }
    public void LevelUpWeapon()
    {
        LevelManager.instance.LevelUpWeapon(actualWeapon);
    }

    
}
