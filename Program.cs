﻿using System;
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

        string purchaseDate = "13.2.2024";
        public string PurchaseDate { get {  return purchaseDate; } set {  purchaseDate = value; } }

        // Huom. Jälkiliite d (suffix)

        double price = 0.0d;
        public double Price { get { return price;} set { price = value; } }

        int warranty;
        public int Warranty { get {  return warranty; } set {  warranty = value; } }

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

        string processorType;
        public  string ProcessorType { get { return processorType; } set {  processorType = value; } }
        int amountRAM;
        public int AmountRAM { get { return amountRAM; } set { amountRAM = value; } }
        int storageCapacity;
        public int StorageCapacity { get {  return storageCapacity; } set {  storageCapacity = value; } }

        // Konstruktorit

        public Computer() : base()
            { }



    }

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
            Console.WriteLine("Uuden koneen nimi on: " +  tietokone1.Name);


            Console.ReadLine();
        }
    }
}
