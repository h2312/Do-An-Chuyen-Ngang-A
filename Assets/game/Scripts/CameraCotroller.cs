using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCotroller : MonoBehaviour
{
    //public PlayerMovement player;
    public Dichuyennhanvat player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position; //vi tri dau tien cua camera
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
