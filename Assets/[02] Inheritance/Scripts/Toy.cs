using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : ToddlerInteractable
{
    public override void Activate()
    {
        Debug.Log("Toddler is playing");
    }
}
