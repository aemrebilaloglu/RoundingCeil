using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceil : MonoBehaviour
{
   public void CeilRot()
    {
        float x = transform.eulerAngles.x;
        float y = transform.eulerAngles.y;
        float z = transform.eulerAngles.z;

        float absNumberX = Mathf.Abs(x);
        float absNumberY = Mathf.Abs(y);
        float absNumberZ = Mathf.Abs(z);

        float roundedAbsNumberX = Mathf.Round(absNumberX / 45f) * 45f;
        float roundedAbsNumberY = Mathf.Round(absNumberY / 45f) * 45f;
        float roundedAbsNumberZ = Mathf.Round(absNumberZ / 45f) * 45f;

        float roundedNumberX = absNumberX >= 0f ? roundedAbsNumberX : -roundedAbsNumberX;
        float roundedNumberY = absNumberY >= 0f ? roundedAbsNumberY : -roundedAbsNumberY;
        float roundedNumberZ = absNumberZ >= 0f ? roundedAbsNumberZ : -roundedAbsNumberZ;

        transform.eulerAngles = new Vector3(roundedNumberX, roundedNumberY, roundedNumberZ);
    }
}
