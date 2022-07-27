using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RuleFlag
{
    IsYou,
    // BabaIsYou,
    // RockIsYou,
    // WallIsYou,
    // FlagIsYou,

    IsStop,
    // BabaIsStop,
    // RockIsStop,
    // WallIsStop,
    // FlagIsStop,

    IsPush,
    // BabaIsPush,
    // RockIsPush,
    // WallIsPush,
    // FlagIsPush,

    IsWin
    // BabaIsWin,
    // RockIsWin,
    // WallIsWin,
    // FlagIsWin
}

public class RuleManager : MonoBehaviour
{
    private List<Rule> _subjects = new List<Rule>();

    void Awake()
    {
        Rule.Manager = this;
    }

    public void ActivateFlag(RuleFlag ruleFlag)
    {
        switch (ruleFlag)
        {
            case RuleFlag.IsYou:
                Debug.Log("IsYou");;
                break;

            case RuleFlag.IsStop:
                Debug.Log("IsStop");
                break;

            case RuleFlag.IsPush:
                Debug.Log("IsPush");
                break;

            case RuleFlag.IsWin:
                Debug.Log("IsWin");
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
        //_subjects.Remove(ruleObject);
    }

    public bool isWin()
    {
        return false;
    }





}