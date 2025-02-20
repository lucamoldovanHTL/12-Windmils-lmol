using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private Button[] buttons;
    [SerializeField] private GameObject[] windmills;
    private WindmillDynamicSpeed[] windmillScripts;
    [SerializeField] private Material plane;
    private Color color;

    void Start()
    {
        if (windmills.Length > 0)
        {
            windmillScripts = new WindmillDynamicSpeed[windmills.Length]; // Array initialisieren

            for (int i = 0; i < windmills.Length; i++)
            {
                if (windmills[i] != null)
                {
                    windmillScripts[i] = windmills[i].GetComponentInChildren<WindmillDynamicSpeed>();

                    if (windmillScripts[i] == null)
                    {
                        Debug.LogError("WindmillDynamicSpeed fehlt auf: " + windmills[i].name);
                    }
                }
                else
                {
                    Debug.LogError("windmills[" + i + "] ist null!");
                }
            }
        }

        SetActiveWindmill(0);
        SetButtonsInteractable(0);
    }

    private void Update()
    {
        // Update color of the plane based on windmill speeds
        color.r = windmillScripts[0].speedSlider.value / 255f;
        color.g = windmillScripts[1].speedSlider.value / 255f;
        color.b = windmillScripts[2].speedSlider.value / 255f;
        color.a = 1f;
        plane.SetColor("_Color", color);

        // Update button colors based on their interactable state
        foreach (Button button in buttons)
        {
            ColorBlock cb = button.colors;
            if (!button.enabled)
            {
                cb.normalColor = new Color32(68, 68, 68, 255);
            }
            else
            {
                cb.normalColor = new Color32(255, 255, 255, 255);
            }

            button.colors = cb;
        }
    }

    public void Button1()
    {
        SetActiveWindmill(1);
        SetButtonsInteractable(1);
    }

    public void Button2()
    {
        SetActiveWindmill(2);
        SetButtonsInteractable(2);
    }

    public void Button3()
    {
        SetActiveWindmill(3);
        SetButtonsInteractable(3);
    }

    private void SetActiveWindmill(int a)
    {
        if (a < 3 && a >= 0)
        {
            windmillScripts[a].isinteractable = true;

            // Disable other windmills
            for (int i = 0; i < windmillScripts.Length; i++)
            {
                if (i != a)
                {
                    windmillScripts[i].isinteractable = false;
                }
            }
        }
        else
        {
            // Disable all windmills if index is invalid
            foreach (var windmill in windmillScripts)
            {
                windmill.isinteractable = false;
            }
        }
    }

    private void SetButtonsInteractable(int a)
    {
        if (a < 3 && a >= 0)
        {
            buttons[a].enabled = true;

            // Disable other buttons
            for (int i = 0; i < buttons.Length; i++)
            {
                if (i != a)
                {
                    buttons[i].enabled = false;
                }
            }
        }
        else
        {
            // Disable all buttons if index is invalid
            foreach (var button in buttons)
            {
                button.enabled = false;
            }
        }
    }
}
