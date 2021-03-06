﻿using System.Runtime.Serialization;

namespace LiqPay.SDK.Dto.Enums
{
    public enum LiqPayRequestLanguage
    {
        [EnumMember(Value = "ru")]
        RU,
        [EnumMember(Value = "uk")]
        UK,
        [EnumMember(Value = "en")]
        EN
    }
}