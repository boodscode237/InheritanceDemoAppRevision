// See https://aka.ms/new-console-template for more information

namespace inheritanceDemo // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Corolla corolla = new Corolla
            {
                NumberOfDoors = 5
            };

            SmartPhone smartPhone = new SmartPhone();

            LandLine landLine = new LandLine();
            landLine.PlaceCall();

            var smartPhoneApps = smartPhone.Apps;

            Phone phone = new SmartPhone();
            phone.PlaceCall();

            List<Phone> phones = new List<Phone>
            {
                new CellPhone(),
                new LandLine()
            };

            foreach (var tel in phones)
            {
                if (phone is CellPhone cell)
                {
                    cell.Carrier = "";
                }

                if (tel is SmartPhone smartphone)
                {
                    smartphone.ConnectToInternet();
                }
            }

            Console.ReadLine();
        }
    }
}

