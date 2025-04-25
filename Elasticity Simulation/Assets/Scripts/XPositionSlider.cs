using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class XPositionSlider : MonoBehaviour
{
    
    [SerializeField] Slider xSlider;
    [SerializeField] TMP_Text textField;
    [SerializeField] GameObject sphereObject;
    
    private void Start()
    {
        xSlider.minValue = -10f;
        xSlider.maxValue = 10f;
        xSlider.value = 0f;
        xSlider.onValueChanged.AddListener(OnSliderChange);

        //displays intial value of slider
        textField.SetText(xSlider.value.ToString());
    }

    //sets the text field to display the slider value on change
    public void OnSliderChange(float sliderValue)
    {
        sphereObject.transform.position = new Vector3(sliderValue, sphereObject.transform.position.y, sphereObject.transform.position.z);
        textField.SetText(sliderValue.ToString());
    }
}
