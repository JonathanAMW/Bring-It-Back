using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    private Vector2 move;
    [SerializeField] private GameObject m_player;

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void movePlayer()
    {
        Vector3 movement = new Vector3(move.x, 0f, move.y);

        m_player.transform.rotation = Quaternion.Slerp(m_player.transform.rotation, Quaternion.LookRotation(movement), 0.15f);

        m_player.transform.Translate(movement * playerSpeed * Time.deltaTime, Space.World);
    }

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }
    
}
