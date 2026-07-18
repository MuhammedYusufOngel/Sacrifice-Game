using UnityEngine;

public class WeaponMaterial : MonoBehaviour
{
    private Material _weaponMaterial;
    void Start()
    {
        _weaponMaterial = GetComponent<Renderer>().material;
    }

    private void SetAmmoFill(float ratio)
    {
        _weaponMaterial.SetFloat("_Ammo_Fill", ratio);
    }

    // Update is called once per frame
    void Update()
    {
        float ratio = (float)PlayerManager.instance.GetCurrentAmmoForGun() / PlayerManager.instance.GetMaxAmmoForGun();
        
        if(ratio > 0.8f)
        {
            SetAmmoFill(1f);
        }
        else if(ratio > 0.6f)
        {
            SetAmmoFill(0.8f);
        }
        else if(ratio > 0.4f)
        {
            SetAmmoFill(0.6f);
        }
        else if(ratio > 0.2f)
        {
            SetAmmoFill(0.4f);
        }
        else if (ratio > 0f)
        {
            SetAmmoFill(0.2f);
        }
        else
        {
            SetAmmoFill(0f);
        }
    }


    void FixedUpdate()
    {

    }
}
