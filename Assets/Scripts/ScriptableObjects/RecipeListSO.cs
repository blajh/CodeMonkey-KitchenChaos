using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu]
// since we only need one, creating is turned off
public class RecipeListSO : ScriptableObject
{
    public List<RecipeSO> recipeSOList;
}
