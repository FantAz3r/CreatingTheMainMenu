using UnityEngine;
using UnityEngine.UI;

public class ToggleMuter : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;
    [SerializeField] private AudioSource[] _audioSourses;

    protected void OnEnable()
    {
        _toggle.onValueChanged.AddListener(HandleToggleValueChanged);
    }

    protected void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(HandleToggleValueChanged);
    }

    private void HandleToggleValueChanged(bool isMuted)
    {
        foreach (var audioSource in _audioSourses)
        {
            if (isMuted)
            {
                audioSource.mute = true;
                Debug.Log("Звук отключен!");
            }
            else
            {
                audioSource.mute = false;
                Debug.Log("Звук включен!");
            }
        }
    }
}
