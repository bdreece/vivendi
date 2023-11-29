using MediatR;

namespace Vivendi.UI.Controllers;

internal abstract class Controller : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly IMediator _mediator;

    protected ISender Sender => _mediator;
    protected IPublisher Publisher => _mediator;
    protected ILogger Logger { get; private init; }

    protected Controller(IMediator mediator, ILogger logger)
    {
        (_mediator, Logger) = (mediator, logger);
    }
}
