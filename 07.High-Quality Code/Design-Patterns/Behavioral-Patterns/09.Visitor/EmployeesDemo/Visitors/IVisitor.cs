namespace Visitor.EmployeesDemo.Visitors
{
    using Visitor.EmployeesDemo.Employees;

    public interface IVisitor
    {
        void Visit(Employee element);
    }
}
