using Classexamplev2_Agomaa;
using Classexmaple1v2_Agomaa;
class Print
{
    public void PrintDetails()
    {
        Accept a = new Accept();
        a.AcceptDetails();
        System.Console.Write("Hello " + a.firstname + " " + a.lastname + "!!!\nYou have Created Classes in OOP");
        MyProfile mp = new MyProfile();
        mp.DisplayProfile();

    }


}

