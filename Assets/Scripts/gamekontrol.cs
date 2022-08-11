using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class gamekontrol : MonoBehaviour
{
    public GameObject olusacakobje;
    public GameObject NavMeshObje;
    public GameObject gameoverPanel;
    public Text kalansayiText;
    private int kalansayiDeger;
    public Text NavMeshkalansayiText;
    private int NavMeshkalansayiDeger;
    private float saglik;
    public Image Healthbar;
    public GameObject[] noktalar;
    public Button[] butonlar;
    public Button[] NavMeshbutonlar;

    // Start is called before the first frame update
    void Start()
    {
        saglik = 100;

        kalansayiDeger = 30;
        kalansayiText.text = kalansayiDeger.ToString();


        NavMeshkalansayiDeger = 5;       
        NavMeshkalansayiText.text = NavMeshkalansayiDeger.ToString();

    }

    void Butonlarınkontrolu ()
    {
        if (kalansayiDeger==0)
        {
            foreach (var gelenbutonlar in butonlar)
            {
                gelenbutonlar.interactable = false;
            }

        }


    }
    void NavmeshButonlarınkontrolu()
    {
        if (NavMeshkalansayiDeger == 0)
        {
            foreach (var gelenbutonlar in NavMeshbutonlar)
            {
                gelenbutonlar.interactable = false;
            }

        }


    }

    public void Candusur(float darbe)
    {

        saglik -= darbe;

        // 100  - 2 = 98  / 100  = 0.98
        // 98 - 3 = 95   / 100  = 0.95

        Healthbar.fillAmount = saglik / 100;
        CanKontrolEt();
    }
    void CanKontrolEt()
    {
        if (saglik <= 0)
        {
            gameoverPanel.SetActive(true);
            Time.timeScale = 0;

        }
           

    }
    
    public void NoktaButonlari(int indisdeger)
    {
        kalansayiDeger--;
        kalansayiText.text = kalansayiDeger.ToString();
        Instantiate(olusacakobje, noktalar[indisdeger].transform.position, Quaternion.identity);
        Butonlarınkontrolu();

    }
    public void NavMeshEngelButon(int indisdeger)
    {
        NavMeshkalansayiDeger--;
        NavMeshkalansayiText.text = NavMeshkalansayiDeger.ToString();
        Instantiate(NavMeshObje, noktalar[indisdeger].transform.position, Quaternion.identity);
        NavmeshButonlarınkontrolu();

    }

   
}
