using UnityEngine;

public class CameraRecoil : MonoBehaviour
{
    private Vector3 currentRotation;
    private Vector3 targetRotation;

    [Header("Sekme Gücü Ayarları")]
    public float recoilX = -2f;
    public float recoilY = 1f;
    public float recoilZ = 0.5f;

    [Header("Zamanlama Ayarları")]
    public float snappiness = 6f;
    public float returnSpeed = 2f;

    [Header("Kamera Ayarları")]
    public float sensitivity;
    private float xRotation = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void FixedUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;


        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);

        Vector3 xRotationVector = new Vector3(xRotation, 0.0f, 0.0f);

        targetRotation = Vector3.Lerp(targetRotation, Vector3.zero, returnSpeed * Time.deltaTime);
        currentRotation = Vector3.Slerp(currentRotation, targetRotation, snappiness * Time.deltaTime);

        transform.localRotation = Quaternion.Euler(currentRotation + xRotationVector);
        transform.parent.Rotate(Vector3.up * mouseX);
    }

    public void TriggerRecoil()
    {
        targetRotation += new Vector3(
            recoilX,
            Random.Range(-recoilY, recoilY),
            Random.Range(-recoilZ, recoilZ)
        );
    }
}
