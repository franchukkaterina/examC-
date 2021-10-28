using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class MySystem<T> : List<T>, IDisposable where T : Laptop
{
    public MySystem() : base(){}

    public new void Add(T user){
        base.Add(user);
    }

    public new void Remove(T user){
        for (int i = 0; i < this.Count; i++)
        {
            if(this[i].Equals(user)){
                 base.Remove(this[i]);
                 Console.WriteLine($"Text");
            }
        }
    }

    public new List<T> FindAll(Predicate<T> pred){
        return base.FindAll(pred);
    }

    public new void Clear(){
        base.Clear();
    }

    public  void Dispose(){
        GC.Collect(GC.GetGeneration(this));
    }

    
}