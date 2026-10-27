using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    static float volume = 1f;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void ResetVolume()
    {
        volume = 1f;
        AudioListener.volume = volume;
    }

    void Start()
    {
        if(volumeSlider != null)
        {
            volumeSlider.SetValueWithoutNotify(volume);
        }
        AudioListener.volume = volume;
    }

    public void ChangeVolume()
    {
        if(volumeSlider != null)
        {
            volume = volumeSlider.value;
            AudioListener.volume = volume;
        }
    }
}
