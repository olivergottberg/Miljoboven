namespace Miljöboven.Models;

public interface IEnvironmentRepository
{
    IQueryable<Errand> Errands { get; }
    IQueryable<Department> Departments { get; }
    IQueryable<ErrandStatus> ErrandStatuses { get; }
    IQueryable<Employee> Employees { get; }
    IQueryable<Picture> Pictures { get; }
    IQueryable<Sample> Samples { get; }
    IQueryable<Sequence> Sequences { get; }

    Errand GetErrandDetail(int id);

    void SaveErrand(Errand errand);
}