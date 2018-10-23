using DiretorSkinner.Tranporte;
using System.Collections.Generic;
using System.ServiceModel;

namespace DiretorSkinner.Interface
{
    [ServiceKnownType(typeof(PessoaPorConceitoDto))]
    public partial interface IDiretorSkinnerNegocio
    {
        [OperationContract]
        List<PessoaPorConceitoDto> ListarPessoaPorConceito();

        [OperationContract]
        PessoaPorConceitoDto ListarPessoaPorConceito(int id);
    }
}
