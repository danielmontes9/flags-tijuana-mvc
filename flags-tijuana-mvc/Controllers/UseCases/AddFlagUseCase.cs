using flags_tijuana_mvc.Data;

namespace flags_tijuana_mvc.Controllers.UseCases
{
    public class AddFlagUseCase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AddFlagUseCase(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

    }
}
