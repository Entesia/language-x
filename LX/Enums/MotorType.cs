using System.ComponentModel;

namespace LX.Enums
{
    public enum MotorType
    {
        [Description("Petrol, ContentType.SiteContent")]
        Petrol = 0,

        [Description("Diesel, ContentType.SiteContent")]
        Diesel = 1,

        [Description("Electric, ContentType.SiteContent")]
        Electric = 2
    }
}