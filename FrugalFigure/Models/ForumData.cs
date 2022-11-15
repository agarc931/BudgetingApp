using System;
namespace FrugalFigure.Models
{
    public abstract class data
    {
        public string name { get; set; }
        public double amount { get; set; }
    }

    public class Needs :data
    {

    }
    public class Wants : data
    {

    }
    public class Savings : data
    {

    }
}

