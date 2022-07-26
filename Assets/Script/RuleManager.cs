using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RuleFlag
{
    BabaIsYou,
    RockIsYou,
    WallIsYou,
    FlagIsYou,

    BabaIsStop,
    RockIsStop,
    WallIsStop,
    FlagIsStop,

    BabaIsPush,
    RockIsPush,
    WallIsPush,
    FlagIsPush,

    BabaIsWin,
    RockIsWin,
    WallIsWin,
    FlagIsWin
}

public class RuleManager : MonoBehaviour
{
    private List<Rule> _subjects = new List<Rule>();

    void Start()
    {
        Rule.Manager = this;
    }

    public void ActivateFlag(RuleFlag ruleFlag)
    {
        switch (ruleFlag)
        {
            case RuleFlag.BabaIsYou:
                Debug.Log("BabaIsYou");
                YouMovement();
                break;

            case RuleFlag.RockIsYou:
                Debug.Log("RockIsYou");
                break;

        }
    }

    public void AddSubject (Rule ruleObject)
    {
        _subjects.Add(ruleObject);
    }

    void LateUpdate()
    {
        foreach (Rule subject in _subjects)
        {
            subject.CheckRule();
        }
    }

    public void RemoveSubject (Rule ruleObject)
    {
        _subjects.Remove(ruleObject);
    }






    //////////

    public void YouMovement()
    {
        //키 입력에 따른 움직임

        if(tag == "Baba")
        {
            anim.Play("BabaLeft");
        }
    }



}