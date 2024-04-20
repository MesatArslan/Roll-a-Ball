using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{


    public GameObject ball; //* camero objesinin topu takip etmesi için önce bir top objesi oluşturuyoruz ve ardından bu toop objesine unity'nin içinden top objesini ekliyoruz
    public Vector3 theDiffirence;
    // Start is called before the first frame update
    void Start()
    {
        theDiffirence  = transform.position  - ball.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()           //* Camera fonksiyonları için LateUpdate fonksiyonu kullanılır
    {   //* böyle bıraktığımız zaman kamera topun içinde olur lakin
        // transform.position = ball.transform.position;

        //* şimdi ise kameranın sürekli bir mesafesi olucak
        transform.position = ball.transform.position + theDiffirence;
    }
}
