using System;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int actuallevel = 1;
    public float expToNextLevel= 100;
    public float currentExp=0;
    public Action onLevelUp;

    public GameObject particlesLevelUp;

    //Debug
    public List<WeaponSO> weaponSOs;
    public LevelUpPanel levelUpPanel;
    public Transform levelUpPanelContainer;

    public Transform weaponHolder;
    //public List<WeaponSO> currentWeapons;
    public List<WeaponBase> currentWeaponClass;

    void Awake()
    {
        instance = this;
    }
    public void AddWeapon(WeaponSO weaponToAdd)
    {
        GameObject weapon = Instantiate(weaponToAdd.weaponObject,weaponHolder);
        //currentWeapons.Add(weaponToAdd);
        weapon.GetComponent<WeaponBase>().LevelUpWeapon();
        currentWeaponClass.Add(weapon.GetComponent<WeaponBase>());
    }
    public WeaponBase GetWeapon(string weaponToLook)
    {
        foreach(WeaponBase w in currentWeaponClass)
        {
            if(w.currentWeapon.nameWeapon == weaponToLook)
            {
                return w;
            }
        }
        return null;
    }
    public void LevelUpWeapon(WeaponSO weaponSO)
    {
        if(GetWeapon(weaponSO.nameWeapon)== null)
        {
           AddWeapon(weaponSO);    
        }      
        else if (GetWeapon(weaponSO.nameWeapon)!= null)
        {
            foreach(WeaponBase w in currentWeaponClass)
            {
                if(w.currentWeapon.nameWeapon == weaponSO.nameWeapon)
                {
                    w.LevelUpWeapon();
                }
            }
        }                   
        
      
        CleanPanels();
    }

    public void AddExp(float exp)
    {
        currentExp += exp;
        if(currentExp >= expToNextLevel)
        {
            currentExp -= expToNextLevel;
            LevelUp();
        }
    }

    public void LevelUp()
    {
        actuallevel++;
        expToNextLevel += 100;
        onLevelUp?.Invoke();
        ShowParticlesLevelUp(PlayerManager.instance.actualInput.actualPlayer.transform.position);
        CleanPanels();
        

        foreach(var item in weaponSOs)
        {
            LevelUpPanel lvlUpPanel = Instantiate(levelUpPanel, levelUpPanelContainer);
            lvlUpPanel.SetUpInfo(item);
        }
    }
    public void CleanPanels()
    {
        foreach(Transform child in levelUpPanelContainer)
        {
            Destroy(child.gameObject);
        }
    }
    public void ShowParticlesLevelUp(Vector2 pos)
    {
        GameObject gameObject = Instantiate(particlesLevelUp, pos, Quaternion.identity);
        Destroy(gameObject, 2);
    }
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            LevelUp();
        }
    }

}
