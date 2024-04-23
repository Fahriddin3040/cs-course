namespace School.Middlewares;

public class ApplicationMiddleware
{
	private readonly RequestDelegate _next;
	private readonly ILogger _logger;

	public ApplicationMiddleware(RequestDelegate next, ILogger<ApplicationMiddleware> logger)
	{
		_next = next;
		_logger = logger;
	}

	public async Task InvokeAsyns(HttpContext context)
	{
		// Do something before the request
		_logger.LogInformation("ApplicationMiddleware executing..");
		await _next(context);
		_logger.LogInformation("ApplicationMiddleware executed..");
		Console.WriteLine("ApplicationMiddleware executed..");
		// Do something after the request
	}
}