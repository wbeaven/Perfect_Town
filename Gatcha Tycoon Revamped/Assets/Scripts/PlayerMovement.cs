using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 10f, rotSpeed = 10f;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        CamRotation();
    }

    private void CamRotation()
    {
        if (Input.GetKey(KeyCode.Q)){
            transform.Rotate(new Vector3(0, -rotSpeed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, rotSpeed, 0) * Time.deltaTime);
        }
    }
}
