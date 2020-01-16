using UnityEngine;

public class Gate : MonoBehaviour
{
    public Attributes[] gives = new Attributes[] { };
    public Attributes[] removes = new Attributes[] { };
    // Start is called before the first frame update
    public Attributes[] toggles = new Attributes[] { };

    private void OnTriggerEnter(Collider other)
    {
        AttributeManager attributeManager = other.GetComponent<AttributeManager>();
        foreach (var item in gives)
        {
            attributeManager.attributes |= item;
        }
        foreach (var remove in removes)
        {
            attributeManager.attributes &= ~remove;
        }
        foreach (var toggle in toggles)
        {
            attributeManager.attributes ^= toggle;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
