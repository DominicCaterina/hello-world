using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRTPCToDisctance : MonoBehaviour
{
   public AK.Wwise.RTPC GameParameter;
   public Transform OtherTransform;

    void Update()
    {
       float distance = Vector3.Distance(OtherTransform.position, transform.position);
        GameParameter.SetGlobalValue(distance);

    }



}
