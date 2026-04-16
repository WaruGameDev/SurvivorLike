using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelUpPanel : MonoBehaviour
{
    public Image iconLevelUp;
    public TextMeshProUGUI nameItemLevelUp;
    public TextMeshProUGUI descriptionItemLevelUp;
    //mejoras

    public void SetUpInfo(WeaponSO weaponSO)
    {
        iconLevelUp.sprite = weaponSO.iconWeapon;
        nameItemLevelUp.text = weaponSO.nameWeapon;
        descriptionItemLevelUp.text = weaponSO.descriptionItem;
    }

    
}
