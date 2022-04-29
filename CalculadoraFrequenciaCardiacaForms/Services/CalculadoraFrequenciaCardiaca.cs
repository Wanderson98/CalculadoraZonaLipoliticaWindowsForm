using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFrequenciaCardiacaForms.Services
{
    internal class CalculadoraFrequenciaCardiaca
    {

        public double FrequenciaMaxima { get; private set; }
        public double FrequenciaMinima { get; private set; }


        public void CalcularFreqCardiaca(double freqRepouso, double intensidade, int idade, char sexo)
        {
            if (sexo == 'f')
            {
                if (idade >= 25)
                {
                    FrequenciaMaxima = ((200 - idade + 12) - freqRepouso) * intensidade + freqRepouso;
                    FrequenciaMinima = ((200 - idade - 12) - freqRepouso) * intensidade + freqRepouso;
                }
                else
                {
                    FrequenciaMaxima = ((200 - idade + 10) - freqRepouso) * intensidade + freqRepouso;
                    FrequenciaMinima = ((200 - idade - 10) - freqRepouso) * intensidade + freqRepouso;
                }
                
            }
            else if (sexo == 'm')
            {
                if (idade >= 25)
                {
                    FrequenciaMaxima = ((220 - idade + 12) - freqRepouso) * intensidade + freqRepouso;
                    FrequenciaMinima = ((220 - idade - 12) - freqRepouso) * intensidade + freqRepouso;
                }
                else
                {
                    FrequenciaMaxima = ((220 - idade + 10) - freqRepouso) * intensidade + freqRepouso;
                    FrequenciaMinima = ((220 - idade - 10) - freqRepouso) * intensidade + freqRepouso;
                }

            }
        }
    }
}
