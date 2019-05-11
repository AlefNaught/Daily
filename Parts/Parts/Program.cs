using System;
using System.Collections.Generic;

class Part
{
    public string Type {get; set;}
    public string Material {get; set;}
    //public string Name {get; set;}
    public float Price {get; set;}
    public float Size {get; set;}
    public float Weight {get; set;}
    public int Quantity {get; set;}
    public int PartID {get; set;}

    public override string ToString() {
        return string.Join(",", Type, Material, Price, Size, Weight, Quantity, PartID);
    }
}

class MainClass {
    public static List<Part> parts;
    public static void Init () {
        Random rng = new Random();
        parts = new List<Part>();

        string[] typeList = new string[]{"Motherboard", "CPU", "GPU", "PSU", "Memory", "Disk", "SSD"};
        string[] materialList = new string[] {"Solid fucking gold", "Virgin Plastic", "Chad Autism", "Carbon Metal"};

        for (int i=0; i < 10; i++) {
            string rndType = typeList[rng.Next(typeList.Length)];
            string rndMaterial = materialList[rng.Next(materialList.Length)];
            //string rndName = "fuck"//?;
            float rndPrice = (float)rng.NextDouble()*2000.0f;
            float rndSize = (float)rng.NextDouble()*40.0f;
            float rndWeight = (float)rng.NextDouble()*50.0f;
            int rndQuantity = rng.Next();
            int rndPartID = rng.Next();
            parts.Add(new Part{
                Type = rndType,
                Material = rndMaterial,
                Price = rndPrice,
                Size = rndSize,
                Weight = rndWeight,
                Quantity = rndQuantity,
                PartID = rndPartID
            });
        }
    }
    public static void Main (string[] args) {
    
        Init();
        foreach (var part in parts) {
            Console.WriteLine(part);
        }
    }
}
}