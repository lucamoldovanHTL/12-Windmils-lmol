using UnityEngine;
using UnityEngine.UI;

public class WindmillDynamicSpeed : MonoBehaviour
{
    [SerializeField] private Light lampLight; // Assign in Inspector
    [SerializeField] private float maxLightIntensity = 1f; // Maximum lamp brightness
    [SerializeField] private float maxRotationSpeed = 300f; // Maximum speed
    [SerializeField] private float acceleration = 50f; // Speed increase per second
    

    private float currentSpeed = 0f; // Current rotation speed
    private bool iod = false;
    public bool isinteractable = false;
    public Slider speedSlider;
    private void Update()
    {
        if (isinteractable)
        {
            // if slider is at min increase
            if (speedSlider.value == 0)
            {
                iod = false;
            }
            // if slider is at the max decrease
            if (speedSlider.value == 255)
            {
                iod = true;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                if (iod == false)
                {
                    currentSpeed += acceleration * Time.deltaTime;
                }
                else
                {
                    currentSpeed -= acceleration * Time.deltaTime;
                }
            }
        }

        // Clamp speed between 0 and maxRotationSpeed
        currentSpeed = Mathf.Clamp(currentSpeed, 0f, maxRotationSpeed);

        // Rotate the rotor hub
        transform.Rotate(Vector3.forward * currentSpeed * Time.deltaTime);

        if (speedSlider != null)
        {
            speedSlider.value = Mathf.Round(currentSpeed);
        }

        // Control light intensity based on speed
        if (lampLight != null)
        {
            lampLight.intensity = Mathf.Lerp(0f, maxLightIntensity, speedSlider.value / 255f);
        }
    }
}
