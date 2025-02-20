using UnityEngine;

public class RadioVolumeController : MonoBehaviour {
    public Transform player;  // Assign the Player in Inspector
    private AudioSource audioSource;

    public float maxVolume = 0.20f;  // Max volume when close
    public float minVolume = 0.1f;  // Min volume when far
    public float maxDistance = 10f; // Max hearing distance

    void Start() {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = minVolume; // Start with low volume
    }

    void Update() {
        float distance = Vector3.Distance(player.position, transform.position);

        // Normalize volume based on distance (closer = louder)
        float volume = Mathf.Lerp(maxVolume, minVolume, distance / maxDistance);
        audioSource.volume = Mathf.Clamp(volume, minVolume, maxVolume);
    }
}
