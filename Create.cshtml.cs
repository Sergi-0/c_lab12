using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScientificLaboratory.Data;
using ScientificLaboratory.Models;

namespace ScientificLaboratory.Pages.Researchers
{
	public class CreateModel : PageModel
	{
		private readonly LaboratoryContext _context;

		public CreateModel(LaboratoryContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Researcher Researcher { get; set; }

		public IActionResult OnGet()
		{
			return Page();
		}

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_context.Researchers.Add(Researcher);
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
	}
}