using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimation : MonoBehaviour
{
    public Animator charAnimation;

    public float animationSpeed = 0f;
    private float horizontalMovement;
    private float verticalMovement;

    public void CharacterMovement()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

        Vector3 movementMagnitude = new Vector3(horizontalMovement, 0f, verticalMovement);
        float animationSpeed = Mathf.Clamp(movementMagnitude.magnitude, 0f, 0.8f);

        charAnimation.SetFloat("Speed", Mathf.Lerp(charAnimation.GetFloat("Speed"), animationSpeed, Time.deltaTime * 7f));
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
