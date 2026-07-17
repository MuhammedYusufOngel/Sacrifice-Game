using TMPro;
using UnityEngine;

public class WeaponRecoil : MonoBehaviour
{
    private Vector3 currentPosition;
    private Vector3 targetPosition;

    private Vector3 currentRotation;
    private Vector3 targetRotation;

    [Header("Pozisyonel Geri Tepme (Kickback)")]
    [SerializeField] private float kickbackZ = -0.2f;
    [SerializeField] private float kickbackY = 0.05f;

    [Header("Rotasyonel Şahlanma")]
    [SerializeField] private float rotationX = -5f;

    [Header("Hız Ayarları")]
    [SerializeField] private float snappiness = 10f;
    [SerializeField] private float returnSpeed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        targetPosition = Vector3.Lerp(targetPosition, Vector3.zero, returnSpeed * Time.deltaTime);
        targetRotation = Vector3.Lerp(targetRotation, Vector3.zero, returnSpeed * Time.deltaTime);

        currentPosition = Vector3.Lerp(currentPosition, targetPosition, snappiness * Time.deltaTime);
        currentRotation = Vector3.Slerp(currentRotation, targetRotation, snappiness * Time.deltaTime);

        transform.localPosition = currentPosition;
        transform.localRotation = Quaternion.Euler(currentRotation);
    }

    private void FixedUpdate()
    {

    }

    public void TriggerWeaponRecoil()
    {
        targetPosition += new Vector3(0, kickbackY, kickbackZ);
        targetRotation += new Vector3(rotationX, 0, 0);
    }
}
