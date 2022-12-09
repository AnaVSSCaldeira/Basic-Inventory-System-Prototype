using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public Transform target;
    public GameObject player;

    void FixedUpdate()
    {
        if(player != null)
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        }
    }

}

