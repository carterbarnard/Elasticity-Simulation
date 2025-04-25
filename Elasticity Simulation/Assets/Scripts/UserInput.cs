using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UserInput : MonoBehaviour
{

    [SerializeField] Button startButton;
    [SerializeField] Button resetButton;
    [SerializeField] GameObject sphereObject;

    BallInfo ballInfo;
    Rigidbody ballRB;
    Elasticity elasticity;

    public void Start()
    {
        ballInfo = sphereObject.GetComponent<BallInfo>();
        ballRB = sphereObject.GetComponent<Rigidbody>();
        startButton.onClick.AddListener(whenStartClicked);
        resetButton.onClick.AddListener(whenResetClicked);
    }

    public void whenStartClicked()
    {
        ballRB.isKinematic = false;
        //elasticity.Start();
    }

    public void whenResetClicked() 
    {
        ballRB.isKinematic = true;
        ballRB.linearVelocity = new Vector3(0f, 0f, 0f);
        ballRB.angularVelocity = new Vector3(0f, 0f, 0f); 
        sphereObject.transform.position = new Vector3(0f, 5f, 0f);
        ballInfo.Start();
        //elasticity.Start();
    }
}
