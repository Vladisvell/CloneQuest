using UnityEngine;

public class AudioToggle : MonoBehaviour
{
    public void ToggleMusic() { AudioControl.Instance.Music = AudioControl.Instance.Music == 0f ? 1f : 0f; }
    public void ToggleSound() { AudioControl.Instance.Sound = AudioControl.Instance.Sound == 0f ? 1f : 0f; }
}
