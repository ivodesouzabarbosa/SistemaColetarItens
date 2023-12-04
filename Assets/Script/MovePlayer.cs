using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    private Vector3 playerVelocity;
    [SerializeField] Vector3 _move;
    [SerializeField] bool groundedPlayer;
    [SerializeField] float playerSpeed = 2.0f;
    [SerializeField] float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    PlayerPontos _playerPontos;


    void Start()
    {
        _playerPontos=Camera.main.GetComponent<PlayerPontos>();
    }

    // Update is called once per frame
    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        MoverPlayer();

        // Changes the height position of the player..
 

        Gravity();
    }

    public void SetMove(InputAction.CallbackContext value)
    {
        _move=value.ReadValue<Vector3>();
    }

    public void SetJump(InputAction.CallbackContext value)
    {
        if (groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
    }

    private void MoverPlayer()
    {
       //_move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(new Vector3(_move.x,0, _move.y) * Time.deltaTime * playerSpeed);

        
    }

    void Gravity()
    {
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {

            int valorPontos = other.GetComponent<Item>().Valor;
            _playerPontos.SomarPontos(valorPontos);
            other.GetComponent<Item>().DestroyItem();

        }
    }
}
