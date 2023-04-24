using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerup/SlowZone")]

public class SlowZone : PowerupEffect
{
  public float amount;

  public override void Apply(GameObject target) 
  {
    target.GetComponent<RubyController>().speed-= amount;
  }
}
