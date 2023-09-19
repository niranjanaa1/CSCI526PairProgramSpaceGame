using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroWalk : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {

    }
    private float horizontalInput;
    private float verticalInput;
    public GameObject Moon;

    private int counter = 0;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * 40 * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * 40 * verticalInput);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(items.Contains(collision.gameObject)) {
            Destroy(collision.gameObject);
            counter++;
        }

        if(collision.gameObject == Moon && counter == 9) {
            Debug.Log("You Win!!!");
            counter++;
        }
    }
}