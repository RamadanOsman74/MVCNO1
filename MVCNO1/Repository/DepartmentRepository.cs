using MVCNO1.Models;

namespace MVCNO1.Repository
{
    public class DepartmentRepository
    {
        // crud op :
        ITIDbContext context = new ITIDbContext();
        public List<Department> GetAll()
        {
           return context.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return context.Departments.FirstOrDefault(s=>s.Id== id);   
        }

        public void Edit (int id, Department dept)
        {
            var Dept = context.Departments.FirstOrDefault(s => s.Id == id);
            Dept.Name= dept.Name;
            Dept.Address=dept.Address;
            Dept.Age=dept.Age;
            Dept.ManagerName=dept.ManagerName;
            context.Departments.Update(Dept);
            context.SaveChanges();
        }
        public void Delete (int id)
        {
        
        
        
        }




    }
}
