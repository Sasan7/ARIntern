using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PicupScript : MonoBehaviour
{

    private bool PickUp;
    private Text myText;
    private int applesCollected = 0;
    public GameObject myApple, MyApple2, Instantiated;
    public Transform dropPoint, pickPoint;
    public GameObject[] myApples;
    [SerializeField]
    private GameObject myHorse;
    public Transform basket, basket1, basket2, basket3, basket4, initial, Target;
    private bool horseMove;
    private HorseMoveTo hm;
    private Animator anim;
    void Start()
    {
        myText = GameObject.FindObjectOfType<Text>();
        myText.text = "Apples Collected : " + applesCollected.ToString();
        myHorse = GameObject.FindGameObjectWithTag("Horse");
        Target = initial;
        hm = GameObject.FindObjectOfType<HorseMoveTo>();
        anim = myHorse.GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        myHorse.transform.position = Vector3.MoveTowards(myHorse.transform.position, Target.position, 0.008f);
        Debug.Log("calling");
        if (myHorse.transform.position == Target.position)
        {
            Target = initial;
        }
        if (myHorse.transform.position == initial.position)
        {
            anim.SetBool("Moving", false);
        }
        else
        {
            anim.SetBool("Moving", true);
        }
        myHorse.transform.LookAt(Target);
        //Target = initial;
        //hm.HorseTarget = Target;
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Basket" && !PickUp)
        {
            PickUp = true;
            Target = basket;
            Instantiated = Instantiate(MyApple2, pickPoint.transform.position, Quaternion.identity, pickPoint);
        }
        if (col.gameObject.name == "Basket1" && !PickUp)
        {
            PickUp = true;
            Target = basket1;
            Instantiated = Instantiate(MyApple2, pickPoint.transform.position, Quaternion.identity, pickPoint);
        }
        if (col.gameObject.name == "Basket2" && !PickUp)
        {
            PickUp = true; Target = basket2;
            Instantiated = Instantiate(MyApple2, pickPoint.transform.position, Quaternion.identity, pickPoint);
        }
        if (col.gameObject.name == "Basket3" && !PickUp)
        {
            PickUp = true;
            Target = basket3;
            Instantiated = Instantiate(MyApple2, pickPoint.transform.position, Quaternion.identity, pickPoint);
        }
        if (col.gameObject.name == "Basket4" && !PickUp)
        {
            PickUp = true;
            Target = basket4;
            Instantiated = Instantiate(MyApple2, pickPoint.transform.position, Quaternion.identity, pickPoint);
            //Instantiated.transform.localScale = 
        }
        if (col.gameObject.name == "BasketFinal" && PickUp)
        {
            Destroy(Instantiated);
            PickUp = false;
            applesCollected++;
            //Instantiated = Instantiate(myApple, dropPoint.transform.position, Quaternion.identity);
            myApples[applesCollected - 1].SetActive(true);
            myText.text = "Apples Collected : " + applesCollected.ToString();
            if (applesCollected >= myApples.Length)
            {
                applesCollected = 0;
                foreach (GameObject apple in myApples)
                {
                    apple.SetActive(false);
                }

            }
        }

    }
}
