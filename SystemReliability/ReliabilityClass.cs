using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemReliability
{
    static class ReliabilityClass
    {
        public static string Test(double verA = 0.9, double verB = 0.75, double verC = 0.6, int n = 100)
        {
            Random rnd = new Random();
            double[] rez = new double[n];
            double Ver_rab_sist = 0;

            for (int j = 0; j < n; j++)
            {
                //вероятности
                double freqA = 0;
                double freqB = 0;
                double freqC = 0;
                //массивы для записи сгенерированных значений
                double[] znachA = new double[n];
                double[] znachB = new double[n];
                double[] znachC = new double[n];

                //генерирование значений для каждого из трех блоков
                for (int i = 0; i < n; i++)
                {
                    znachA[i] = rnd.NextDouble();
                    znachB[i] = rnd.NextDouble();
                    znachC[i] = rnd.NextDouble();
                }
                //проверка значений
                for (int i = 0; i < n; i++)
                {
                    if (znachA[i] < verA)
                        freqA++;
                    if (znachB[i] < verB)
                        freqB++;
                    if (znachA[i] < verC)
                        freqC++;
                }
                //расчет вероятностей
                freqA /= 100; //A 
                freqB /= 100; //B 
                freqC /= 100; //C 

                double otkaz_rab_A = 1 - freqA;
                double otkaz_rab_B = 1 - freqB;
                double otkaz_rab_A_and_B = otkaz_rab_A * otkaz_rab_B;
                double bezotkaz_rab_A_and_B = 1 - otkaz_rab_A_and_B;
                double Bezotkaz_rab_sist = bezotkaz_rab_A_and_B * freqC;
                rez[j] = Bezotkaz_rab_sist;
            }
            for (int i = 0; i < 100; i++) Ver_rab_sist += rez[i];
            Ver_rab_sist /= 100;

            return string.Format("Вероятность безотказной работы всей цепи равна {0:f4}", Ver_rab_sist);
        }
    }
}
