namespace tmp
{
    public class MyMiddleware : IMiddleware
    {
        public async Task  InvokeAsync(HttpContext context, RequestDelegate next)
        {
            context.Response.Headers.Add("X-My-Header", "MyMiddleware");

            await next(context);
        }
    }
}