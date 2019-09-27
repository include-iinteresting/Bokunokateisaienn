using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunScript : MonoBehaviour
{
    //! 太陽の回転スピード
    public float fRotateSpeed;

    //! 太陽の角度
    float fAngle = 6.28f * 0.2f;
    //! 太陽の移動時の半径
    public float fRadius;
    //! 太陽の回転の中心のY座標
    public float fCenterY;
    //! 太陽の移動速度
    public float fVelocity;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Mathf.Cos(fAngle) * fRadius, Mathf.Sin(fAngle) * fRadius + fCenterY, -1);
    }

    // Update is called once per frame
    void Update()
    {
        //!<    回転
        transform.Rotate(new Vector3(0, 0, fRotateSpeed));

        //!<    移動
        fAngle += fVelocity;
        if (fAngle > 6.28f)
            fAngle = 0.0f;
        transform.position = new Vector3(Mathf.Cos(fAngle) * fRadius, Mathf.Sin(fAngle) * fRadius + fCenterY, -1);
    }
}
