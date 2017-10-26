using PropertyChanged;

[ImplementPropertyChangedAttribute]
public class ClassWithNotifyPropertyChangedAttribute
{
    public string Property1 { get; set; }
}

[ImplementPropertyChangedAttribute]
public class ClassWithNotifyPropertyChangedAttributeGeneric<T>
{
    public string Property1 { get; set; }
}
