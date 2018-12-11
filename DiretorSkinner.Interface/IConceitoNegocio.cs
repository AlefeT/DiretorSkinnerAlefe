using DiretorSkinner.Tranporte;
using DiretorSkinner.Util.Acesso;
using System.Collections.Generic;
using System.ServiceModel;

namespace DiretorSkinner.Interface
{
    [ServiceKnownType(typeof(ConceitoDto))]
    [ServiceKnownType(typeof(TipoAcesso))]
    public partial interface IDiretorSkinnerNegocio
    {
        [OperationContract]
        List<ConceitoDto> ListarConceitos();

        [OperationContract]
        ConceitoDto ListarConceito(int id);

        [OperationContract]
        void SalvarConceito(ConceitoDto conceito);

        [OperationContract]
        void DeletarConceito(ConceitoDto conceito);
    }
}
