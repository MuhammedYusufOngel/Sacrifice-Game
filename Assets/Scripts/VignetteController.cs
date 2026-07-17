using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal; // URP kullanıyorsan bu satır şart

public class VignetteController : MonoBehaviour
{
    public static VignetteController instance;

    [Header("Post Processing Ayarları")]
    [SerializeField] private Volume globalVolume;
    private Vignette vignette;

    [Header("Vinyet Şiddeti")]
    [Range(0f, 1f)]
    [SerializeField] private float maxVignetteIntensity = 0.65f; 

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    void Start()
    {
        if (globalVolume.profile.TryGet<Vignette>(out vignette))
        {
            vignette.intensity.overrideState = true;
        }
        else
        {
            Debug.LogError("Volume profilinde Vignette efekti bulunamadı!");
        }
    }

    public void UpdateVignette()
    {
        if (vignette == null) return;

        float ammoRatio = (float)PlayerManager.instance.GetCurrentAmmoForGun() / PlayerManager.instance.GetMaxAmmoForGun();

        float targetIntensity = (1f - ammoRatio) * maxVignetteIntensity;

        // An�nda de�i�mek yerine yumu�ak bir ge�i� istersen buray� Update i�inde Lerp ile de g�ncelleyebilirsin.
        vignette.intensity.value = targetIntensity;
    }
}
