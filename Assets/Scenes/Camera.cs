using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    private Vector3 offset = new Vector3(-35, 8, -46);
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
