using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform PlayerBody;
    private float xRotation = 0;
    public float MouseSpeed = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleLook();
    }

    private void HandleLook()
    {
        float x = Input.GetAxis("Mouse X") * Time.deltaTime * MouseSpeed;
        float y = Input.GetAxis("Mouse Y") * Time.deltaTime * MouseSpeed;

        
        xRotation -= y;
        xRotation = Mathf.Clamp(xRotation, -60, 60);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        PlayerBody.Rotate(Vector3.up * x);

    }
    
}
