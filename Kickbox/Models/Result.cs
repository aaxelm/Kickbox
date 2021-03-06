﻿using System.Runtime.Serialization;

namespace Kickbox.Models
{
    public enum Result
    {
        [EnumMember(Value = "deliverable")]
        Deliverable,

        [EnumMember(Value = "undeliverable")]
        Undeliverable,

        [EnumMember(Value = "risky")]
        Risky,

        [EnumMember(Value = "unknown")]
        Unknown
    }
}
