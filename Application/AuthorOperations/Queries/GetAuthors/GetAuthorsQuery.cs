using AutoMapper;
using WebApi.DbOperation;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthors
{
	public class GetAuthorsCommand
	{
		private readonly BookStoreDbContext _dbContext;

		private readonly IMapper _mapper;

		public GetAuthorsCommand(BookStoreDbContext dbContext, IMapper mapper)
		{
			_dbContext = dbContext;
			_mapper = mapper;
		}

		public AuthorsView Handle()
		{
			var command = _dbContext.Authors.OrderBy(x=>x.Id);
			AuthorsView returnobj = _mapper.Map<AuthorsView>(command);
			return returnobj;
		}
	}

	public class AuthorsView
	{
		public int Name { get; set; }
		public int LastName { get; set; }
		public DateTime DateofBirth { get; set; }

	}
}
