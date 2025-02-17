using Miljöboven.Models;

namespace Miljoboven4.Models
{
    public class EFEnvironmentRepository : IEnvironmentRepository
    {
        private readonly ApplicationDbContext context;

        public EFEnvironmentRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Department> Departments => context.Departments;
        public IQueryable<Employee> Employees => context.Employees;
        public IQueryable<Errand> Errands => context.Errands;
        public IQueryable<ErrandStatus> ErrandStatuses => context.ErrandStatuses;
        public IQueryable<Picture> Pictures => context.Pictures;
        public IQueryable<Sample> Samples => context.Samples;
        public IQueryable<Sequence> Sequences => context.Sequences;

        public Errand GetErrandDetail(int Id)
        {
            var errand = Errands.FirstOrDefault(e => e.ErrandId == Id);
            return errand;
        }

        public void SaveErrand(Errand errand) 
        {
            if(errand.ErrandId == 0)
            {
                var sequence = context.Sequences.FirstOrDefault(e => e.ID == 1);

                errand.RefNumber = $"{DateTime.Now.Year}-45-{sequence.CurrentValue}";
                errand.StatusId = "S_A";
                
                context.Errands.Add(errand);

                sequence.CurrentValue++;
            }
            context.SaveChanges();
        }
    }
}
