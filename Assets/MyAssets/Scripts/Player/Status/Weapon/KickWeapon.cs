using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickWeapon : WeaponBase
{
    public override void Attack(Player player)
    {
        player.animator.SetTrigger("kick");
    }

    public override float GetDamage()
    {
        return 20f;
    }
}