namespace MVCUsingEndPointRoutingEx.Controllers
{
	public class ABCController
	{
		public string SayHello(string id,string str)
		{
			return $"Say Hello with {id} {str} Called!!!";
		}
	}
}
