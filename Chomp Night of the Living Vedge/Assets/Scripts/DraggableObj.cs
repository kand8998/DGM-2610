using UnityEngine;

public class DraggableObj : MonoBehaviour
{
    private Vector3 offsetPosition;
    private float mouseZCoordinate;
    public Camera cam;
    public bool Draggable { get; set; }

    private void Start()
    {
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        Draggable = true;
        mouseZCoordinate = cam.WorldToScreenPoint(gameObject.transform.position).z;
        offsetPosition = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mouseZCoordinate;
        return cam.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + offsetPosition;
    }
}
