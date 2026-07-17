using UnityEngine;

public class HeadBob : MonoBehaviour
{
    [Header("Kafa Sallantisi Ayarlari")]
    public float bobSpeed = 14f;      // Adım atma hızı (koşarken artırılabilir)
    public float bobAmount = 0.05f;   // Sallantının dikey yüksekliği

    private float _timer = 0.0f;
    private float _defaultPosY = 0.0f;
    private CharacterController _controller;

    void Start()
    {
        _defaultPosY = transform.localPosition.y;
        _controller = GetComponentInParent<CharacterController>();
    }

    void Update()
    {
        Vector3 horizontalVelocity = new Vector3(_controller.velocity.x, 0, _controller.velocity.z);

        if (horizontalVelocity.magnitude > 0.1f && _controller.isGrounded)
        {
            float ratio = (float) PlayerManager.instance.GetMaxAmmoForGun() - PlayerManager.instance.GetCurrentAmmoForGun() + 1;

            _timer += Time.deltaTime * (bobSpeed + ratio);

            float newY = _defaultPosY + Mathf.Sin(_timer) * (bobAmount + ratio);
            transform.localPosition = new Vector3(transform.localPosition.x, newY, transform.localPosition.z);
        }
        else
        {
            _timer = 0;
            Vector3 targetPos = new Vector3(transform.localPosition.x, _defaultPosY, transform.localPosition.z);
            transform.localPosition = Vector3.Lerp(transform.localPosition, targetPos, Time.deltaTime * 8f);
        }
    }
}
