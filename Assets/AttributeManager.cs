using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Flags]
public enum Attributes
{
    Magic = 1 << 5,
    Intelligence = 1 << 4,
    Charisma = 1 << 3,
    Fly = 1 << 2,
    Insisible = 1,
    Nothing = 0,
    All = Magic | Insisible | Charisma | Fly | Insisible

};
public class AttributeManager : MonoBehaviour
{
    public Text attributeDisplay;
    public Attributes attributes = Attributes.Nothing;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        attributeDisplay.transform.position = screenPoint + new Vector3(0, -50, 0);
        attributeDisplay.text = Convert.ToString((int)attributes, 2).PadLeft(8, '0');
    }

}
