using System;
using System.Security.Authentication;

public class Profile {
    public string Name {get; set;}
    public int Age {get; set;}
    public string City {get; set;}
    public string Country {get; set;}
    public List<string> Hobbies {get; set;}

    //initializer
    public Profile(string name, int age, string city, string country) {
        Name = name;
        Age = age;
        City = city;
        Country = country;
        Hobbies = new List<string>();
    }

    public void add_hobby(string hobby){
        Hobbies.Add(hobby);
    }

    public void view_profile() {
        Console.WriteLine("");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine("Hobbies:");
        Console.WriteLine("");
        for(int i = 0; i < Hobbies.Count(); i++ ){
            Console.WriteLine(Hobbies[i]);
        }
        Console.WriteLine("");
    }
}

class Program {
    public static void Main(){
        Console.WriteLine("Input your name");
        string username = Console.ReadLine();
        Console.WriteLine("Input your age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input your city");
        string city = Console.ReadLine();
        Console.WriteLine("Input your country");
        string country = Console.ReadLine();

        Profile newProfile = new Profile(username, age, city, country);

        while(true){
            newProfile.view_profile();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Add hobby");
            Console.WriteLine("2. Exit Program");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1) {
                Console.WriteLine("Name of your hobby: ");
                newProfile.add_hobby(Console.ReadLine());
            }
            if(choice == 2) {
                break;
            }
            else {
                Console.WriteLine("Please input 1 or 2");
            }
        }
    }
}