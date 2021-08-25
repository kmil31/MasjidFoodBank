using System;
using System.Collections.Generic;
using System.Text;
using Google.Cloud.Firestore;

namespace god_does_it.Model
{
    public sealed class Firebase
    {
        private static FirestoreDb db;
        private Firebase() { }
        private static Firebase instance = null;
        public static Firebase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Firebase();
                    CreateDatabase();
                    Console.WriteLine("Created Cloud Firestore client with project ID: {0}", "foodbank_masjid");
                }
                    
                return instance;
            }

        } 

        private static void CreateDatabase()
        {
            db = FirestoreDb.Create("foodbank-masjid");
        }

        public static void CreateDocument(string name, string IC, string address)
        {
            string DateOfRegistration = DateTime.Today.ToShortDateString();
            DocumentReference Doc = db.Collection("users").Document(IC);
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {
                {"name",name },
                {"address",address },
                {"date", DateOfRegistration }
            };

            Doc.SetAsync(data1).Wait();
            Console.WriteLine("Success");
        }

        public static Boolean CheckDatabase(String IC)
        {
            //implements an Async function that connects to online DB and returns value
            return false;
        }
        public static void RegisterToDatabase(String name, String IC, String Address)
        {
            //implement an Async Function that connects to online DB and registers user
        }



    }
}
