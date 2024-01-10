using FluentValidation;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthorDetail
{
	public class GetAuthorsDetailCommandValidator : AbstractValidator<GetAuthorsDetailCommand>
	{
		public GetAuthorsDetailCommandValidator()
		{
			RuleFor(x => x.AuthorId).GreaterThan(0);
		}
	}
}
