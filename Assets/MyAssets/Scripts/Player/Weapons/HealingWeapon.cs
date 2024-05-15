using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingWeapon : WeaponBase
{
    public override void Attack(Player player)
    {
        player.animator.SetTrigger("healing");
    }

    public override float GetDamage()
    {
        return 20;
    }
}
