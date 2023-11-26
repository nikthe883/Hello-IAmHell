using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="RoomNodeType_",menuName = "Scriptable Objects/Dungeon/Room Node Type")]
public class RoomNodeTypeSo : ScriptableObject
{
    public string roomNodeTypeName;

    #region Header
    [Header("Only flag the RoomNodeTypes that should be visinle in the editor")]
    #endregion
    public bool displayInNodeGraphEditor = true;
    #region Header
    [Header("One type path")]
    #endregion
    public bool ispath;
    #region Header
    [Header("One type pathNS")]
    #endregion
    public bool ispathNS;
    #region Header
    [Header("One type pathEW")]
    #endregion
    public bool ispathEW;
    #region Header
    [Header("One type Entrance")]
    #endregion
    public bool isEntrance;
    #region Header
    [Header("One type House")]
    #endregion
    public bool ishouse;
    #region Header
    [Header("One type Unassigned")]
    #endregion
    public bool isNone;

    #region Validation
#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEmptyString(this, nameof(roomNodeTypeName), roomNodeTypeName);
    }
#endif
    #endregion
}
