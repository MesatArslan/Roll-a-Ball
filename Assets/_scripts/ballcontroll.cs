using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ballcontroll : MonoBehaviour
{
    public Rigidbody phisic;
    public int speed;
    public int point;
    public int objectNumber;

    public TextMeshProUGUI pointText;
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        phisic = GetComponent<Rigidbody>();
      // transform.Translate(0,0,1);  //* burda yapılan değişiklikler sadece bir kez gerçekleşir
    }

    // Update is called once per frame
    void FixedUpdate()  //* Fizik methodlarında genellikle FixedUpdate methodu kullanılıyor çünkü daha stabil bir kontrol sağlıyor
    {
      // transform.Translate(0,0,0.1f);  //* burda yapılan değişiklikler her framede tekrar gerçekleşir
      // transform.Rotate(0.1f,0,0);    //* rotate ile kendi ekseni etrafında dönüşünü kontrol edebiliyoruz


    //   if(Input.GetKeyDown(KeyCode.Escape))    //* buradaki yaptığımız işlemlerle tuşlara  ulaşıyoruz
    //   {
    //       Debug.Log("Esc tuşuna basıldı.");
    //   }
    //   if(Input.GetKeyDown(KeyCode.E))
    //   {
    //       Debug.Log("E tuşuna basıldı.");
    //   }


        //* Top hareketini yapma

    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    Vector3 vector = new Vector3(horizontal,0,vertical);
    
    phisic.AddForce(vector*speed);

    // Debug.Log("horizontal =" + horizontal);
    // Debug.Log("vertical =" + vertical);
    }

    void OnTriggerEnter(Collider other)  //* bu sayede herhangi bir kişinin bizim objemize değip değmediğini kontrol ediyoruz ve (değdiğimiz anda yok olmasını sağlayabiliyoruz)
    {
        //? bu işlem çok ram yiyen bir işlem olduğu için bunu kullanmıyoruz daha çok
        // Destroy(other.gameObject);

        //? daha çok bunu tercih ediyoruz
        other.gameObject.SetActive(false);
        point++;
        // point += 1;  //*2 sinin anlamıda aynı
        pointText.text ="Puan: " + point;

        if(point == objectNumber)
        {
          // Debug.Log("Game Over...");
          gameOverText.gameObject.SetActive(true);
        }
    }

    // void OnTriggerExit(Collider other)  //* (objeye temasımızız kesildiği anda yok olmasını sağlayabiliyoruz)
    // {
    //     other.gameObject.SetActive(false);
    // }

    // void OnTriggerStay(Collider other)  //* (objeye temas edip durduğumuz anda(birkaç frame üst üste içinde olduğumuz durumlarda) yok olmasını sağlayabiliyoruz)
    // {
    //     other.gameObject.SetActive(false);
    // }


} 