using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Body Part", menuName = "Body Part")]
public class SO_BodyPart : ScriptableObject
{
    public string bodyPartName;
    public int bodyPartAnimationID;
    public int buyPrice;
    public int sellPrice;
    public Sprite spriteOnShop;

    public List<AnimationClip> allBodyPartAnimations = new List<AnimationClip>();
}
