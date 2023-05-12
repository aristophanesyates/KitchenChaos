using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float movSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVec = Vector2.up * Input.GetAxisRaw("Vertical") + Vector2.right * Input.GetAxisRaw("Horizontal");
        Vector3 movVec = new Vector3(inputVec.x, 0, inputVec.y);
        transform.position += movVec.normalized * movSpeed * Time.deltaTime;
        Debug.Log(inputVec);
    }
}
