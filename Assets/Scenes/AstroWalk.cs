using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroWalk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float horizontalInput;
    public float verticalInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward * Time.deltaTime * 20);
        transform.Translate(Vector3.right * Time.deltaTime * 40 * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * 40 * verticalInput);
    }
}