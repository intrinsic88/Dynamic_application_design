using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value replace switch (fixed)
            Console.WriteLine(DOW.DayOfWeek(1));

            // Value replace switch (dynamic over time)
            Console.WriteLine(KeyCode.GetKeyMap(38));

            // Value Action switch
            Console.WriteLine(ChangeCase.convert(ChangeCase.Case.Camel, new string[] {"Numeric", "Value", "blah"}));
            Console.WriteLine(ChangeCase.updateCase(ChangeCase.Case.Kebbab, new string[] { "Numeric", "Value", "blah" }));

            upper cc = new upper();

            Console.WriteLine(cc.convert(new string[] { "Numeric", "Value", "blah" }));
            // Value Action if-else ladder
            Console.WriteLine(Billing.calculateTariff(274));

            Rule1 r1 = new Rule1();
            Rules2 r2 = new Rules2();
            Rules4 r4 = new Rules4();
            Rules3 r3 = new Rules3();
            List<IRule> ruleList = new List<IRule>() { r1, r2};
            var sum = ruleList.Sum(x => x.rules(274));
            Console.WriteLine(sum);

            // Varied condition if-else ladder
            Customer anders = new Customer("Anders Hejlsberg", new DateTime(2017, 07, 07), new DateTime(2017, 10, 5), new DateTime(1960, 12, 2));
            Console.WriteLine(anders);
            Console.WriteLine(CustomerDiscount.calculateDiscount(anders)*100+"%");

            // Multiple switch-case statements
            Account dmr = new Account(Account.Type.SavingsAccount, 1, "Dennis M. Ritchie", 1000);
            Console.WriteLine(dmr);
            dmr.Withdraw(500);
            Console.WriteLine(dmr);
            dmr.Deposit(10000);
            Console.WriteLine(dmr);

            // Dynamically creating object of a type
            Circle circle = (Circle)ShapeCreator.NewShape("circle");
            circle.CenterPoint = new Point(10, 10);
            circle.Radius = 10;
            Console.WriteLine(circle.calculateArea());

            Rectangle rectangle = (Rectangle)ShapeCreator.NewShape("rectangle");
            rectangle.StartPoint = new Point(10, 10);
            rectangle.EndPoint = new Point(20, 20);
            Console.WriteLine(rectangle.calculateArea());
            


        }
    }
}
