using Classexample1_delarosa;
    class Print
    {
    public void PrintDetails()
    {
        Accept a = new Accept();
        a.AcceptDetails();

        System.Console.Write("Hello " + a.firstname+" " + a.lastname+"!!!\nYou have Created Classes in OOP");
        MyProfile mp = new MyProfile();
        mp.DesplayProfile();
        System.Console.ReadLine();

    }


}

