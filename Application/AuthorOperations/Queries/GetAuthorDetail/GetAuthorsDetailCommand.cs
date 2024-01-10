using AutoMapper;
using WebApi.DbOperation;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthorDetail
{
	public class GetAuthorsDetailCommand
	{
		public int AuthorId { get; set; }

		private readonly BookStoreDbContext _dbContext;

		private readonly IMapper _mapper;

		public GetAuthorsDetailCommand(BookStoreDbContext dbContext, IMapper mapper)
		{
			_dbContext = dbContext;
			_mapper = mapper;
		}

		public AuthorDetailView Handle()
		{
			var command = _dbContext.Authors.SingleOrDefault(x=>x.Id == AuthorId);
			if (command == null)
			{
				throw new InvalidOperationException("Aranan Yazar Bulunamadı");
			}
			AuthorDetailView returnobj = _mapper.Map<AuthorDetailView>(command);
			return returnobj;
		}
	}

	public class AuthorDetailView
	{
		public int Name { get; set; }
		public int LastName { get; set; }
		public DateTime DateofBirth { get; set; }

	} 
}
