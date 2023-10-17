using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject scanObejct;
    public static int clover;
    public int max_clover = 30;
    public static int candy;
    public static int magicbroom;
    public int max_magicbroom = 1;
    public static int cloak;
    public int max_cloak = 1;
    public static int umbrella;
    public RectTransform uiBox;
    public Text talkText;
    public float speed;
    float hAxis;
    float vAxis;
    bool jump;
    bool isJump=false;

    Vector3 moveVec;

    Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
        move();
        Jump();

    }

    void getInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        jump = Input.GetButtonDown("Jump");
        
    }

    void move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        transform.position += moveVec * speed * Time.deltaTime;

    }

    void Jump()
    {
        if (jump && !isJump)
        {
            rigid.AddForce(Vector3.up * 10,ForceMode.Impulse);
            isJump = true;
        }
        if(jump && scanObejct != null)
        {
           
            gameManager.Action(scanObejct);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Floor")
        {
            isJump = false;

        }

    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Item")
        {
             Item item = other.GetComponent<Item>();
             switch (item.type)
             {
                 case Item.Type.Clover:
                    clover += 1;
                     if (clover > max_clover) clover = max_clover;
                     break;
                 case Item.Type.Candy:
                     candy += 1;
                    Debug.Log("사탕");
                    talkText.text = "사탕이다!";
                    Invoke("Clean", 10f);
                    break;
                 case Item.Type.Magicbroom:
                     magicbroom += 1;
                     if (magicbroom > max_magicbroom) magicbroom = max_magicbroom;
                     break;
                 case Item.Type.Cloak:
                     cloak += 1;
                     if (cloak > max_cloak) cloak = max_cloak;
                     break;
                 case Item.Type.Umbrella:
                     umbrella += 1;
                     break;

             }

            Destroy(other.gameObject);

        }
        else if (other.tag == "Cat")
        {
            Debug.Log("고양이");
            talkText.text = "후추 : 지하에 무언가 있는것  같아 \n길을 잃지 않도록 조심해";
            Invoke("Clean", 10f);
        }
        

    }
    void Clean()
    {
        talkText.text = "";
    }

}
