using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FoodStoreMarket.Application.Common.Behaviours;

public class PerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> 
    where TRequest : IRequest<TResponse>
{
    private readonly ILogger<TRequest> _logger;
    private readonly Stopwatch _stopwatch;

    public PerformanceBehaviour(ILogger<TRequest> logger, Stopwatch stopwatch)
    {
        _logger = logger;
        _stopwatch = stopwatch;
    }
    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        _stopwatch.Start();

        var response = await next();
        
        _stopwatch.Stop();

        var elapsed = _stopwatch.ElapsedMilliseconds;

        if (elapsed > 500)
        {
            var requestName = typeof(TRequest).Name;
        
            _logger.LogInformation($"FoodStoreMarket Long Running Request: {requestName} ({elapsed}ms) {request}");
        }

        return response;
    }
}