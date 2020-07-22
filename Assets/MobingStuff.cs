using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobingStuff : MonoBehaviour
{

    Rigidbody mRigidBody;
    float direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        mRigidBody = GetComponent<Rigidbody>();
        AddANewForce();
        //mRigidBody.AddForce(0, 0, 100);
    }

    void AddANewForce()
    {
        //
        mRigidBody.AddForce(10 * direction, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        mRigidBody.velocity = Vector3.zero;
        direction = direction * -1;
    }
    // Update is called once per frame
    void Update()
    {
        AddANewForce();
    }
}
