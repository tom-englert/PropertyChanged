using PropertyChanged;

[ImplementPropertyChangedAttribute]
public class ClassWithNotifyInChildByAttribute : ParentClass
{
    public string Property { get; set; }
}