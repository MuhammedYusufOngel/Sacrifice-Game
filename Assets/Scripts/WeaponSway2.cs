using UnityEngine;

public class WeaponSway2 : MonoBehaviour
{
    public float swayAmount = 0.2f;
    public float smooth = 6f;

    private Quaternion targetRotation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * swayAmount;
        float mouseY = Input.GetAxis("Mouse Y") * swayAmount;

        Quaternion rotationX = Quaternion.AngleAxis(-mouseY, Vector3.right);
        Quaternion rotationZ = Quaternion.AngleAxis(mouseX, Vector3.forward);

        targetRotation = rotationX * rotationZ;
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }
}
