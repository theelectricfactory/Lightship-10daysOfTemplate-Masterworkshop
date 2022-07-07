// using System.Numerics;
// using System.Numerics;
// using System.Diagnostics;
// using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Niantic.ARDK.Utilities.Input.Legacy;

public class TouchGift : MonoBehaviour
{
 
    public GameObject rotationPoint;
    bool open = false;
    Quaternion finalRotation = Quaternion.Euler(0, 0, 0);
    void Start()
    {
        
    }

    void Update()
    {
        rotationPoint.transform.localRotation = Quaternion.Lerp(rotationPoint.transform.localRotation, finalRotation,.2f);
       
    }
    public bool InteractWithBox(Vector2 position){
            Ray ray = Camera.main.ScreenPointToRay( position );
            RaycastHit hit;

            bool interacted = false;
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                open = !open;
                if(open){
                    finalRotation = Quaternion.Euler(-70, 0, 0);
                }else{
                    finalRotation = Quaternion.Euler(0, 0, 0);
                }
                // Destroy(this.gameObject);
                // or 
                // this.gameObject.SetActive(false);
                interacted = true;
            }

            return interacted;
    }
}
