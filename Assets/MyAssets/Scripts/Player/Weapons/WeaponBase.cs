using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase
{
    public abstract float GetDamage();
    public abstract void Attack(Player player);
}
