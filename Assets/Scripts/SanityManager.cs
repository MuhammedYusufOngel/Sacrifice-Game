using UnityEngine;

public class SanityManager : MonoBehaviour
{
    public static SanityManager instance;
    public float currentSanity = 100f;
    public void ReduceSanity(float amount)
    {
        currentSanity -= amount;
        Debug.Log("Akıl sağlığı azaldı: " + currentSanity);
    }
}
