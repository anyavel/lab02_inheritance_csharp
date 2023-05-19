using System;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace lab2
{
	public class Mailing : Message
	{
        private int additionalAmount;
        private string[] additionalReceivers;

        public Mailing()
            : base()
        {
            additionalAmount = 0;
            additionalReceivers = new string[] {};
        }

        public Mailing(string sNum, string rNum, string txt, int amount, string[] addRec)
            : base(sNum, rNum, txt)
        {
            additionalAmount = amount;
            additionalReceivers = new string[amount];
            for (int i = 0; i < amount; ++i)
            {
                additionalReceivers[i] = addRec[i];
            }
        }

        public override int calculatePrice()
        {
            return base.calculatePrice() * (additionalAmount + 1);
        }

        public void PrintReceivers()
        {
            for(int i = 0; i < additionalAmount; ++i)
            {
                Console.Write($"{additionalReceivers[i]}   ");
            }
        }

        public override string ToString()
        {
            Console.WriteLine($"Additional receivers: ");
            PrintReceivers();
            Console.Write("\n");
            return base.ToString();
        }

        public int AdditionalAmount
        {
            get
            {
                return additionalAmount;
            }
            set
            {
                additionalAmount = value > 0 ? value : 0;
            }
        }

        public string[] AdditionalReceivers
        {
            get
            {
                return additionalReceivers;
            }
            set
            {
                additionalReceivers = value;
            }
        }

        
    }
}

