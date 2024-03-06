using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laiterekisteri2
{
    // Yleinen laiteluokka, yliluokka tietokoneelle, tableteille ja puhelimille

    class Device
    {
        // Luodaan kenttä (field) name, esitellään ( define ), ja annetaan arvo ( set initial value )
        string name = "Uusi laite";
        //Luodaan kentää vastaava ominaisuus(property) Name ja sille asetusmetodi set ja lukumetodi get. Ne voi kirjoittaa joko yhdelle tai useammalle riville. 
        public string Name { get { return name; } set { name = value; } }

        string purchaseDate = "1.1.1900";
        public string PurchaseDate { get {  return purchaseDate; } set {  purchaseDate = value; } }

        // Huom. Jälkiliite d (suffix)

        double price = 0.0d;
        public double Price { get { return price;} set { price = value; } }

        int warranty = 12;
        public int Warranty { get {  return warranty; } set {  warranty = value; } }

        string processorType = "N/A";
        public string ProcessorType { get { return processorType; } set { processorType = value; } }

        int amountRAM = 0;
        public int AmountRAM { get { return amountRAM; } set { amountRAM = value; } }

        int storageCapacity = 0;
        public int StorageCapacity { get { return storageCapacity; } set { storageCapacity = value; } }

        //Konstrukstori eli olionmuodostin (constructor) ilman argumentteja

        public Device() { }

        // Konstruktori nimi-argumentille

        public Device(string name) 
        {
            this.name = name;
        }

        //Konstruktori kaikilla argumenteilla

        public Device(string name, string purchaseDate, double price, int warranty)
        {
            this.name = name;
            this.purchaseDate = purchaseDate;
            this.price = price;
            this.warranty = warranty;
        }

    }

    //Tietokoneiden luokka, perii ominaisuuksia ja metodeja laiteluokasta Device

    class Computer : Device
    {
        // kentät ja ominaisuudet

        

        // Konstruktorit

        public Computer() : base()
            { }

        public Computer(string name) : base(name) { } 

        // Show Info - metodi, joka näyttää koneen ominausuudet

        public new void ShowInfo()
        {
            Console.WriteLine("Koneen nimi: " + this.Name);
            Console.WriteLine("Koneen prosessori: " + this.ProcessorType);
            Console.WriteLine("Keskusmuistin määrä: " + this.AmountRAM + "GB");
            Console.WriteLine("Levytilan määrä: " + this.StorageCapacity + "GB");

        } 

    }

    class Tablet : Device
    {
        // Kentät

        string operatingSystem;
        public string OperatingSystem { get { return operatingSystem; } set { operatingSystem = value; } }
        bool stylusEnabled;
        

        internal class Program
        {
            //Pääohjelman luokka
            static void Main(string[] args)
            {
                // Ohjelma kysyy tietoa laitteista ja 
                // vastaamalla kysymyksiin tiedot tallennetaan muuttujiin

                // Luodaan uusi laite Device-luokasta

                Device laite1 = new Device("Kone1");
                Console.WriteLine("Laitteen nimi on: " + laite1.Name);
                Console.WriteLine("Ostopäivä: " + laite1.PurchaseDate);

                //Luodaan uusi tietokone, joka perii laiteluokan ominaisuudet ja metodit

                Computer tietokone1 = new Computer();

                // Prosessori-ominaisuudelle ja RAMille arvot

                tietokone1.ProcessorType = "Intel i7";
                tietokone1.AmountRAM = 16;

                Console.WriteLine("Uuden koneen nimi on: " + tietokone1.Name + " ja siinä on " + tietokone1.ProcessorType + "-prosessori ja " + tietokone1.AmountRAM + "GB keskusmuistia");

                //Luodaan nimetty tietokone toisella konstruktorilla

                Computer tietokone2 = new Computer("Tietsikka");
                tietokone2.ProcessorType = "AMD Ryzen 7 4000";
                tietokone2.AmountRAM = 16;
                tietokone2.ShowInfo();

                Console.ReadLine();
            }
        }
    }
    }
