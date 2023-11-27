namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyMembers GrandFatherOne = new FamilyMembers()
            {
                FullName = "Иванов Иван Иванович",
                Age = 71,
                Gender = Gender.man
            };

            FamilyMembers GrandFatherSecond = new FamilyMembers()
            {
                FullName = "Петров Петр Петрович",
                Age = 70,
                Gender = Gender.man
            };

            FamilyMembers GrandMotherOne = new FamilyMembers()
            {
                FullName = "Иванова Марина Сергеевна",
                Age = 68,
                Gender = Gender.woman,
                Partner = GrandFatherOne
            };

            FamilyMembers GrandMotherSecond = new FamilyMembers()
            {
                FullName = "Петрова Инна Александровна",
                Age = 69,
                Gender = Gender.woman,
                Partner = GrandFatherSecond
            };

            GrandFatherOne.Partner = GrandMotherOne;
            GrandFatherSecond.Partner = GrandMotherSecond;

            FamilyMembers Mother = new FamilyMembers()
            {
                FullName = "Петрова Анна Петровна",
                Age = 36,
                Gender = Gender.woman,
                Mother = GrandMotherOne,
                Father = GrandFatherOne,
            };

            FamilyMembers Father = new FamilyMembers()
            {
                FullName = "Петров Сергей Петрович",
                Age = 40,
                Gender = Gender.man,
                Mother = GrandMotherSecond,
                Father = GrandFatherSecond,
                Partner = Mother
            };

            FamilyMembers Daughter = new FamilyMembers()
            {
                FullName = "Петрова Дарья Сергеевна",
                Age = 9,
                Gender = Gender.woman,
                Mother = Mother,
                Father = Father
            };

            Mother.Partner = Father;

            //FamilyMembers[] GrandMothers = Daughter.GetGrandMotherName();
            //Console.WriteLine(GrandMothers[0]?.FullName+ " " + GrandMothers[0]?.Age);
            //Console.WriteLine(GrandMothers[1]?.FullName + " " + GrandMothers[1]?.Age);

            //Console.WriteLine("Муж: " + Father.FullName + "       " + "Жена: " + Father?.Partner?.FullName); 

            GetPartner(GrandFatherOne);
            Console.WriteLine();
            Console.WriteLine();
            GetPartnerAndParents(Mother);
            Console.WriteLine();

            void GetPartner(FamilyMembers FamilyMembers)
            {
                Console.WriteLine();
                Console.WriteLine(" _______________________________________________________________________________________________________ ");
                Console.WriteLine("|  Данные   |                Человек                |                     Супруг(а)                     |");
                Console.WriteLine("|_______________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|   ФИО     |          {FamilyMembers?.FullName}         |            {FamilyMembers?.Partner?.FullName}               |");
                Console.WriteLine("|_______________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|  Возраст  |                 {FamilyMembers?.Age}                    |                        {FamilyMembers?.Partner?.Age}                         |");
                Console.WriteLine("|_______________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|    Пол    |                  {FamilyMembers?.Gender}                  |                       {FamilyMembers?.Partner?.Gender}                       |");
                Console.WriteLine("|_______________________________________________________________________________________________________|");
            }


            void GetPartnerAndParents (FamilyMembers FamilyMembers)
            {
                Console.WriteLine(" __________________________________________________________________________________________________________________ ");
                Console.WriteLine();
                Console.WriteLine($"|     Человек     |  Ф.И.О.: {FamilyMembers.FullName}         ->   Возраст: {FamilyMembers.Age}          ->   Пол: {FamilyMembers.Gender} ");
                Console.WriteLine("|__________________________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|   Супруг(а):    |  Ф.И.О.: {FamilyMembers?.Partner?.FullName}         ->   Возраст: {FamilyMembers?.Partner?.Age}         ->   Пол: {FamilyMembers?.Partner?.Gender}");
                Console.WriteLine("|__________________________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|      Отец:      |  Ф.И.О.: {FamilyMembers?.Father?.FullName}         ->   Возраст: {FamilyMembers?.Father?.Age}         ->   Пол: {FamilyMembers?.Father?.Gender}");
                Console.WriteLine("|__________________________________________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine($"|      Мать:      |  Ф.И.О.: {FamilyMembers?.Mother?.FullName}         ->    Возраст: {FamilyMembers?.Mother?.Age}         ->   Пол: {FamilyMembers?.Mother?.Gender}");
                Console.WriteLine("|__________________________________________________________________________________________________________________|");
            }

        }
    }
}
