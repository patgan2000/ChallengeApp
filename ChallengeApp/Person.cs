using System;

namespace ChallengeApp;

public abstract class Person
{
    public Person()
        : this ("no name")
    {
        
    }

    public Person(string name)
        : this (name, "NO surname")
    {
        this.name = "no name";
    }

    public Person(string name, string surname)
        : this (name, surname, 'M')
    {
        this.name = name;
        this.surname = surname;
    }

    public Person(string name, string surname, char sex)
        : this (name, surname, sex, 20)
    {
        this.name = name;
        this.surname= surname;
        this.sex = sex;
    }

    public Person(string name, string surname, char sex, int age)

    {
        this.name= name;
        this.surname= surname;
        this.sex= sex;
        this.age= age;
    }


    public string name { get; private set; }

    public string surname { get; private set; }
    
    public char sex { get; private set; }

    public int age { get; private set; }



}

