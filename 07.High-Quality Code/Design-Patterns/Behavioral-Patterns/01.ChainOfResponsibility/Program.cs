﻿namespace ChainOfResponsibility
{
    public static class Program
    {
        public static void Main()
        {
            Approver teamLead = new TeamLead();
            Approver vicePresident = new VicePresident();
            Approver chiefExecutiveOfficer = new President();

            teamLead.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(chiefExecutiveOfficer);

            var purchase = new Purchase(2034, 350.00);
            teamLead.ProcessRequest(purchase);

            purchase = new Purchase(2035, 32590.10);
            teamLead.ProcessRequest(purchase);

            purchase = new Purchase(2036, 122100.00);
            teamLead.ProcessRequest(purchase);
        }
    }
}
