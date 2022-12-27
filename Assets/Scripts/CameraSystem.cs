using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{

    private int Speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MoveDir = new Vector3(0, 0, 0);

        if(Input.GetKey(KeyCode.Z)) MoveDir.z = +1f;
        if(Input.GetKey(KeyCode.S)) MoveDir.z = -1f;
        if(Input.GetKey(KeyCode.D)) MoveDir.x = +1f;
        if(Input.GetKey(KeyCode.Q)) MoveDir.x = -1f;

        transform.position += MoveDir * Speed * Time.deltaTime;
    }
}
