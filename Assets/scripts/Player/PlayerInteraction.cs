using UnityEngine;
using UnityEngine.ProBuilder.Shapes;
using TMPro;
public class PlayerInteraction : MonoBehaviour
{
    public Camera mainCam;
    public float InteractionDistance = 10f;
    public GameObject interactionUI;
    public TextMeshProUGUI interactionText;

    void Update()
    {
       InteractionRay();
    }
    void InteractionRay()
    {
        Ray ray = mainCam.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hit;
        bool hitSomething = false;
        if(Physics.Raycast(ray, out hit, InteractionDistance))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if(interactable != null)
            {
                hitSomething = true;    
                interactionText.text = interactable.GetDescription();

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                }
            }
        }
        interactionUI.SetActive(hitSomething);
    }
    
}
