using UnityEngine;

public class KnifeAttack : MonoBehaviour
{
    private Animator animator;

    private int counter;

    void Start()
    {
        animator = GetComponentInParent<Animator>();
        counter = 0;
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(counter == 0)
            {
                animator.SetBool("isAttackingLeft", true);
                counter++;
            }
            else if(counter == 1)
            {
                animator.SetBool("isAttackingRight", true);
                counter--;
            }

            Debug.Log("counter: " + counter);
        }
        else
        {
            animator.SetBool("isAttackingLeft", false);
            animator.SetBool("isAttackingRight", false);
        }
    }
}
