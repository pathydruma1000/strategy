using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDesignPatternsStrategy
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
