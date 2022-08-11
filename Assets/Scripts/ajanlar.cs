using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ajanlar : MonoBehaviour
{
    public GameObject gamekontrol;
    NavMeshAgent agent;
    public GameObject hedef;   
    public string ajanturu;
    private int carpmasayisi;
    private float darbegucu;

   

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();  
        agent.SetDestination(hedef.transform.position);

        switch (ajanturu)
        {

                case "Mavi":
                carpmasayisi = 3;
                darbegucu = 20f;
                break;

                case "Sari":
                carpmasayisi = 2;
                darbegucu = 10f;
                break;

                case "Mor":
                carpmasayisi = 1;
                darbegucu = 8f;
                break;

        }
       
    }

   
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Engel"))
        {
            if (carpmasayisi != 0)
            {
                carpmasayisi--;

            }
            else
            {
                Destroy(gameObject);
            }
        }


        if (other.gameObject.CompareTag("AnaHedef"))
        {
            
            gamekontrol.GetComponent<gamekontrol>().Candusur(darbegucu);
           
            Destroy(gameObject);
            
        }



        

    }
}
