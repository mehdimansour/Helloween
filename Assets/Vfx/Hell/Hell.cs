using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.VFX;
using UnityEngine.Rendering.LWRP;

public class Hell : MonoBehaviour
{
    [SerializeField]
    private VisualEffect[] HellRef;

    [SerializeField]
    private ForwardRendererData CustomForwardRendererDataRef;

    private List<ScriptableRendererFeature> RendererFeaturesRef ;

    Blit NoiseRef;
    [SerializeField]
    private Material BlitMaterialRef;

    [SerializeField]
    [Range(0,1)]
    public float Rate;

    private void Start()
    {

        RendererFeaturesRef = CustomForwardRendererDataRef.rendererFeatures;
        NoiseRef = (Blit)RendererFeaturesRef[0];

    }
    void Update()
    {
        for(int i = 0; i < 3; i++)
        {

            HellRef[i].SetFloat("Rate", Rate * 64);

        }

        NoiseRef.settings.blitMaterial = BlitMaterialRef;
        BlitMaterialRef.SetFloat("_Hell_Intensity", Rate);

    }
}
