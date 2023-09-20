using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AstroWalk : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    public Text wintext;
    public Text losetext;
    // Start is called before the first frame update
    void Start()
    {
        wintext.enabled = false;
        losetext.enabled = false;
    }
    private float horizontalInput;
    private float verticalInput;

    private bool isWin = false;
    private bool isLose = false;
    public GameObject Moon;

    private int counter = 0;
    // Update is called once per frame
    void Update()
    {
        if(!isWin && !isLose) {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.right * Time.deltaTime * 40 * horizontalInput);
            transform.Translate(Vector3.up * Time.deltaTime * 40 * verticalInput);
        }
        if(isWin) {
            transform.Rotate(Vector3.up * 50 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(items.Contains(collision.gameObject)) {
            Destroy(collision.gameObject);
            counter++;
        }

        if(collision.gameObject == Moon && counter == 9) {
            wintext.enabled = true;
            isWin = true;
        } else if(collision.gameObject == Moon && counter != 9) {
            losetext.enabled = true;
            this.gameObject.SetActive(false);
            isLose = true;
        }
    }
}