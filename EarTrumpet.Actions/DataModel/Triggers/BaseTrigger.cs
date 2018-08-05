﻿using System.Xml.Serialization;

namespace EarTrumpet_Actions.DataModel.Triggers
{
    [XmlInclude(typeof(EventTrigger))]
    [XmlInclude(typeof(HotkeyTrigger))]
    [XmlInclude(typeof(DeviceEventTrigger))]
    [XmlInclude(typeof(AppEventTrigger))]
    [XmlInclude(typeof(ProcessTrigger))]
    public abstract class BaseTrigger : PartWithOptions
    {
    }
}
