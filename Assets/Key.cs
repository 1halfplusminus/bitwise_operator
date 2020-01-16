using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Key : MonoBehaviour
{
    public Attributes[] opens = new Attributes[] { };
    // Start is called before the first frame update

    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<AttributeManager>().attributes |= GetMask();
        Destroy(gameObject);
    }

    Attributes GetMask()
    {
        Attributes mask = Attributes.Nothing;
        foreach (var item in opens)
        {
            mask |= item;
        }
        return mask;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
