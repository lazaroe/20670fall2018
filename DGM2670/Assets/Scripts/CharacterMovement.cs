using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour {
        
        private CharacterController controller;
        public MovePattern Pattern;
        
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update() {
            Pattern.Invoke(controller, transform);
            if (Input.GetButtonDown ("Fire1") && AmmoText.ammoAmount > 0)
            Fire ();
        }
   void OnTriggerEnter
    (Collider other)
{
    if (other.gameObject.CompareTag("PickUp"))
    {
        other.gameObject.SetActive(false);
    }
}
void Fire()
{
    AmmoText.ammoAmount -= 1;
}
}
//Character Controller
//Inheritance