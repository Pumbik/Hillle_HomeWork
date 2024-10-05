using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
	internal class CreditCard
	{
		public string IBAN {  get; set; } // UA26004233908898233
		public string CardNumber { get; set; } // 2620-4441-3454-2345
		public decimal CardAmount { get; set; }
		public int CVC { get; set; }	// 111

		public CreditCard(string iban, string cardnumber, int cvc, decimal amount) 
		{
			IBAN = iban;
			CardNumber = cardnumber;
			CVC = cvc;
			CardAmount = amount;
		}

		public void CreditCardInfo()
		{
            Console.WriteLine($"IBAN: {IBAN}");
            Console.WriteLine($"Счет: {CardNumber}");
			Console.WriteLine($"Код безопасности: {CVC}");
            Console.WriteLine($"Баланс: ${CardAmount}\n");
		}

		public static CreditCard operator +(CreditCard card, decimal amount)
		{
			card.CardAmount += amount;
			return card;
		}

		public static CreditCard operator -(CreditCard card, decimal amount) 
		{
			card.CardAmount -= amount; 
			return card;
		}

		public static bool operator ==(CreditCard card1 ,CreditCard card2)
		{
			return card1.CVC == card2.CVC;
		}

		public static bool operator >(CreditCard card1 ,CreditCard card2)
		{
			return card1.CardAmount > card2.CardAmount;
		}

		public static bool operator <(CreditCard card1, CreditCard card2)
		{
			return card1.CardAmount < card2.CardAmount;
		}

		public static bool operator !=(CreditCard card1, CreditCard card2)
		{
			return card1.CardAmount != card2.CardAmount;
		}

		public override bool Equals(object? obj)
		{
			if (obj is CreditCard)
			{
				CreditCard card = (CreditCard)obj;
				return this.CardAmount == card.CardAmount;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return CardAmount.GetHashCode();
		}
	}
}
