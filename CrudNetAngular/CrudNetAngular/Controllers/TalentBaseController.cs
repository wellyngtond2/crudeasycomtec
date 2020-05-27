using CrudNetAngular.DataContracts.Request.TalentBase;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CrudNetAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalentBaseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TalentBaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            var request = new CreateTalentBaseRequest();
            var retorno = await _mediator.Send(request).ConfigureAwait(false);
            return JsonConvert.SerializeObject(retorno);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] CreateTalentBaseRequest talentBaseRequest)
        {
            var retorno = await _mediator.Send(talentBaseRequest).ConfigureAwait(false);
            return JsonConvert.SerializeObject(retorno);
        }

        [HttpPut]
        public async Task<ActionResult<string>> Put([FromBody] UpdateTalentBaseRequest talentBaseRequest)
        {
            var retorno = await _mediator.Send(talentBaseRequest).ConfigureAwait(false);
            return JsonConvert.SerializeObject(retorno);
        }

        [HttpDelete]
        public async Task<ActionResult<string>> Delete([FromBody] DeleteTalentBaseRequest talentBaseRequest)
        {
            var retorno = await _mediator.Send(talentBaseRequest).ConfigureAwait(false);
            return JsonConvert.SerializeObject(retorno);
        }
    }
}