using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _volumeSlider;  
    [SerializeField] private AudioSource[] _audioSources;

    private void OnEnable()
    {
        _volumeSlider.onValueChanged.AddListener(HandleVolumeChanged);
    }

    private void OnDisable()
    {
        _volumeSlider.onValueChanged.RemoveListener(HandleVolumeChanged);
    }

    private void Start()
    {
        foreach (var audioSource in _audioSources) 
        {
            _volumeSlider.value = audioSource.volume;
        }
    }

    private void HandleVolumeChanged(float volume)
    {
        foreach (var audioSource in _audioSources)
        {
            audioSource.volume = volume;
        }

        Debug.Log($"Громкость установлена на: {volume * 100}%");
    }
}
 

