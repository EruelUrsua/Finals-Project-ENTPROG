using FinalProject.DataModel;
using Finals.DataModel.Repository;

namespace FinalProject.App.Models.Repositories
{
    public class MedicalRepo : GenericRepo<Medical>, IMedicalRepo
    {
        public MedicalRepo(AppDbContext context) : base(context)
        {
        }

       
    }
}
