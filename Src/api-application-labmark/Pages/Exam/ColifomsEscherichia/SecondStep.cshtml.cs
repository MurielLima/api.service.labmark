using Labmark.Domain.Modules.Exam.Controllers;
using Labmark.Domain.Modules.Exam.Infrastructure.Models.Dtos;
using Labmark.Domain.Modules.Sample.Infrastructure.Models.Dtos;
using Labmark.Domain.Modules.Exam.Infrastructure.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Labmark.Pages.Test.ColifomsEscherichia
{
    public class SecondStepModel : PageModel
    {


        [BindProperty]
        public int _selectedDilutionId { get; set; }

     

        [BindProperty]
        public DilutionSampleDto _dilutionSampleDto { get; set; }

        public IActionResult OnGet()
        {
            
            return Page();
        }

        private readonly IEscherichiaColiformsController _escherichiaColiformsController;


        [BindProperty]
        public ColiformsEscherichiaDto _colifomsEscherichia { get; set; }

        public SecondStepModel(IEscherichiaColiformsController colifomsEscherichiaController)
        {
            _escherichiaColiformsController = colifomsEscherichiaController;
        }

        public async Task<IActionResult> OnPostAsync(int colifomsEscherichiaId)
        {
            _colifomsEscherichia.Id = colifomsEscherichiaId;
            await _escherichiaColiformsController.Update(_colifomsEscherichia);

            return Redirect($"/Exam/ColifomsEscherichia/ThirdStep/?colifomsEscherichiaId={_colifomsEscherichia.Id}");
        }
    }
}
