using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildScript : ParentScript
{
    public bool hasJoyousWhimsy;

    protected override void Message()
    {
        Debug.Log("wow!");
    }
}
