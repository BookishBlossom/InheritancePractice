using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adult : ControllableCreature
{
    protected override void Interact()
    {
        Debug.Log("The Adult is interacting");
    }
}
