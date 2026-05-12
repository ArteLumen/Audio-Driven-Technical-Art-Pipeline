using UnityEngine;

namespace ArteLumen.Core
{
    public class AudioToVisualBridge : MonoBehaviour
    {
        public AudioSource audioSource;
        public Renderer cinematicObject;
        private float[] spectrumData = new float[256];

        [Header("Pipeline Settings")]
        [Range(0, 100)] public float intensityMultiplier = 50f;
        public string shaderPropertyName = "_EmissiveIntensity";

        void Update()
        {
            // 1. Get Spectrum Data from the .wav file
            audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.BlackmanHarris);

            // 2. Analyze the Bass frequency (Low-end)
            float bassValue = spectrumData[0] + spectrumData[1] + spectrumData[2];

            // 3. Technical Art: Map audio to a Shader Property
            float finalIntensity = bassValue * intensityMultiplier;
            cinematicObject.material.SetFloat(shaderPropertyName, finalIntensity);
        }
    }
}
