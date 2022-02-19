using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingSettings : MonoBehaviour
{

    PostProcessVolume vol;
    DepthOfField field;
    Vignette vig;
    void Start()
    {
        vol = GetComponent<PostProcessVolume>();
        vol.profile.TryGetSettings(out field);
        vol.profile.TryGetSettings(out vig);
    }

    void Update()
    {
        if (PlayerPrefs.GetFloat("timeslow") == 1)
        {
            field.focalLength.value = 200f ;
            vig.intensity.value = 0.4f;
        }
        else
        {
            field.focalLength.value = 1f;
            vig.intensity.value = 0f;
        }
    }
}
