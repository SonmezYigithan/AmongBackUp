using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Transform Character;
    [SerializeField] InputAction WASD;
    [SerializeField] float speed = 1f;
    Vector2 MovementInput;
    Animator CharacterAnim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Character = transform.GetChild(0);
        CharacterAnim = transform.GetChild(0).GetComponent<Animator>();
    }

    void OnEnable()
    {
        WASD.Enable();
    }

    void OnDisable()
    {
        WASD.Disable();
    }

    void Update()
    {
        MovementInput = WASD.ReadValue<Vector2>();
        if(MovementInput.x != 0)
        {
            Character.localScale = new Vector2(Mathf.Sign(MovementInput.x), 1);
        }
        CharacterAnim.SetFloat("Speed", MovementInput.magnitude);
    }

    private void FixedUpdate()
    {
        //fixed updateten biraz daha hızlı çalışıyor
        rb.velocity = MovementInput * speed;
    }
}
