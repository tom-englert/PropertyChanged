using System;
using System.ComponentModel;

namespace PropertyChanged
{
    /// <summary>
    /// This attribute has been replaced with <see cref="ImplementPropertyChangedAttribute"/>
    /// </summary>
    [Obsolete(@"This configuration option has been deprecated. PropertyChanged2 uses the backward compatible ImplementPropertyChangedAttribute again.", error: true)]
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class AddINotifyPropertyChangedInterfaceAttribute : Attribute
    {
    }
}