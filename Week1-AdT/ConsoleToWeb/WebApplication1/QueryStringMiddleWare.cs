namespace WebApplication1
{
    public class QueryStringMiddleWare
    {
        private RequestDelegate _next;
        public QueryStringMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
        public async void Invoke (HttpContext context)
        {

        }
    }
}
