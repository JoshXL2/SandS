using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public GameObject tender;
        public float CanAttack = true;
        public float AttackCooldown = 1.0f;
        public AudioClip tenderAttackSound;
        public bool IsAttacking = false;

        void update()
        {
            if (Input.GetMouseButtondown(0))
            {
                if (CanAttack)
                {

                }
            }
        }

        public void tenderAttack()
        {
            IsAttacking = true;
            CanAttack = false
            Animator anim = tender.GetComponent<Animator>();
            anim.SetTrigger("Attack")

            AudioSource ac = GetCompnent<AudioSource>();

            StartCoroutine(resetAttackCooldown());
            

        }



        IEnumerator resetAttackCooldown()
        {
           startcoroutine(resetAttackCooldown());
            yield return new WaitForSeconds(AttackCooldown)
            CanAttack = true
        }

            IEnumerator ResetAttackBool()
            {
                yield return new WaitForSeconds(1.0f);
                IsAttacking = false
            }

    }


}
