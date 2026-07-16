using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    Camera fpsCam;
    bool isShooting = false;

    public float range = 100f;
    public GameObject bullet;

    [Header("Sekme")]
    public WeaponRecoil weaponRecoil;
    CameraRecoil cameraRecoil;
    void Start()
    {
        fpsCam = GetComponentInParent<Camera>();

        if(transform.parent.parent != null)
        {
            cameraRecoil = GetComponentInParent<CameraRecoil>();
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && transform.parent.parent != null)
        {
            isShooting = true;
        }
    }

    private void FixedUpdate()
    {
        if(isShooting)
        {
            Shoot();
            isShooting = false;
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }

        Instantiate(bullet, hit.point, Quaternion.LookRotation(hit.normal));

        cameraRecoil.TriggerRecoil();
        weaponRecoil.TriggerWeaponRecoil();
    }
}
