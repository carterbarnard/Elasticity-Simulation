using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ElasticitySlider : MonoBehaviour
{
    //delcares Slider and TMP_Text refernce variables
    [SerializeField] Slider elasticitySlider;
    [SerializeField] TMP_Text textField;

    //assigns the Slider and TMP_Text components to reference variables
    private void Reset() 
    {
        elasticitySlider = GetComponent<Slider>();
        textField = GetComponent<TMP_Text>();
    }

    //sets min/max/initial value for slider
    //adds event listener for slider changes
    private void Start()
    {
        elasticitySlider.minValue = 0f;
        elasticitySlider.maxValue = 100f;
        elasticitySlider.value = 0f;
        elasticitySlider.onValueChanged.AddListener(OnSliderChange);
    }

    //sets the text field to display the slider value on change
    public void OnSliderChange(float sliderValue)
    {
        textField.SetText(sliderValue.ToString());
    }
}
