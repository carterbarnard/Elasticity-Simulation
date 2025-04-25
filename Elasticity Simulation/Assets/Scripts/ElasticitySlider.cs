using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ElasticitySlider : MonoBehaviour
{
    //delcares Slider and TMP_Text reference variables
    [SerializeField] Slider elasticitySlider;
    [SerializeField] TMP_Text textField;
    [SerializeField] TMP_Text currentElasticPrcnt;
    [SerializeField] GameObject sphereObject;

    PhysicsMaterial elasticityMaterial;

    //sets min/max/initial value for slider
    //adds event listener for slider changes
    private void Start()
    {
        //assigns Collider object to reference variable
        Collider collider = sphereObject.GetComponent<Collider>();

        //assigns collider physics material to reference variable
        elasticityMaterial = collider.material;

        elasticitySlider.minValue = 0f;
        elasticitySlider.maxValue = 100f;
        elasticitySlider.value = 100f;
        elasticitySlider.onValueChanged.AddListener(OnSliderChange);

        //displays intial value of slider
        textField.SetText(elasticitySlider.value.ToString());
        currentElasticPrcnt.SetText("Elasticity %: " + elasticitySlider.value.ToString());
    }

    //sets the text field to display the slider value on change
    public void OnSliderChange(float sliderValue)
    {
        elasticityMaterial.bounciness = (sliderValue / 100);  
        textField.SetText(sliderValue.ToString());
        currentElasticPrcnt.SetText("Elasticity %: " + sliderValue.ToString());
    }
}
