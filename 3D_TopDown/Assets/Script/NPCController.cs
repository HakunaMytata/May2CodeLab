using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathUtil;
using TMPro;

public class NPCController : MonoBehaviour
{
    GameObject playerObj;
    public TextMeshProUGUI subtitle;

    // Start is called before the first frame update
    void Start()
    {
        subtitle = GetComponentInChildren<TextMeshProUGUI>();
        playerObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Util.CanSeeObj(playerObj, gameObject, 0.9f))
        {
            Debug.Log("I can see player");
        }
        Util.objSide(playerObj, gameObject);
    }
}
