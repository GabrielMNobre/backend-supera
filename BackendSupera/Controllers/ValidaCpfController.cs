using BackendSupera.Model;
using BackendSupera.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendSupera.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValidaCpfController : ControllerBase
    {
        [HttpPost(Name = "PostCpf")]
        public String PostCpf(Cpf request)
        {
            Cpf cpf = ValidaCpfService.ValidaCpf(request);

            if (cpf.Valido)
            {
                return "True";
            } else
            {
                return "False";
            }

        }
    }
}
