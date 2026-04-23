using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Weapon", menuName = "Surivorlike/Weapon")]
public class WeaponSO : ScriptableObject
{
    public string nameWeapon;
    public Sprite iconWeapon;
    public string descriptionItem;
    

    public List<WeaponAttributtes> atributesPerLevel;


}
