﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiretorSkinner.Util.Acesso
{
    public enum TipoAcesso
    {
        NoSql = 1,
        Sql = 2
    }

    public enum TipoCarga
    {
        Incluir = 0,
        Alterar = 1,
        Excluir = 2,
        Leitura = 3
    }
}
