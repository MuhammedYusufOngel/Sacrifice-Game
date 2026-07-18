using UnityEngine;
using UnityEngine.UI;

public class WeaponState : MonoBehaviour
{
    public Image crosshair;
    private Camera camera;

    void Start()
    {
        camera = GetComponentInParent<Camera>();
    }

    void Update()
    {
        if(PlayerManager.instance.isAimOpen)
        {
            transform.localPosition = new Vector3(0.5f, -0.4f, 1.5f);
            transform.localRotation = Quaternion.Euler(new Vector3(0f, 90f, 0f));
            crosshair.gameObject.SetActive(true);
            camera.fieldOfView = 40f;
        }
        else
        {
            transform.localPosition = new Vector3(0.1f, -0.8f, 1.5f);
            transform.localRotation = Quaternion.Euler(new Vector3(0f, 75f, 25f));
            crosshair.gameObject.SetActive(false);
            camera.fieldOfView = 60f;
        }
    }
}
