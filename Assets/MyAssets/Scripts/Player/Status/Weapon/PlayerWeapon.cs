using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public Player player;

    public List<WeaponBase> weapons;

    private void Start()
    {
        weapons = new List<WeaponBase>();

        weapons.Add(new PunchWeapon());
        weapons.Add(new KickWeapon());

        player.currentWeapon = weapons.First();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player.currentWeapon = weapons[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            player.currentWeapon = weapons[1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            player.currentWeapon = weapons[2];
        }
    }
}
