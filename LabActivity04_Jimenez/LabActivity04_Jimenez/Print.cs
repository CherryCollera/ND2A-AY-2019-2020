

namespace LabActivity04_Jimenez

{
    class Print
    {
        public void PrintDetails()
        {
            Accept a = new Accept();
            a.AcceptDetails();

            System.Console.Write("Hello" + a.firstname + "" + a.lastname + "!!!\nYou have created classes in OOP");
            MyProfile mp = new MyProfile();
            mp.DisplayProfile();
        }
    }
}
