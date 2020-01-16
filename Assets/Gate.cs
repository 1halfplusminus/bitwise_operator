using UnityEngine;

public class Gate : MonoBehaviour
{
    public Attributes[] gives = new Attributes[] { };
    public Attributes[] removes = new Attributes[] { };
    // Start is called before the first frame update

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
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
