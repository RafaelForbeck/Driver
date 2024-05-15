using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Player))]
public class PlayerWeapon : MonoBehaviour
{
    public Color selectedColor;
    List<WeaponBase> weapons;
    public List<Image> images;

    Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void Start()
    {
        player.currentWeapon = new PunchWeapon();

        weapons = new List<WeaponBase>();
        weapons.Add(new PunchWeapon());
        weapons.Add(new KickWeapon());
        weapons.Add(new HealingWeapon());

        ChangeWeapon(0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeWeapon(0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeWeapon(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeWeapon(2);
        }
    }

    public void ChangeWeapon(int weaponIndex)
    {
        ResetButtonsColor();
        images[weaponIndex].color = selectedColor;
        player.currentWeapon = weapons[weaponIndex];
    }

    void ResetButtonsColor()
    {
        foreach (var image in images) {
            image.color = Color.white;
        }
    }
}
