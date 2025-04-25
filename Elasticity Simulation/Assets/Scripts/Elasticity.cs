using UnityEngine;

public class Elasticity : MonoBehaviour
{
    [SerializeField] GameObject sphereObject;

    float heightThreshold;

    public void Start()
    {
        heightThreshold = sphereObject.transform.position.y;
    }

    private void Update()
    {
        if(sphereObject.transform.position.y > heightThreshold) 
        {
            sphereObject.transform.position = new Vector3(sphereObject.transform.position.x, heightThreshold, sphereObject.transform.position.z);
        }
    }
}
