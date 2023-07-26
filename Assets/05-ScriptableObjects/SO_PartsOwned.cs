using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New List of Parts Owned", menuName = "List of Parts Owned")]
public class SO_PartsOwned : ScriptableObject
{
    public SO_BodyPart[] ownedBodyPartsList;

}
