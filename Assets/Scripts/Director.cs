using UnityEngine;

namespace DetectiveAI
{
    /**
     * AI-Driven Virtual Cinematography Director
     * This script manages Lighting, Cameras, and .wav audio triggers.
     */
    public class DetectiveDirector : MonoBehaviour
    {
        [SerializeField] private Light streetLamp;
        [SerializeField] private AudioSource noirAmbience;

        void Start()
        {
            // Initialize Noir Lighting Pipeline
            Debug.Log("System: Detective AI Cinematography Online.");
        }

        public void PlaySoundtrack(AudioClip clip)
        {
            // Trigger high-fidelity .wav files
            noirAmbience.PlayOneShot(clip);
        }
    }
}
