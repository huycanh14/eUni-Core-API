using System.Runtime.Serialization;

namespace eUni_Core_NetCore.Shared.Enums;

public enum ESort
{
    [EnumMember(Value = "ASC")]
    ASC,
    [EnumMember(Value = "DESC")]
    DESC,
}
