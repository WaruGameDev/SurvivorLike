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
    public List<WeaponBase> currentWeapons;

    void Awake()
    {
        instance = this;
    }
    public void AddWeapon(WeaponSO weaponToAdd)
    {
        GameObject weapon = Instantiate(weaponToAdd.weaponObject,weaponHolder);
        currentWeapons.Add(weapon.GetComponent<WeaponBase>());
        weapon.GetComponent<WeaponBase>().LevelUpWeapon();
    }
    public void LevelUpWeapon(WeaponSO weaponSO)
    {
        if(!currentWeapons.Contains(weaponSO.weaponObject.GetComponent<WeaponBase>()))
        {
            AddWeapon(weaponSO); 
                       
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
