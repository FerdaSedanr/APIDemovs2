using APIDemovs2.Models;

namespace APIDemovs2.Service
{
	public interface IusersService
	{
		public  Task<IEnumerable<users>>GetUsersAsync();
	}
}
