using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterController characterController;
    private Animator characterAnimator;

    [SerializeField]
    private Camera characterCamera;

    private float xRotation = 0f;
    private const int LEFT_CLICK = 0;
    private const int RIGHT_CLICK = 1;
    private const float GRAVITY = -9.81f;
    private Vector3 velocity;
    private float mouseSensitivity;
    private bool canDoubleJump;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        characterController = GetComponent<CharacterController>();
        characterAnimator = GetComponent<Animator>();
        mouseSensitivity = 150f;
        canDoubleJump = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        if (characterController.isGrounded)
        {
            characterAnimator.SetBool("jumping", false);
            canDoubleJump = true;
            if (Input.GetMouseButtonDown(LEFT_CLICK))
            {
                characterAnimator.SetBool("jumping", true);
                velocity.y = 3f;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(LEFT_CLICK) && canDoubleJump)
            {
                characterAnimator.SetBool("jumping", true);
                velocity.y = 2.5f;
                canDoubleJump = false;
            }
        }

        if (Input.GetMouseButton(RIGHT_CLICK))
        {
            Vector3 move = transform.forward;
            characterController.Move(move * Time.deltaTime);
        }
        if (Input.GetMouseButtonUp(RIGHT_CLICK))
        {
            characterAnimator.SetFloat("running", 0f);
            GameObject.Find("AudioManager").GetComponent<AudioManager>().Stop("running");
        }
        if (Input.GetMouseButtonDown(RIGHT_CLICK))
        {
            characterAnimator.SetFloat("running", 1f);
            GameObject.Find("AudioManager").GetComponent<AudioManager>().Play("running");
        }

        velocity.y += GRAVITY * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -30f, 30f);

        characterCamera.gameObject.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}
