namespace DefiningClasses
{
    using Models;
    using System;

    class GSM_Test
    {
        static void Main()
        {
            Battery firstBattery = new Battery("A2000", 500, 200, BatteryType.LiIon);
            Battery secondBattery = new Battery("B3000", 600, 300, BatteryType.NiCd);
            Battery thirdBattery = new Battery("C1000", 400, 100, BatteryType.NiMH);

            Display firstDisplay = new Display(5, 16000000);
            Display secondDisplay = new Display(4, 16000000);
            Display thirdDisplay = new Display(4.5, 16000000);

            //// GSM with all parameters

            GSM[] phones = new GSM[]
            {
                GSM.IPhone4S,
                new GSM("Idol 2", "Alcatel", 200, "P.Petrov", firstBattery, firstDisplay),
                new GSM("Galaxy Core 2", "Samsung", 250, "I.Ivanova", secondBattery, thirdDisplay),
                new GSM("P8 lite", "Huawei", 220, "P.Angelov", firstBattery, firstDisplay),
                new GSM("Lumia 800", "Nokia", 300, "A.Tokev", thirdBattery, secondDisplay)
            };

            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
                Console.WriteLine();
            }

            //GSM with some missing parameters

           GSM[] secondPhonesArr = new GSM[]
           {
                new GSM("Idol 2", "Alcatel", 200),
                new GSM("Galaxy Core 2", "Samsung", null, "I.Ivanova"),
                new GSM("P8 lite", "Huawei", 220, "P.Angelov", firstBattery, firstDisplay),
                new GSM("Lumia 800", "Nokia", 300, "A.Tokev", thirdBattery, secondDisplay)
           };

            foreach (var phone in secondPhonesArr)
            {
                Console.WriteLine(phone);
                Console.WriteLine();
            }

            // Call history Tests

            GSM somePhone = new GSM("3310", "Nokia");
            somePhone.AddCall(new Call(new DateTime(2005, 12, 24), "0888123456", 45));
            somePhone.AddCall(new Call(new DateTime(2005, 12, 24), "0888111111", 15));
            somePhone.AddCall(new Call(new DateTime(2005, 12, 24), "0888222222", 55));
            somePhone.AddCall(new Call(new DateTime(2005, 12, 24), "0888333333", 65));
            somePhone.AddCall(new Call(new DateTime(2005, 12, 24), "0888444444", 110));
            somePhone.AddCall(new Call(new DateTime(2005, 12, 24), "0888555555", 20));
            somePhone.AddCall(new Call(new DateTime(2005, 12, 24), "0888666666", 40));

            somePhone.ShowCallHistory();
            Console.WriteLine(somePhone.CallsPrice(0.37));
            Console.WriteLine();

            somePhone.RemoveCall(5);

            somePhone.ShowCallHistory();
            Console.WriteLine(somePhone.CallsPrice(0.37));
            Console.WriteLine();

            somePhone.ClearCallHistory();
            somePhone.ShowCallHistory();
        }
    }
}
