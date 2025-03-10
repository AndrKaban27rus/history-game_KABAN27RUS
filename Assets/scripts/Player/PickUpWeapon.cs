using Unity.VisualScripting;
using UnityEngine;

public class PickUpWeapon : MonoBehaviour
{
    public GameObject camera;
    public float distance = 15f;
    GameObject currentWeapon;
    bool canPicUp;
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.E)) PicUp();
     if(Input.GetKeyDown(KeyCode.G)) Drop();
    }
    void PicUp()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, distance))
        {
            if (hit.transform.tag == "KnifeWeapon")
            {
                if (canPicUp) Drop();

                currentWeapon = hit.transform.gameObject;
                currentWeapon.AddComponent<Rigidbody>().isKinematic = true;
                currentWeapon.transform.parent = transform;
                currentWeapon.transform.localPosition = Vector3.zero;
                currentWeapon.transform.localEulerAngles = new Vector3(40f, 6.2f, 102.7f);
                canPicUp = true;

            }
        }
    }
        void Drop()
        {
            currentWeapon.transform.parent = null;
            currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
            canPicUp = false;
            currentWeapon = null;
        }
}
