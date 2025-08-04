namespace MVCUsingEndPointRoutingEx.Controllers
{
	public class HomeController
	{
		public string Index(string id)
		{
			//return "Index Action Called!";
			return $"value of id is {id}";
		}

		public string About()
		{
			return "About Action Called!";
		}

		public int doAddition(int a, int b)
		{
			return a + b;
		}
	}
}
