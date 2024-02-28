using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpawnEnamy : MonoBehaviour
{
    Enemy[] enmies;
    // Start is called before the first frame update
    void Awake()
    {
        //GameObject.FindGameObjectsWithTag("Shootable", );
        enmies = FindObjectsByType<Enemy>(FindObjectsInactive.Include, FindObjectsSortMode.None);
    }
    private void OnTriggerEnter(Collider Target)
    {
        if (Target.gameObject.tag == "Player")
        {
            Debug.Log("player Enter");
            var seq = DOTween.Sequence();
            foreach (Enemy enemy in enmies)
            {
                var pos = enemy.transform.position;
                pos.y = -1.81f;
                seq.Append(enemy.transform.DOMove(pos, 5).SetEase(Ease.OutCubic));
                enemy.gameObject.SetActive(true);
            }
        }
    }
}


/*
   public GameObject enmey;
    public Transform enemPoint;
    public float repeatRate = 5;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //create enemy if i entar the trigger 
            InvokeRepeating("SpanwnEnamy", 0.5f, repeatRate);
            //to destroy enemy ever 11 seconds 

            gameObject.GetComponent<CapsuleCollider>().enabled = false;

        }
    }

    void SpanwnEnamy()
    {
        var e = Instantiate(enmey);
        Destroy(e, 11);
   
 }*/