using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScientificLaboratory.Data;
using ScientificLaboratory.Models;

namespace ScientificLaboratory.Pages.Researchers
{
	public class DetailsModel : PageModel
	{
		private readonly LaboratoryContext _context;

		public DetailsModel(LaboratoryContext context)
		{
			_context = context;
		}

		public Researcher Researcher { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var researcher = await _context.Researchers.FirstOrDefaultAsync(m => m.ResearcherId == id);
			if (researcher == null)
			{
				return NotFound();
			}
			else
			{
				Researcher = researcher;
			}
			return Page();
		}
	}
}