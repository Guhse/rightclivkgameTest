using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.15f;
    public Vector3 offset;  

    private void LateUpdate() //Lateupdate kommt immer nach Update. Keinen Krieg um erste Ausführung. Fixed update geht auch
    {
        Vector3 zielPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, zielPosition, smoothSpeed); //Linear Interpolation - im groben smoothing movement?
        transform.position = smoothedPosition; //jetzige position = smoothed speed. Ergibt eine nachziehende Cam

        transform.LookAt(target);
    }
}
