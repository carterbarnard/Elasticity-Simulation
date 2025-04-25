using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class YPositionSlider : MonoBehaviour
{
    
    [SerializeField] Slider ySlider;
    [SerializeField] TMP_Text textField;
    [SerializeField] GameObject sphereObject;
    
    private void Start()
    {
        ySlider.minValue = 0f;
        ySlider.maxValue = 10f;
        ySlider.value = 5f;
        ySlider.onValueChanged.AddListener(OnSliderChange);

        //displays intial value of slider
        textField.SetText(ySlider.value.ToString());
    }

    //sets the text field to display the slider value on change
    public void OnSliderChange(float sliderValue)
    {
        sphereObject.transform.position = new Vector3(sphereObject.transform.position.x, sliderValue, sphereObject.transform.position.z);
        textField.SetText(sliderValue.ToString());
    }
}
