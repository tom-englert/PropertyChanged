using System;
using System.Collections.Generic;

using PropertyChanged;

[ImplementPropertyChanged]
public class ClassWithOpenGenerics<T>
{
    public KeyValuePair<string, T> Property1 { get; set; }

    public Tuple<string, T> Property2 { get; set; }
}
