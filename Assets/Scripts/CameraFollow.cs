using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;
    public float smoothSped = 0.125f;
    public Vector3 offset;
    void FixedUpdate()
    {
        Vector3 desiredPossition = target.position + offset;
        Vector3 smoothPossiton = Vector3.Lerp(transform.position, desiredPossition, smoothSped);
        transform.position = smoothPossiton;
    }



}
