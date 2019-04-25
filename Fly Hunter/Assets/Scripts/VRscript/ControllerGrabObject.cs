using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class ControllerGrabObject : MonoBehaviour {

    public SteamVR_Input_Sources handType;
    public SteamVR_Behaviour_Pose controllerPose;
    public SteamVR_Action_Boolean grabAction;

    public SteamVR_Action_Boolean useAction;
    private bool objectSelect = false;

    private GameObject collidingObject; // 1
    private GameObject objectInHand; // 2





    public sabreLaser sabre;

    private void Start()
    {
        sabre = GetComponent<sabreLaser>();
    }

    // Update is called once per frame
    void Update () {

        // 1
        if (grabAction.GetLastStateDown(handType))
        {
            if (collidingObject)
            {
                GrabObject();
                objectSelect = true;
               
            }
        }

        // 2
        if (grabAction.GetLastStateUp(handType))
        {
            if (objectInHand)
            {
                ReleaseObject();
                objectSelect = false;
            }
        }

        if (useAction.GetLastStateDown(handType))
        {
            if(objectSelect)
            {
                useObject();
                sabre.degaine();
            }
            sabre.degaine();

            if (objectSelect && objectInHand.CompareTag("sabre"))
            {
                useObject();
                sabre.degaine();
            }


        }

        if(objectSelect && objectInHand.CompareTag("tapette"))
        {
            objectInHand.transform.position = transform.position;
            //objectInHand.transform.rotation = transform.rotation;
            //objectInHand.transform.rotation = Quaternion.Euler(45, transform.rotation.y, transform.rotation.z);
        }
        if (objectSelect && objectInHand.CompareTag("sabre"))
        {
            sabre.degaine();
        }



    }

    private void SetCollidingObject(Collider col)
    {
        // 1
        if (collidingObject || !col.GetComponent<Rigidbody>())
        {
            return;
        }
        // 2
        collidingObject = col.gameObject;
    }



    // 1
    public void OnTriggerEnter(Collider other)
    {
        SetCollidingObject(other);
    }

    // 2
    public void OnTriggerStay(Collider other)
    {
        SetCollidingObject(other);
    }

    // 3
    public void OnTriggerExit(Collider other)
    {
        if (!collidingObject)
        {
            return;
        }

        collidingObject = null;
    }

    private void useObject()
    {

        //Destroy(objectInHand);
        //faire qq chose

    }

    private void GrabObject()
    {
        // 1
        objectInHand = collidingObject;
        collidingObject = null;
        // 2
        var joint = AddFixedJoint();
        joint.connectedBody = objectInHand.GetComponent<Rigidbody>();

        
    }

    // 3
    private FixedJoint AddFixedJoint()
    {
        FixedJoint fx = gameObject.AddComponent<FixedJoint>();
        fx.breakForce = 20000;
        fx.breakTorque = 20000;
        return fx;
    }


    private void ReleaseObject()
    {
        // 1
        if (GetComponent<FixedJoint>())
        {
            // 2
            GetComponent<FixedJoint>().connectedBody = null;
            Destroy(GetComponent<FixedJoint>());
            // 3
            objectInHand.GetComponent<Rigidbody>().velocity = controllerPose.GetVelocity();
            objectInHand.GetComponent<Rigidbody>().angularVelocity = controllerPose.GetAngularVelocity();

        }
        // 4
        objectInHand = null;
    }




}
