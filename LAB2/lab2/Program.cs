namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Message m1 = new Message("+380967894321", "+380987654321", "Походжаючи по веранді, поки там для нього готовили окремий покій " +
                "і поки Стальський третій раз розповідав, якого-то незвичайного гостя має реставрація і як близько " +
                "він з ним знайомий, меценас силкувався відсвіжити в своїй пам’яті образ сього свойого колишнього вчителя.");
            string[] n2 = new string[2] { "+380967894321", "+380987654321" };
            Mailing m2 = new Mailing("+380732141098", "+380501234958", "Походжаючи по веранді, поки там для нього готовили окремий покій " +
                "і поки Стальський третій раз розповідав, якого-то незвичайного гостя має реставрація і як близько " +
                "він з ним знайомий, меценас силкувався відсвіжити в своїй пам’яті образ сього свойого колишнього вчителя.", 2, n2);
            Message m3 = new Message("+380980416677", "+380112201298", "Вона замовкла. Я думав, що, виговорившись, вона вспокоїться. " +
                "Але де там! Я пішов до канцелярії, а вона покликала публічного послугача і веліла йому забрати Орисин куферок, " +
                "а самій Орисі заплатила за місяць і відправила її геть. Орися зо слізьми прибігла до мене до канцелярії " +
                "і розповіла мені, що сталося.");
            string[] n4 = new string[1] { "+380730985060" };
            Mailing m4 = new Mailing("+380632258371", "+380664780102", "Адже ж візьміть хоч би сього Барана! Чи йому треба було " +
                "бути вбійцею?  Чи треба було бути епілептиком? Адже його батько не мав тої слабості, мати не мала, він сам парубком " +
                "був здоровісінький, служив у війську, в моїй компанії був, – відтоді ще ми знайомі з ним. Аж оженився – і пропав " +
                "хлописько. Представте собі: закохався, але то так без пам’яті, що я й не бачив. Попросту млів коло неї. " +
                "Може, се й був початок його хороби, але тоді ніхто про се й не думав. Побралися – мій Баран щасливий, як у раю! " +
                "Думає, що Бога за ноги зловив.", 1, n4);
            Message m5 = new Message("+380735141168", "+380730985060", "Зрештою канцелярійна праця, вічні терміни і тисячі ненастанних " +
                "турбот, що переходили через його голову, не давали йому часу думати ані про ту появу, ані про ту драму, якої спомини " +
                "вона викликала була в його серці. Та ось другого дня по візиті Вагмана одна маленька пригода знов торкнула в його " +
                "душі ту, здавалось, порвану струну.");
            int n = 5;
            Message[] messages = new Message[n];
            messages[0] = m1;
            messages[1] = m2;
            messages[2] = m3;
            messages[3] = m4;
            messages[4] = m5;
            Console.Write("Add new message? (yes or no): ");
            string choice = Console.ReadLine();
            if (choice == "yes")
            {
                Console.Write("Single message(s) or mailing(m)?: ");
                string choice1 = Console.ReadLine();
                if (choice1 == "s")
                {
                    Message m6 = new Message();
                    Console.Write("Enter sender phone number: ");
                    m6.SenderNumber = Console.ReadLine();
                    Console.Write("Enter receiver phone number: ");
                    m6.ReceiverNumber = Console.ReadLine();
                    Console.Write("Enter text: ");
                    m6.Text = Console.ReadLine();
                    Array.Resize(ref messages, n + 1);
                    messages[messages.Length - 1] = m6;
                }
                if (choice1 == "m")
                {
                    Mailing m6 = new Mailing();
                    Console.Write("Enter sender phone number: ");
                    m6.SenderNumber = Console.ReadLine();
                    Console.Write("Enter receiver phone number: ");
                    m6.ReceiverNumber = Console.ReadLine();
                    Console.Write("Enter text: ");
                    m6.Text = Console.ReadLine();
                    Console.Write("Enter number of additional receivers: ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    m6.AdditionalAmount = amount;
                    string[] n6 = new string[amount];
                    for (int i = 0; i < amount; ++i)
                    {
                        n6[i] = Console.ReadLine();
                    }
                    m6.AdditionalReceivers = n6;
                    Array.Resize(ref messages, n + 1);
                    messages[messages.Length - 1] = m6;
                }

            }
            Console.WriteLine("\nAll messages:\n");
            for (int i = 0; i < messages.Length; ++i)
            {
                Console.WriteLine(messages[i]);
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
            Array.Sort(messages);

            Message max = messages[messages.Length - 1];
            Console.WriteLine("\nThe longest message:\n");
            Console.Write(max);
            Console.WriteLine("\n");
            Console.WriteLine($"The londest message is mailing? {max.IsMailing()}\n");

            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine($"\n{i + 1} longest message:\n");
                Console.WriteLine(messages[messages.Length - (i+1)]);
            }

            Console.WriteLine("\nAll messages + Happy New Year!\n");

            for (int i = 0; i < messages.Length; ++i)
            {
                messages[i] += " Happy New Year!";
                Console.WriteLine(messages[i]);
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            }

            Console.ReadLine();


        }
    }

}