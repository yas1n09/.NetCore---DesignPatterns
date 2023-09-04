using DesignPattern.ChainOfResponsibilty.Models;

namespace DesignPattern.ChainOfResponsibilty.ChainOfResponsibility
{
    public abstract class Employee
    {

        protected Employee NextApprover;
        public void SetNextApprover(Employee Supervisor)
        {
            this.NextApprover = Supervisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);

    }
}
