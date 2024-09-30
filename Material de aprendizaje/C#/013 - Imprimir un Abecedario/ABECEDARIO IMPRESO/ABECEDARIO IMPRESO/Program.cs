using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABECEDARIO_IMPRESO
{
    class Program
    {
        static void Main(string[] args)
        {

            string palabra;
            
            Console.Write("INGRESE UNA PALABRA: ");
            palabra = Console.ReadLine();

            string[] letras = new string[palabra.Length];

            for (int i = 0; i < palabra.Length; i++ )
            {
                letras[i] = palabra.Substring(i, 1);
            }

            for(int i = 0; i < palabra.Length; i++)
            {
                if(letras[i].ToUpper() == "A")
                {
                    IMPRESION_ABECEDARIO impa = new IMPRESION_ABECEDARIO();
                    impa.imprimeA();
                }
                else
                {
                    if(letras[i].ToUpper() == "B")
                    {
                        IMPRESION_ABECEDARIO impb = new IMPRESION_ABECEDARIO();
                        impb.imprimeB();
                    }
                    else
                    {
                        if (letras[i].ToUpper() == "C")
                        {
                            IMPRESION_ABECEDARIO impc = new IMPRESION_ABECEDARIO();
                            impc.imprimeC();
                        }
                        else
                        {
                            if (letras[i].ToUpper() == "D")
                            {
                                IMPRESION_ABECEDARIO impd = new IMPRESION_ABECEDARIO();
                                impd.imprimeD();
                            }
                            else
                            {
                                if(letras[i].ToUpper() == "E")
                                {
                                    IMPRESION_ABECEDARIO impe = new IMPRESION_ABECEDARIO();
                                    impe.imprimeE();
                                }
                                else
                                {
                                    if(letras[i].ToUpper() == "F")
                                    {
                                        IMPRESION_ABECEDARIO impf = new IMPRESION_ABECEDARIO();
                                        impf.imprimeF();
                                    }
                                    else
                                    {
                                        if(letras[i].ToUpper() == "G")
                                        {
                                            IMPRESION_ABECEDARIO impg = new IMPRESION_ABECEDARIO();
                                            impg.imprimeG();
                                        }
                                        else
                                        {
                                            if(letras[i].ToUpper() == "H")
                                            {
                                                IMPRESION_ABECEDARIO imph = new IMPRESION_ABECEDARIO();
                                                imph.imprimeH();
                                            }
                                            else
                                            {
                                                if(letras[i].ToUpper() == "I")
                                                {
                                                    IMPRESION_ABECEDARIO impi = new IMPRESION_ABECEDARIO();
                                                    impi.imprimeI();
                                                }
                                                else
                                                {
                                                    if(letras[i].ToUpper() == "J")
                                                    {
                                                        IMPRESION_ABECEDARIO impj = new IMPRESION_ABECEDARIO();
                                                        impj.imprimeJ();
                                                    }
                                                    else
                                                    {
                                                        if(letras[i].ToUpper() == "K")
                                                        {
                                                            IMPRESION_ABECEDARIO impk = new IMPRESION_ABECEDARIO();
                                                            impk.imprimeK();
                                                        }
                                                        else
                                                        {
                                                            if(letras[i].ToUpper() == "L")
                                                            {
                                                                IMPRESION_ABECEDARIO impl = new IMPRESION_ABECEDARIO();
                                                                impl.imprimeL();
                                                            }
                                                            else
                                                            {
                                                                if(letras[i].ToUpper() == "M")
                                                                {
                                                                    IMPRESION_ABECEDARIO impm = new IMPRESION_ABECEDARIO();
                                                                    impm.imprimeM();
                                                                }
                                                                else
                                                                {
                                                                    if(letras[i].ToUpper() == "N")
                                                                    {
                                                                        IMPRESION_ABECEDARIO impn = new IMPRESION_ABECEDARIO();
                                                                        impn.imprimeN();
                                                                    }
                                                                    else
                                                                    {
                                                                        if(letras[i].ToUpper() == "Ñ")
                                                                        {
                                                                            IMPRESION_ABECEDARIO impñ = new IMPRESION_ABECEDARIO();
                                                                            impñ.imprimeÑ();
                                                                        }
                                                                        else
                                                                        {
                                                                            if(letras[i].ToUpper() == "O")
                                                                            {
                                                                                IMPRESION_ABECEDARIO impo = new IMPRESION_ABECEDARIO();
                                                                                impo.imprimeO();
                                                                            }
                                                                            else
                                                                            {
                                                                                if(letras[i].ToUpper() == "P")
                                                                                {
                                                                                    IMPRESION_ABECEDARIO impp = new IMPRESION_ABECEDARIO();
                                                                                    impp.imprimeP();
                                                                                }
                                                                                else
                                                                                {
                                                                                    if(letras[i].ToUpper() == "Q")
                                                                                    {
                                                                                        IMPRESION_ABECEDARIO impq = new IMPRESION_ABECEDARIO();
                                                                                        impq.imprimeQ();
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if(letras[i].ToUpper() == "R")
                                                                                        {
                                                                                            IMPRESION_ABECEDARIO impr = new IMPRESION_ABECEDARIO();
                                                                                            impr.imprimeR();
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if(letras[i].ToUpper() == "S")
                                                                                            {
                                                                                                IMPRESION_ABECEDARIO imps = new IMPRESION_ABECEDARIO();
                                                                                                imps.imprimeS();
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if(letras[i].ToUpper() == "T")
                                                                                                {
                                                                                                    IMPRESION_ABECEDARIO impt = new IMPRESION_ABECEDARIO();
                                                                                                    impt.imprimeT();
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if(letras[i].ToUpper() == "U")
                                                                                                    {
                                                                                                        IMPRESION_ABECEDARIO impu = new IMPRESION_ABECEDARIO();
                                                                                                        impu.imprimeU();
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if(letras[i].ToUpper() == "V")
                                                                                                        {
                                                                                                            IMPRESION_ABECEDARIO impv = new IMPRESION_ABECEDARIO();
                                                                                                            impv.imprimeV();
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if(letras[i].ToUpper() == "W")
                                                                                                            {
                                                                                                                IMPRESION_ABECEDARIO impw = new IMPRESION_ABECEDARIO();
                                                                                                                impw.imprimeW();
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if(letras[i].ToUpper() == "X")
                                                                                                                {
                                                                                                                    IMPRESION_ABECEDARIO impx = new IMPRESION_ABECEDARIO();
                                                                                                                    impx.imprimeX();
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if(letras[i].ToUpper() == "Y")
                                                                                                                    {
                                                                                                                        IMPRESION_ABECEDARIO impy = new IMPRESION_ABECEDARIO();
                                                                                                                        impy.imprimeY();
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if(letras[i].ToUpper() == "Z")
                                                                                                                        {
                                                                                                                            IMPRESION_ABECEDARIO impz = new IMPRESION_ABECEDARIO();
                                                                                                                            impz.imprimeZ();
                                                                                                                        }

                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


                Console.ReadKey();





        }
    }
}
