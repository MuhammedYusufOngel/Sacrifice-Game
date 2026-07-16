using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public GameObject weaponContainer;
    public GameObject Gun;
    public Camera fpsCam;
    public float range = 10f;
    public bool isInPlayer = false;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    public void Take()
    {
        if (Input.GetButtonDown("Take"))
        {
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                if(hit.transform.tag == "Gun")
                {
                    isInPlayer = true;
                    //Buraya ileride dikkat et
                    //Destroy(hit.transform.parent.parent.gameObject);

                    GameObject _gun = Instantiate(Gun, weaponContainer.transform);
                }
                Debug.Log(hit.transform.tag);
            }
        }
    }
    public bool GetIsInPlayer()
    {
        return isInPlayer;
    }

    private void FixedUpdate()
    {
    }

    private void Update()
    {
        Take();
    }
}
