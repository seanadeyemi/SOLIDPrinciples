namespace DependencyInversionPrinciple
{
    public interface ICourse
    {
        IDepartment department { get; set; }
        int Id { get; set; }
        string Name { get; set; }

       
    }
}