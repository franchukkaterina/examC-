using System;
using System.IO;
using System.Xml.Serialization;
public class FileModeOpenOrCreate
{
    XmlSerializer formatter;

    public FileModeOpenOrCreate(){
        this.formatter = new XmlSerializer(typeof(MySystem<Laptop>));
    }

    public void RecordInformation(MySystem<Laptop> list){
        using(FileStream stream = new FileStream("user.xml", FileMode.OpenOrCreate)){
            formatter.Serialize(stream, list);
        }
    }

    public void GetInformation(){
        using(FileStream stream = new FileStream("user.xml", FileMode.OpenOrCreate)){
            MySystem<Laptop> user = (MySystem<Laptop>)formatter.Deserialize(stream);
            user.ForEach(Console.WriteLine);
        }
    }   
}