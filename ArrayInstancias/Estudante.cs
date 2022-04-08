using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayInstancias
{
    class Estudante
    {
        public String Nome { get; set; }

        public String Email { get; set; }

        public override string ToString()
        {
            return " Nome do estudante: "
                + Nome
                +" email do estudante: "
                + Email;
        }
    }
}
