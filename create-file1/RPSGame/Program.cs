using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPSGame{

public class player
{


    //class properties, attributes, constructors, and method

    //an attribute is a single piece of data such as age, gender, etc
    // an access modifier controls what parts of the code can access a specific field or class
    private int Playerage = 0;

    //a property is a special C# abstraction that is a combination of a getter and a setter
    public DateTime mydob {get ; set;} = new DateTime(06/05/1996);
    public string Fname {get; set;}
    public string Lname {get; set;}
    public bool Gender {get; set;} //true==female false==male
    public int Wins {get; set;}
    public int losses {get; set;}

    //constructors are methods called the instantate and initialize the class object

    public int GetAge(){
        return Playerage;
    }

    public void SetAge(int Playerage)
    {
        if (Playerage > 110 || Playerage < 18)
        {
            throw new FieldAccessException($"Sorry, you can not play if you are that age");
        }
        else
        {
            this.Playerage = Playerage;
        }
    }


}
}