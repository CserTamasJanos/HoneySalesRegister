using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoadAndSave
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PersonLocation { get; set; }

        public Person(string firstName, string secondName, string personLocation)
        {
            FirstName = firstName;
            SecondName = secondName;
            PersonLocation = personLocation;
        }

        public Person (int peronId, string firstName, string secondName, string personLocation)
        {
            PersonID = peronId;
            FirstName = firstName;
            SecondName = secondName;
            PersonLocation = personLocation;
        }

        public override string ToString()
        {
            return FirstName + " " + SecondName;
        }
    }

    public class HoneyType
    {
        public int HoneyTypeID { get; set; }
        public string HoneyName { get; set; }

        public HoneyType (int honeysTypeID, string honeyName)
        {
            HoneyTypeID = honeysTypeID;
            HoneyName = honeyName;
        }

        public override string ToString()
        {
            return HoneyName;
        }
    }

    public class HoneyPayment
    {
        private const string SeparationCharacter = " ";
        public int HoneyPaymentID { get; set; }
        public int PersonID { get; set; }
        public int HoneyTypeID { get; set; }
        public int SellingAmount { get; set; }
        public int SellingPrice { get; set; }
        public DateTime SellingDate { get; set; }
        public int Present { get; set; }

        public HoneyPayment (int personID, int honeyTypeID, int sellingAmount, int sellingPrice, DateTime sellingDate, int present)
        {
            PersonID = personID;
            HoneyTypeID = honeyTypeID;
            SellingAmount = sellingAmount;
            SellingPrice = sellingPrice;
            SellingDate = sellingDate;
            Present = present;
        }

        public HoneyPayment(int honeyPaymentID, int personID, int honeyTypeID, int sellingAmount, int sellingPrice, DateTime sellingDate, int present)
        {
            HoneyPaymentID = honeyPaymentID;
            PersonID = personID;
            HoneyTypeID = honeyTypeID;
            SellingAmount = sellingAmount;
            SellingPrice = sellingPrice;
            SellingDate = sellingDate;
            Present = present;
        }

        public override string ToString()
        {
            return SellingAmount + SeparationCharacter + SellingPrice + SeparationCharacter + SellingDate;
        }
    }

    public class HoneyHarwest
    {
        private const string SeparationCharacter = " ";
        public int HoneyHarvestID { get; set; }
        public int HoneyTypeID { get; set; }
        public DateTime HoneyHarwestDateTime { get; set; }
        public string HoneyHarwestLocation { get; set; }
        public int HoneyHarwestAmount { get; set; }

        public HoneyHarwest(int honeyTypeID, DateTime honeyHarwestDateTime, string honeyHawestLocation, int honeyHarwestAmount)
        {
            HoneyTypeID = honeyTypeID;
            HoneyHarwestDateTime = honeyHarwestDateTime;
            HoneyHarwestLocation = honeyHawestLocation;
            HoneyHarwestAmount = honeyHarwestAmount;
        }

        public HoneyHarwest(int honeyHarwestID, int honeyTypeID, DateTime honeyHarwestDateTime, string honeyHawestLocation, int honeyHarwestAmount)
        {
            HoneyHarvestID = honeyHarwestID;
            HoneyTypeID = honeyTypeID;
            HoneyHarwestDateTime = honeyHarwestDateTime;
            HoneyHarwestLocation = honeyHawestLocation;
            HoneyHarwestAmount = honeyHarwestAmount;
        }

        public override string ToString()
        {
            return HoneyHarwestDateTime + SeparationCharacter + HoneyHarwestLocation + SeparationCharacter + HoneyHarwestAmount;
        }
    }
}
