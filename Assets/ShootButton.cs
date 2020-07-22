using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootButton : MonoBehaviour
{
    public LaserController laserController;
    public Camera ArCamera;
    bool canShoot = true;
    public void Shoot()
    {
        RaycastHit hit;
        laserController.ShowLaser();
        if (Physics.Raycast(ArCamera.transform.position, ArCamera.transform.forward, out hit, Mathf.Infinity))
        {
            //ConsoleScript.Log("User Hit Something");
            //print("did hit something");
            if (hit.transform.gameObject != null)
            {
                if (canShoot == true)
                {
                    //canShoot = false;
                    //energyChargerImage.fillAmount = 0;
                    GameObject hitObject = hit.transform.gameObject;

                    if (hitObject.tag == "ball")
                    {
                        Destroy(hitObject);
                    }
                    //NetworkIdentity hitNetworkIdentity = hitObject.GetComponent<NetworkIdentity>();
                    //Vector3 boundSize = planeImage.GetComponent<Renderer>().bounds.size;
                    //RpcDoOnSuccessHit(hitObject, hit.point);
                    //DoLaserEffect();
                    //CmdOnTapDetected(hitObject, hit.point, boundSize);
                }
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
