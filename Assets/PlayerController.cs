using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] float jumpForce = 200f;
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody = transform.GetComponent<Rigidbody>();
        if (rigidbody == null)
            Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector3(0f, jumpForce, 0f));
        }
    }
}
