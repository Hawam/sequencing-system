using UnityEngine;

// The subclass of Action that plays an audio clip with an AudioSource
public class AudioAction : Action
{
    // The game object with the AudioSource component
    public GameObject audioSourceObject;

    // The audio clip to play
    public AudioClip audioClip;

    // The flag to indicate if waiting for the audio is enabled
    public bool wait;

    // The AudioSource component reference
    private AudioSource audioSource;

    // The override method that performs the action
    public override void Execute()
    {
        // Get the AudioSource component from the game object
        audioSource = audioSourceObject.GetComponent<AudioSource>();

        // Play the audio clip with one shot mode
        audioSource.PlayOneShot(audioClip);
    }

    // The override method that returns true if the action is finished
    public override bool IsDone()
    {
        // Return true if waiting is disabled or if waiting is enabled and the audio is not playing
        return !wait || (wait && !audioSource.isPlaying);
    }
}
