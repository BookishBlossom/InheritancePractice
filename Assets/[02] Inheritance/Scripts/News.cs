using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class News : AdultInteractable
{
    public override void Activate()
    {
        Debug.Log("Adult shouldn't read the news today");
    }
}
