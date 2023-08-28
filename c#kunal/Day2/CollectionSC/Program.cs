using System;
using System.Collections;
using System.Collections.Generic;

class Practice
{
    public ArrayList AddData()
    {
        ArrayList ar = new ArrayList();
        ar.Add("Kunal");
        ar.Add("MCA");
        ar.Add("rahul");
        ar.Add("B.tech");
        ar.Add("Tyagi");
        ar.Add("Btech");
        ar.Add(20);

        return ar;
    }
}

class client
{
    public static void Main(){
        Practice obj = new Practice();
        ArrayList temp = obj.AddData();
        string age = Convert.ToString(temp[4]);  //heap to stack
        foreach(var t in temp){
            Console.WriteLine(t);
        }
       
    }
}
