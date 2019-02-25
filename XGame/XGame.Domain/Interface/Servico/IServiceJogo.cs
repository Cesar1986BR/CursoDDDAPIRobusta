using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.Jogo;
using XGame.Domain.Interface.Servico.Base;

namespace XGame.Domain.Services
{
    public interface  IServiceJogo : IServiceBase
    {

        IEnumerable<JogoResponse> ListarJogo();

        AdicionarJogoResponse AddJogo(AdicionarJogoRequest request);

        ResponseBase AlterarJogo(AlterarJogoRequest request);

        ResponseBase Excluir(Guid id);
    }
}
