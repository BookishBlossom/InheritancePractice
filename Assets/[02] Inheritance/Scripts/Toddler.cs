using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toddler : ControllableCreature
{
    protected override void Interact()
    {
        Debug.Log("The Toddler is interacting");
    }
}
