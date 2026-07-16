using UnityEngine;

public class WeaponSway : MonoBehaviour
{
    [Header("Sway Ayarlari")]
    public float swayAmount = 0.02f;   // Silahın ne kadar kayacağı
    public float maxSway = 0.06f;      // Maksimum kayma sınırı
    public float smoothAmount = 6f;    // Geçiş yumuşaklığı (büyük değer = daha hızlı tepki)

    private Vector3 _initialPosition;

    void Start()
    {
        // Silahın başlangıçtaki lokal pozisyonunu kaydet
        _initialPosition = transform.localPosition;
    }

    void Update()
    {
        // 1. Mouse girdilerini al
        float mouseX = Input.GetAxis("Mouse X") * swayAmount;
        float mouseY = Input.GetAxis("Mouse Y") * swayAmount;

        // 2. Sınırlandırma (Silahın ekrandan çıkıp gitmesini engeller)
        mouseX = Mathf.Clamp(mouseX, -maxSway, maxSway);
        mouseY = Mathf.Clamp(mouseY, -maxSway, maxSway);

        // 3. Hedef Pozisyon (Fare hareketinin tersi yönünde hedef belirliyoruz)
        Vector3 targetPosition = new Vector3(
            _initialPosition.x - mouseX,
            _initialPosition.y - mouseY,
            _initialPosition.z
        );

        // 4. Yumuşak geçiş (Lerp) ile silahı hedef pozisyona kaydır
        transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * smoothAmount);
    }
}
