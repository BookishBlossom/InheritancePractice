using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentScript : MonoBehaviour
{
    public string squareName;
    public float speed;
    public int ammo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Message();
        }
    }

    protected virtual void Message()
    {
        Debug.Log("Wow it's words!");
    }
}
