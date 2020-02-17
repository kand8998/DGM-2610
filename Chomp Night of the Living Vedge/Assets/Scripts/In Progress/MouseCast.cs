using UnityEngine;


public class MouseCast : Movement
{
    public Interactable focus;
    private Camera cam;
    
    private void Start()
    {
        cam = Camera.main;
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit))
            {
                RemoveFocus();
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit,100))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }
    }
    private void SetFocus(Interactable newFocus)
    {
        if (newFocus != focus)
        {
            if (focus !=null)
                focus.OnDefocused();
            
            focus = newFocus; 
        }
        newFocus.OnFocused(transform);
    }

    private void RemoveFocus()
    {
        if (focus !=null)
            focus.OnDefocused();
        
        focus = null;
       
    }
}