using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to manage the Player Movement
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    #region PUBLIC FIELDS
    public float Speed = 12f;
    #endregion // Public Fields
    //
    #region PRIVATE FIELDS
    private CharacterController m_CharacterController;
    #endregion // Private Fields
    //
    #region MONOBEHAVIOUR METHODS
    // Start is called before the first frame update
    void Start()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        // Input from Joystick/Keyboard
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Define the direction where the player has to move.
        Vector3 move = transform.right * x + transform.forward * z;

        // Give speed per frame to the directional movement.
        if (m_CharacterController.enabled) m_CharacterController.Move(move * Speed * Time.deltaTime);
    }
    #endregion // Monobehaviour Methods
}
