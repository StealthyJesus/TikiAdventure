using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SliderVolumeController : MonoBehaviour
{
    public UnityEngine.UI.Slider volumeSlider;
    public AudioSource audioSource;
    private bool isPaused;

    private void Start()
    {
        // Ensure the volume slider starts at the initial volume of the audio source
        volumeSlider.value = audioSource.volume;

        // Add a listener to the slider's value changed event
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    public void ChangeVolume(float volume)
    {
        // Update the volume of the audio source based on the slider value
        audioSource.volume = volume;
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void OnResumeButtonClick()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }
}
