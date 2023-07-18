using System.Collections;
using System.Collections.Generic;
using RPG.Movement;
using UnityEngine;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] float weaponRange = 5f;
        Transform target;
        public void Update()
        {
            bool isInRange = GetIsInRange();
            if (target != null) return;

            if (!GetIsInRange())
            {
                GetComponent<Mover>().MoveTo(target.position);
            }
            else
            {
                GetComponent<Mover>().Stop();
            }
        }
        private bool GetIsInRange()
        {
            return Vector3.Distance(transform.position, target.position) < weaponRange;
        }
        public void Attack(CombatTarget combatTarget)
        {
            target = combatTarget.transform;
            //Debug.Log("Bop bop!");
            //print("Bop bop!");
        }

        public void Cancel()
        {
            target = null;
        }
    }
}

