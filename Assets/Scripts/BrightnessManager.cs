using UnityEngine;
using UnityEngine.UI;

public class BrightnessManager : MonoBehaviour
{
    [SerializeField] Slider brightnessSlider;
    [SerializeField] Image blackScreen;
    static float brightness = 1f;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void ResetBrightness()
    {
        brightness = 1f;
    }

    void Start()
    {
        if (brightnessSlider != null)
        {
            brightnessSlider.SetValueWithoutNotify(brightness);
        }
        SetBrightness();
    }

    public void ChangeBrightness()
    {
        if (brightnessSlider != null)
        {
            brightness = brightnessSlider.value;
            SetBrightness();
        }
    }

    void SetBrightness()
    {
            Color color = blackScreen.color;
            color.a = 1f - brightness;
            blackScreen.color = color;
    }
}
