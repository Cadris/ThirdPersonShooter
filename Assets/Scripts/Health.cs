using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : Destructable
{
    public override void Die()
    {
        base.Die();

        print("We Died.");        
    }

    public override void TakenDamage(float amount)
    {        
        base.TakenDamage(amount);
        print("Remaining: "+HitPointsRemaining);
    }
}
