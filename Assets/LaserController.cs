using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{

    public GameObject laserShow;
    Renderer laserMaterial;
    bool showLaserBool;
    float counter = 0;

    void LaserActive(bool pActive)
    {
        laserShow.SetActive(pActive);
        showLaserBool = pActive;
    }

    public void ShowLaser()
    {
        LaserActive(true);
        counter = 0;
    }

    public void HideLaser()
    {
        LaserActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {    
        showLaserBool = false;
        laserMaterial = laserShow.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        print(showLaserBool);
        if (showLaserBool == true)
        {
            counter += Time.deltaTime;

            if (counter >= 2f)
            {
                HideLaser();
            }
        }
    }
}
