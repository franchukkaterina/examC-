public class Laptop
{
    public int Price { get; set; }
    
    public string Producer { get; set; }

    public int AmountLaptop { get; set; }
    
    public float Memory { get; set; }
    
    public string CPU { get; set; }
    
    public Laptop(){}

    public Laptop(int price, string producer, int amountLaptop ,float memory, string CPU){
        this.Price = price;
        this.Producer = producer;
        this.AmountLaptop = amountLaptop;
        this.Memory = memory;
        this.CPU = CPU;
    }

    public int Purchase(int amount){
        return this.AmountLaptop-amount;
    }

    public override bool Equals(object obj)
    {
        if(obj is Laptop)
        {
            Laptop u = obj as Laptop;
            if(u.Price != this.Price) return false;
            if(u.Producer != this.Producer) return false;
            if(u.AmountLaptop != this.AmountLaptop) return false;
            if(u.Memory != this.Memory) return false;
            if(u.CPU != this.CPU) return false;
            return true;
        }  
        return false;
    }


    public override int GetHashCode()
    {
        return (this.Price.GetHashCode() + this.Producer.GetHashCode() + this.AmountLaptop.GetHashCode() + this.Memory.GetHashCode() + this.CPU.GetHashCode());
    }

    public override string ToString()
    {
        return $"Laptop {this.Producer} price is {this.Price}, this laptop has {this.Memory} memory, and this {this.CPU} CPU";
    }


}