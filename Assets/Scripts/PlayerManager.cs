using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public GameObject weaponContainer;
    public GameObject Gun;
    public Camera fpsCam;
    public float range = 10f;
    
    public bool isInPlayer = false;
    public bool isAimOpen = false;

    [Header("Mermi Ayarlar�")]
    [SerializeField] private int maxAmmo_Gun = 30;
    private int currentAmmo_Gun;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    public int GetCurrentAmmoForGun()
    {
        return currentAmmo_Gun;
    }

    public int GetMaxAmmoForGun()
    {
        return maxAmmo_Gun;
    }

    public void DecreaseCurrentAmmoForGun()
    {
        currentAmmo_Gun--;
        Debug.Log("currentAmmo_Gun/maxAmmo_Gun: " + currentAmmo_Gun + "/" + maxAmmo_Gun);
    }

    public void Take()
    {
        isInPlayer = true;

        //if (Input.GetButtonDown("Take"))
        //{
        //    RaycastHit hit;
        //    if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        //    {
        //        if(hit.transform.tag == "Gun")
        //        {
        //            isInPlayer = true;
        //            //Buraya ileride dikkat et
        //            //Destroy(hit.transform.parent.parent.gameObject);

        //            GameObject _gun = Instantiate(Gun, weaponContainer.transform);
        //        }
        //        Debug.Log(hit.transform.tag);
        //    }
        //}
    }
    public bool GetIsInPlayer()
    {
        return isInPlayer;
    }
    public void Aim()
    {
        // if(Input.GetButton("Fire2") && isInPlayer)
        // {
        //     isAimOpen = true;
        // }
        // else
        // {
        //     isAimOpen = false;
        // }
    }
    
    void Update()
    {
        Take();
        Aim();
    }

    private void FixedUpdate()
    {
        
    }

    void Start()
    {
        currentAmmo_Gun = maxAmmo_Gun;
    }
}
