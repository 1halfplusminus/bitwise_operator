using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public Attributes[] checks = new Attributes[] { };

    void OnCollisionEnter(Collision collision)
    {
        Attributes mask = GetMask();
        if ((collision.gameObject.GetComponent<AttributeManager>().attributes & mask) == mask)
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        GetComponent<BoxCollider>().isTrigger = false;
        Attributes mask = GetMask();
        other.gameObject.GetComponent<AttributeManager>().attributes &= ~mask;
    }

    Attributes GetMask()
    {
        Attributes mask = Attributes.Nothing;
        foreach (var item in checks)
        {
            mask |= item;
        }
        return mask;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DebugFlag(Attributes attributes)
    {
        Debug.Log(Convert.ToString((int)attributes, 2).PadLeft(8, '0'));
    }
}
