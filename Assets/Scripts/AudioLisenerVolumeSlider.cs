using UnityEngine;
using UnityEngine.UI;

public class AudioLisenerVolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _volumeSlider;

    private void OnEnable()
    {
        _volumeSlider.onValueChanged.AddListener(HandleVolumeChanged);
    }

    private void OnDisable()
    {
        _volumeSlider.onValueChanged.RemoveListener(HandleVolumeChanged);
    }

    private void HandleVolumeChanged(float volume)
    {
        AudioListener.volume = volume;  
        Debug.Log($"Громкость установлена на: {volume * 100}%");
    }
}
