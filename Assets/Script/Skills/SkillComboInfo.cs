using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skill Combos")]
public class SkillComboInfo : ScriptableObject
{
    [SerializeField]
    public class SkillCombo
    {
        public Elements.ElementalAttribute ElementOne = Elements.ElementalAttribute.None;
        public Elements.ElementalAttribute ElementTwo = Elements.ElementalAttribute.None;
        public GameObject prefab = null;
    }

    [SerializeField]
    private List<SkillCombo> _skillCombos = new List<SkillCombo>();

    public GameObject GetPrefabForCombo(Elements.ElementalAttribute element1, Elements.ElementalAttribute element2)
    {
        foreach(var skill in _skillCombos)
        {
            if(skill.ElementOne == Elements.ElementalAttribute.Fire && skill.ElementTwo == Elements.ElementalAttribute.Water)
            {
                return skill.prefab;
            }
        }
        return null;
    }
}
