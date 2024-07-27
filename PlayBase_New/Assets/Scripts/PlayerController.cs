using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    Text PlayerValues;

    public int hp;
    public int mp;

    int CurrentHP;
    int CurrentMP;

    public int initiative;
    int CurrentInitiative;

    bool hit;

    string CurrentPlayer;

    int CurrentPlayerInitiative;

    //Color m_MouseOverColor = Color.blue;
    //MeshRenderer m_Renderer;
    //Color m_OriginalColor;

    public List<KeyValuePair<int, string>> newOrder;

    public int PlayerCount = 6;

    string CurrentTarget;

    // Use this for initialization
    void Start() {

        CurrentHP = hp;
        CurrentMP = mp;
        CurrentInitiative = initiative;
        FirstTurn();

    }

    void Update()
    {

    }

    List<KeyValuePair<int, int>> StatsList()
    {
        int key1 = GameObject.Find("1").GetComponent<PlayerController>().hp;
        int val1 = GameObject.Find("1").GetComponent<PlayerController>().mp;
        int key2 = GameObject.Find("2").GetComponent<PlayerController>().hp;
        int val2 = GameObject.Find("2").GetComponent<PlayerController>().mp;
        int key3 = GameObject.Find("3").GetComponent<PlayerController>().hp;
        int val3 = GameObject.Find("3").GetComponent<PlayerController>().mp;
        int key4 = GameObject.Find("4").GetComponent<PlayerController>().hp;
        int val4 = GameObject.Find("4").GetComponent<PlayerController>().mp;
        int key5 = GameObject.Find("5").GetComponent<PlayerController>().hp;
        int val5 = GameObject.Find("5").GetComponent<PlayerController>().mp;
        int key6 = GameObject.Find("6").GetComponent<PlayerController>().hp;
        int val6 = GameObject.Find("6").GetComponent<PlayerController>().mp;

        List<KeyValuePair<int, int>> orderStats = new List<KeyValuePair<int, int>>() {
            new KeyValuePair<int, int>(key1,val1),
            new KeyValuePair<int, int>(key2,val2),
            new KeyValuePair<int, int>(key3,val3),
            new KeyValuePair<int, int>(key4,val4),
            new KeyValuePair<int, int>(key5,val5),
            new KeyValuePair<int, int>(key6,val6)
        };

        orderStats = orderStats.OrderBy(x => x.Key).ToList();

        return orderStats;
    }

    // Method that initializes the initiative list
    List<KeyValuePair<int, string>> InitiativeList()
    {
        int val1 = GameObject.Find("1").GetComponent<PlayerController>().initiative;
        int val2 = GameObject.Find("2").GetComponent<PlayerController>().initiative;
        int val3 = GameObject.Find("3").GetComponent<PlayerController>().initiative;
        int val4 = GameObject.Find("4").GetComponent<PlayerController>().initiative;
        int val5 = GameObject.Find("5").GetComponent<PlayerController>().initiative;
        int val6 = GameObject.Find("6").GetComponent<PlayerController>().initiative;

        List<KeyValuePair<int, string>> orderValues = new List<KeyValuePair<int, string>>() {
            new KeyValuePair<int, string>(val1,"1"),
            new KeyValuePair<int, string>(val2,"2"),
            new KeyValuePair<int, string>(val3,"3"),
            new KeyValuePair<int, string>(val4,"4"),
            new KeyValuePair<int, string>(val5,"5"),
            new KeyValuePair<int, string>(val6,"6")
        };

        orderValues = orderValues.OrderBy(x => x.Key).ToList();

        return orderValues;
    }

    // This is called when the games starts - it decides which character goes first
    void FirstTurn()
    {
        int iteration = 0;

        List<KeyValuePair<int, string>> newOrder = InitiativeList();

        CurrentPlayerInitiative = newOrder.Max(e => e.Key);

        foreach (var pair in newOrder.ToList())
        {

            if (pair.Key == CurrentPlayerInitiative && iteration == 0)
            {
                CurrentPlayer = pair.Value;


                int tempHP = GameObject.Find(CurrentPlayer).GetComponent<PlayerController>().CurrentHP;
                int tempMP = GameObject.Find(CurrentPlayer).GetComponent<PlayerController>().CurrentMP;
                SetText(tempHP, tempMP);
                iteration = 1;
            }
            if (iteration == 1)
            {
                newOrder.Remove(new KeyValuePair<int, string>(pair.Key, pair.Value));
                CurrentPlayerInitiative = newOrder.Max(e => e.Key);
                iteration = 0;
            }
        }
    }
    // Returns a new list without the max value from the previous list

    public List<KeyValuePair<int, string>> NextTurn()
    {
        List<KeyValuePair<int, string>> newOrder = InitiativeList();
        int count = newOrder.Count;
        newOrder.Max(e => e.Key);
        newOrder.RemoveAt(count - 1);
        return newOrder;
    }
    // Returns a new list without the max value from the previous list
    public List<KeyValuePair<int, string>> NextTurn2()
    {
        List<KeyValuePair<int, string>> newOrder = NextTurn();
        int count = newOrder.Count;
        newOrder.Max(e => e.Key);
        newOrder.RemoveAt(count - 1);
        return newOrder;
    }
    // Returns a new list without the max value from the previous list
    public List<KeyValuePair<int, string>> NextTurn3()
    {
        List<KeyValuePair<int, string>> newOrder = NextTurn2();
        int count = newOrder.Count;
        newOrder.Max(e => e.Key);
        newOrder.RemoveAt(count - 1);
        return newOrder;
    }
    // Returns a new list without the max value from the previous list
    public List<KeyValuePair<int, string>> NextTurn4()
    {
        List<KeyValuePair<int, string>> newOrder = NextTurn3();
        int count = newOrder.Count;
        newOrder.Max(e => e.Key);
        newOrder.RemoveAt(count - 1);
        return newOrder;
    }
    // Returns a new list without the max value from the previous list
    public List<KeyValuePair<int, string>> NextTurn5()
    {
        List<KeyValuePair<int, string>> newOrder = NextTurn4();
        int count = newOrder.Count;
        newOrder.Max(e => e.Key);
        newOrder.RemoveAt(count - 1);
        return newOrder;
    }
    // Returns a new list without the max value from the previous list
    public List<KeyValuePair<int, string>> NextTurn6()
    {
        List<KeyValuePair<int, string>> newOrder = NextTurn5();
        int count = newOrder.Count;
        newOrder.Max(e => e.Key);
        newOrder.RemoveAt(count - 1);
        return newOrder;
    }
    //

    void EndTurn()
    {
        int iteration = 0;

        switch (PlayerCount)
        {
            case 6:
                newOrder = NextTurn();
                PlayerCount--;
                break;
            case 5:
                newOrder = NextTurn2();
                PlayerCount--;
                break;
            case 4:
                newOrder = NextTurn3();
                PlayerCount--;
                break;
            case 3:
                newOrder = NextTurn4();
                PlayerCount--;
                break;
            case 2:
                newOrder = NextTurn5();
                PlayerCount--;
                break;
            case 1:
                newOrder = NextTurn6();
                PlayerCount--;
                break;
        }

        if (PlayerCount > 0)
        {
            CurrentPlayerInitiative = newOrder.Max(e => e.Key);
            foreach (var pair in newOrder.ToList())
            {
                if (pair.Key == CurrentPlayerInitiative && iteration == 0)
                {
                    CurrentPlayer = pair.Value;

                    int tempHP = GameObject.Find(CurrentPlayer).GetComponent<PlayerController>().CurrentHP;
                    int tempMP = GameObject.Find(CurrentPlayer).GetComponent<PlayerController>().CurrentMP;
                    SetText(tempHP, tempMP);
                    iteration = 1;
                }
                if (iteration == 1 && newOrder.Count != 0)
                {
                    CurrentPlayerInitiative = newOrder.Max(e => e.Key);
                    Debug.Log(CurrentPlayerInitiative);
                    iteration = 0;
                }
            }
        }
        else
        {
            PlayerCount = 6;
            FirstTurn();
        }
    }



    void OnMouseOver()
    {
        ClickOnPlayer();
    }


    void ClickOnPlayer()
    {

        int ComparisonTarget;
        

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            CurrentTarget = hit.transform.gameObject.name;
            ComparisonTarget = Int32.Parse(CurrentTarget);
            
        }
    }

    

   
    
    void OnMouseExit()
    {
        //m_Renderer = GetComponent<MeshRenderer>();
        //m_Renderer.material.color = m_OriginalColor;
    }

    // Update is called once per frame


    void Death() {

        //isDead = true;
        //Then disable player character that died and always skip their turn until combat is over
    }


    void SetText(int hp,int mp)
    {
            PlayerValues = GameObject.Find("PlayerValues").GetComponent<Text>();
            PlayerValues.text = "Current HP:" + hp + Environment.NewLine + "Current MP:" + mp;    
    }

    public void FlamePunch()
    {
        int damage = 1;
        int manaCost = 1;

        if (CurrentMP >= 1)
        {
            CurrentHP -= damage;
            CurrentMP -= manaCost;
        }
        if (CurrentHP <= 0)
        {
            Death();
        }
    }

    public void FlameKick()
    {
        int damage = 3;
        int manaCost = 3;

        if (CurrentMP >= 3)
        {
            CurrentHP -= damage;
            CurrentMP -= manaCost;
        }

        if (CurrentHP <= 0)
        {
            Death();
        }

    }

    public void Magic()
    {
        int damage = 5;
        int manaCost = 5;

        if (CurrentMP >= 5)
        {
            CurrentHP -= damage;
            CurrentMP -= manaCost;
        }

        if (CurrentHP <= 0)
        {
            Death();
        }

    }

}
