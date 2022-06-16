using FluentValidation;
using ImtahanaHazirliq.Models;
using ImtahanaHazirliq.ViewModels;

namespace ImtahanaHazirliq.Validators
{
	public class NoticeBoardValidation:AbstractValidator<NoticeBoard>
	{
		public NoticeBoardValidation()
		{
			RuleFor(f => f.DateTime).NotEmpty().NotNull();
			RuleFor(f => f.Description).NotNull().NotEmpty().MaximumLength(50).WithMessage("50 cox ola bilmez");
		}
	}
}
