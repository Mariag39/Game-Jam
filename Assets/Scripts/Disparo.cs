using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public int m_PlayerNumber = 1;              // Used to identify the different players.
    public GameObject m_Shell;                   // Prefab of the shell.
    public Transform m_FireTransform;           // A child of the tank where the shells are spawned.
    public float m_LaunchForce = 15f;
    public float fireRate = 1f;
    public PlayerMovement pm;
    private string m_FireButton;                // The input axis that is used for launching shells.
    private bool m_Fired = true;                       // Whether or not the shell has been launched with this button press.
    private float nextFireTime;
    int num = 1;
    private void OnEnable() {}

    private void Start() {
        // The fire axis is based on the player number.
        m_FireButton = "Fire" + m_PlayerNumber;
    }

    private void Update() {
        if (!m_Fired) {
            Fire(m_LaunchForce, fireRate);
        }
        // Otherwise, if the fire button has just started being pressed...
        if (Input.GetButtonDown(m_FireButton)) {
            m_Fired = false;
        }
        // Otherwise, if the fire button is being held and the shell hasn't been launched yet...
        else if (Input.GetButton(m_FireButton) && !m_Fired) {
            //Fire(m_LaunchForce, fireRate);
            m_Fired = false;
        }
        // Otherwise, if the fire button is released and the shell hasn't been launched yet...
        else if (Input.GetButtonUp(m_FireButton) && !m_Fired) {
            //Fire(m_LaunchForce, fireRate);
            m_Fired = false;

        }

        if (pm.threeshoot)
        {
            num = 3;
        }else num = 1;
    }

    public void Fire(float launchForce, float fireRate) {
        if (Time.time > nextFireTime) {
            nextFireTime = Time.time + fireRate;
            // Set the fired flag so only Fire is only called once.
            m_Fired = true;
            
            // Create an instance of the shell and store a reference to it's rigidbody.
            for (int i = 0; i < num; i++)
            {
                GameObject shellInstance = Instantiate(m_Shell, m_FireTransform.position, m_FireTransform.rotation) as GameObject;
                shellInstance.GetComponent<Rigidbody>().velocity = m_LaunchForce * m_FireTransform.forward;
            }

            // Set the shell's velocity to the launch force in the fire position's forward direction.
            
           
        }
    }
}