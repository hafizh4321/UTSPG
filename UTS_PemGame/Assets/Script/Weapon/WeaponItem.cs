using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PG
{
    [CreateAssetMenu(menuName = "Items/WeaponItem")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;

        [Header("One Hand Attack Animations")]
        public string OH_Light_Attack_1;
        public string OH_Heavy_Attack_1;
    }
}