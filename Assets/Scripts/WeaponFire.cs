using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    public Camera fpsCam;
    bool isShooting = false;

    public float range = 100f;
    public GameObject bullet;

    [Header("Sekme")]
    public WeaponRecoil weaponRecoil;
    
    CameraRecoil cameraRecoil;

    private void Awake()
    {
        if (transform.parent.parent.parent != null)
        {
            Debug.Log("transform.parent.parent.parent: " + transform.parent.parent.parent.name);

            cameraRecoil = transform.parent.parent.parent.parent.GetComponent<CameraRecoil>();
        }

    }

    void Start()
    {
        Debug.Log("Kod çalıştırıldı.");
        if (transform.parent.parent != null)
        {
            fpsCam = GetComponentInParent<Camera>();
            cameraRecoil = GetComponentInParent<CameraRecoil>();
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isShooting = true;
        }
    }

    private void FixedUpdate()
    {
        bool isInPlayer = PlayerManager.instance.GetIsInPlayer();

        if (isInPlayer)
        {
            if (isShooting)
            {
                Shoot();
                isShooting = false;
            }
        }
    }

    private void Shoot()
    {
        if(fpsCam != null)
        {
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);
            }

            Instantiate(bullet, hit.point, Quaternion.LookRotation(hit.normal));

            cameraRecoil.TriggerRecoil();
            weaponRecoil.TriggerWeaponRecoil();
        }

    }
}
