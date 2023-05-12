using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float movSpeed = 1;
    [SerializeField]
    private float rotSpeed = 1;
    private bool isWalking;
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
        transform.forward = Vector3.Slerp(transform.forward, movVec, rotSpeed * Time.deltaTime);

        Debug.Log(inputVec);
        isWalking = movVec != Vector3.zero;
    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
