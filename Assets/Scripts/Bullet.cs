using UnityEngine;

public class Bullet : MonoBehaviour
{
    float elapsedTime = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime > 0.5f)
        {
            Destroy(gameObject);
        }
    }
}
