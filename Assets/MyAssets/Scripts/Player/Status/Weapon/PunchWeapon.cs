using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchWeapon : WeaponBase
{
    public override void Attack(Player player)
    {
        player.animator.SetTrigger("punch");
    }

    public override float GetDamage()
    {
        return 10f;
    }
}
