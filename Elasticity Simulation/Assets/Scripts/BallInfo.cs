using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallInfo : MonoBehaviour
{
    [SerializeField] TMP_Text maxHeightText;
    [SerializeField] TMP_Text currentHeightText;
    [SerializeField] TMP_Text currentXYText;
    [SerializeField] GameObject sphereObject;

    public float maxHeight;
    public bool hasBounced;
    
    public void Start() 
    {
        maxHeight = 0f;
        hasBounced = false;

        maxHeightText.SetText("Max Height: " + 0);
        currentHeightText.SetText("Current Height: " + 0);
        currentXYText.SetText("Current X/Y Pos: " + 0 + " / " + 0);
    }

    private void Update()
    {
        if(hasBounced == true)
        {
            if(sphereObject.transform.position.y > maxHeight) 
            {
            maxHeight = sphereObject.transform.position.y;
            }

            maxHeightText.SetText("Max Height: " + maxHeight);
        }

        currentHeightText.SetText("Current Height: " + sphereObject.transform.position.y);
        currentXYText.SetText("Current X/Y Pos: " + sphereObject.transform.position.x + " / " + sphereObject.transform.position.y);
    }

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("Ball has collided");
        hasBounced = true;
    }
}