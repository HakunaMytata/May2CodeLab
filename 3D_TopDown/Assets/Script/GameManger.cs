using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManger : MonoBehaviour
{
    public List<GameObject> npcObjs = new List<GameObject>();

    Dictionary<string,float> npcInfo= new Dictionary<string,float>();

    public GameObject npcPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //1.Loop through all the NPCs
        //2.access each npcObj;
        //3.access each NPC's text component
        //4.set the text of that text componet
        //for (int i = 0; i < npcObjs.Count; i++)
        //{
        //    npcObjs[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Bob");
        //}

        npcInfo.Add("Bob", 1.0f);
        npcInfo.Add("Anna", 2.0f);
        npcInfo.Add("John", 3.0f);

        float testValue;
        npcInfo.TryGetValue("Bob", out testValue);
        Debug.Log(testValue);

        foreach(KeyValuePair<string,float>pair in npcInfo)
        {
            GameObject newNPC = Instantiate(npcPrefab);
            //newNPC.GetComponent<NPCController>().sight = pair.Value;
            newNPC.GetComponentInChildren<TextMeshProUGUI>().SetText(pair.Key);

            Debug.Log(pair.Key);
            Debug.Log(pair.Value);
        }

        for (int i = 0; i < npcObjs.Count; i++)
        {
            npcObjs[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Bob");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
