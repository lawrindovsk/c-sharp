using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitsOnSharp_
{
    class Program
    {
        static void Main(string[] args)
        {
			//Gustavo Laurindo dos Santos (082230032)
			//Arthur Benevides dos Santos (082230016)
			//Lucas da Silva Macedo (082230037)
			//Projeto - Calculo de Limites em CSharp.

			//Instaciando Variáveis;

			int qtdTermo = 0;
			int qtdTermoNum = 0;
			int qtdTermoDen = 0;
			int x = 0;

			double valueX = 0;
			double resultFinalExp = 0;
			double resultFinalNum = 0;
			double resultFinalDen = 0;
			double resultFinalLateral = 0;
			double resultFinalLateralMenor = 0;
			double resultFinalLateralMaior = 0;
			double resultFinalNumeradorMenor = 0;
			double resultFinalDenMenor = 0;
			double resultFinalNumeradorMaior = 0;
			double resultFinalDenMaior = 0;


			string choose = " ", expNum = " ", expDen = " ", expressao = " ";
			//Fim Instaciando Variáveis;

			//Calculadora;
			Console.WriteLine("Olá, bem-vindo a Calculadora de Limites");
			Console.WriteLine("Não sabe como usar?, utilize o manual online, link do manual:" +
				"https://cefsaedu-my.sharepoint.com/:w:/g/personal/082230016_faculdade_cefsa_edu_br/EYhKm2QgXCdPiYhXiasMOTUBD4cfM8pLS5akzzKJaX5kRw?rtime=IPirNlrt20g ");

			Console.WriteLine("Copiar o link no seu navegador");
			
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine("Integrantes: Gustavo Laurindo Dos Santos - Matrícula: 082230032");
			Console.WriteLine("Arthur Benevides dos Santos - Matrícula: 082230016");
			Console.WriteLine("Lucas da Silva Macedo - Matrícula: 082230037");
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("O seu cálculo possuí fração? (Digite Sim ou Não)");
			choose = Console.ReadLine().ToUpper();

			if (choose == "SIM" || choose == "SIM" || choose == "s" || choose == "S")
			{
				Console.WriteLine("Digite, quantos termos existem no numerador da função?");
				qtdTermoNum = Int32.Parse(Console.ReadLine());

				Console.WriteLine("Digite, quantos termos existem no denominador da função?");
				qtdTermoDen = Int32.Parse(Console.ReadLine());

				String[] vOperadorDen = new string[qtdTermoDen - 1];
				String[] vOperadorNum = new string[qtdTermoNum - 1];
				String[] valorNum = new string[qtdTermoNum];
				String[] valorDen = new string[qtdTermoDen];
				double[] resultNumerador = new double[qtdTermoNum];
				double[] resultDenominador = new double[qtdTermoDen];

				for (int termoNum = 0; termoNum < qtdTermoNum; termoNum++)
				{
					Console.WriteLine($"Digite o valor do {termoNum + 1}º termo do numerador da função: ");
					expNum = Console.ReadLine();

					valorNum[termoNum] = expNum;

					if (termoNum != qtdTermoNum - 1)
					{
						Console.WriteLine($"Digite o valor da {termoNum + 1}ª operação: ");
						vOperadorNum[termoNum] = Console.ReadLine();
					}
				}

				for (int termoDen = 0; termoDen < qtdTermoDen; termoDen++)
				{
					Console.WriteLine($"Digite o valor do {termoDen + 1}º termo do denominador da função: ");
					expDen = Console.ReadLine();

					valorDen[termoDen] = expDen;

					if (termoDen != qtdTermoDen - 1)
					{
						Console.WriteLine($"Digite o valor da {termoDen + 1}ª operação: ");
						vOperadorDen[termoDen] = Console.ReadLine();
					}
				}

				Console.WriteLine(" ");

				for (int parte = 0; parte < qtdTermoNum; parte++)
				{
					if (parte != qtdTermoNum - 1)
					{
						Console.Write($"  {valorNum[parte]} {vOperadorNum[parte]}");
					}
					else
						Console.Write($" {valorNum[parte]}");
				}

				if (qtdTermoNum == 3 || qtdTermoDen == 3)
				{
					Console.WriteLine("\n------------------");
				}
				else
					Console.WriteLine("\n-----------");

				for (int parte = 0; parte < qtdTermoDen; parte++)
				{
					if (parte != qtdTermoDen - 1)
					{
						Console.Write($"  {valorDen[parte]} {vOperadorDen[parte]}");
					}
					else
						Console.Write($" {valorDen[parte]}");
				}

				Console.WriteLine(" ");

				Console.WriteLine("\nDigite o valor que X está tendendo no Limite:");
				valueX = double.Parse(Console.ReadLine());

				for (int parte = 0; parte < qtdTermoNum; parte++)
				{
					double resultNum = 0;

					if (valorNum[parte].ToUpper().IndexOf("X") == -1)
					{
						resultNum = double.Parse(valorNum[parte]);
					}
					else
					{
						//Algoritmo responsável para escrever expoente de uma forma mais facil;
						String[] separado = valorNum[parte].ToUpper().Split('X');

						if (separado.Length == 2 && separado[1] != "")
						{
							resultNum = Math.Pow(valueX, double.Parse(separado[1]));
							resultNum = resultNum * double.Parse(separado[0]);
						}
						else
							resultNum = valueX * double.Parse(separado[0]);
					}

					resultNumerador[parte] = resultNum;

				}

				if (vOperadorNum.Length == 1)
				{
					if (vOperadorNum[0] == "+")
					{
						resultFinalNum = resultNumerador[0] + resultNumerador[1];
					}
					else
						resultFinalNum = resultNumerador[0] - resultNumerador[1];
				}

				if (vOperadorNum.Length == 2)
				{
					if (vOperadorNum[0] == "+" && vOperadorNum[1] == "+")
					{
						resultFinalNum = resultNumerador[0] + resultNumerador[1] + resultNumerador[2];
					}
					else if (vOperadorNum[0] == "+" && vOperadorNum[1] == "-")
					{
						resultFinalNum = resultNumerador[0] + resultNumerador[1] - resultNumerador[2];
					}
					else if (vOperadorNum[0] == "-" && vOperadorNum[1] == "-")
					{
						resultFinalNum = resultNumerador[0] - resultNumerador[1] - resultNumerador[2];
					}
					else if (vOperadorNum[0] == "-" && vOperadorNum[1] == "+")
					{
						resultFinalNum = resultNumerador[0] - resultNumerador[1] + resultNumerador[2];
					}
				}

				for (int parte = 0; parte < qtdTermoDen; parte++)
				{
					double resultadoDenominador = 0;

					if (valorDen[parte].ToUpper().IndexOf("X") == -1)
					{
						resultadoDenominador = double.Parse(valorDen[parte]);
					}
					else
					{
						String[] separado = valorDen[parte].ToUpper().Split('X');

						if (separado.Length == 2 && separado[1] != "")
						{
							resultadoDenominador = Math.Pow(valueX, double.Parse(separado[1]));
							resultadoDenominador = resultadoDenominador * double.Parse(separado[0]);
						}
						else
							resultadoDenominador = valueX * double.Parse(separado[0]);

					}

					resultDenominador[parte] = resultadoDenominador;
				}


				if (vOperadorDen.Length == 1)
				{
					if (vOperadorDen[0] == "+")
					{
						resultFinalDen = resultDenominador[0] + resultDenominador[1];
					}
					else
						resultFinalDen = resultDenominador[0] - resultDenominador[1];
				}

				if (vOperadorDen.Length == 2)
				{
					if (vOperadorDen[0] == "+" && vOperadorDen[1] == "+")
					{
						resultFinalDen = resultDenominador[0] + resultDenominador[1] + resultDenominador[2];
					}
					else if (vOperadorDen[0] == "+" && vOperadorDen[1] == "-")
					{
						resultFinalDen = resultDenominador[0] + resultDenominador[1] - resultDenominador[2];
					}
					else if (vOperadorDen[0] == "-" && vOperadorDen[1] == "-")
					{
						resultFinalDen = resultDenominador[0] - resultDenominador[1] - resultDenominador[2];
					}
					else if (vOperadorDen[0] == "-" && vOperadorDen[1] == "+")
					{
						resultFinalDen = resultDenominador[0] - resultDenominador[1] + resultDenominador[2];
					}
				}

				Console.WriteLine(" ");

				if ((resultFinalNum == 0 && resultFinalDen == 0) || resultFinalDen == 0)
				{

					for (double valorLimite = 0.1; valorLimite <= valueX; valorLimite = valorLimite / 10)
					{
						double lateralMenor = valueX - valorLimite;

						if (x < 5)
						{

							if (lateralMenor < valueX)
							{

								for (int parte = 0; parte < qtdTermoNum; parte++)
								{
									double resultadoNumerador = 0;

									if (valorNum[parte].ToUpper().IndexOf("X") == -1)
									{
										resultadoNumerador = double.Parse(valorNum[parte]);
									}
									else
									{
										String[] separado = valorNum[parte].ToUpper().Split('X');

										if (separado.Length == 2 && separado[1] != "")
										{
											resultadoNumerador = Math.Pow(lateralMenor, double.Parse(separado[1]));
											resultadoNumerador = resultadoNumerador * double.Parse(separado[0]);
										}
										else
											resultadoNumerador = lateralMenor * double.Parse(separado[0]);
									}

									resultNumerador[parte] = resultadoNumerador;

								}

								if (vOperadorNum.Length == 1)
								{
									if (vOperadorNum[0] == "+")
									{
										resultFinalNumeradorMenor = resultNumerador[0] + resultNumerador[1];
									}
									else
										resultFinalNumeradorMenor = resultNumerador[0] - resultNumerador[1];
								}

								if (vOperadorNum.Length == 2)
								{
									if (vOperadorNum[0] == "+" && vOperadorNum[1] == "+")
									{
										resultFinalNumeradorMenor = resultNumerador[0] + resultNumerador[1] + resultNumerador[2];
									}
									else if (vOperadorNum[0] == "+" && vOperadorNum[1] == "-")
									{
										resultFinalNumeradorMenor = resultNumerador[0] + resultNumerador[1] - resultNumerador[2];
									}
									else if (vOperadorNum[0] == "-" && vOperadorNum[1] == "-")
									{
										resultFinalNumeradorMenor = resultNumerador[0] - resultNumerador[1] - resultNumerador[2];
									}
									else if (vOperadorNum[0] == "-" && vOperadorNum[1] == "+")
									{
										resultFinalNumeradorMenor = resultNumerador[0] - resultNumerador[1] + resultNumerador[2];
									}
								}

								for (int parte = 0; parte < qtdTermoDen; parte++)
								{
									double resultadoDenominador = 0;

									if (valorDen[parte].ToUpper().IndexOf("X") == -1)
									{
										resultadoDenominador = double.Parse(valorDen[parte]);
									}
									else
									{
										String[] separado = valorDen[parte].ToUpper().Split('X');

										if (separado.Length == 2 && separado[1] != "")
										{
											resultadoDenominador = Math.Pow(lateralMenor, double.Parse(separado[1]));
											resultadoDenominador = resultadoDenominador * double.Parse(separado[0]);
										}
										else
											resultadoDenominador = lateralMenor * double.Parse(separado[0]);

									}

									resultDenominador[parte] = resultadoDenominador;
								}


								if (vOperadorDen.Length == 1)
								{
									if (vOperadorDen[0] == "+")
									{
										resultFinalDenMenor = resultDenominador[0] + resultDenominador[1];
									}
									else
										resultFinalDenMenor = resultDenominador[0] - resultDenominador[1];
								}

								if (vOperadorDen.Length == 2)
								{
									if (vOperadorDen[0] == "+" && vOperadorDen[1] == "+")
									{
										resultFinalDenMenor = resultDenominador[0] + resultDenominador[1] + resultDenominador[2];
									}
									else if (vOperadorDen[0] == "+" && vOperadorDen[1] == "-")
									{
										resultFinalDenMenor = resultDenominador[0] + resultDenominador[1] - resultDenominador[2];
									}
									else if (vOperadorDen[0] == "-" && vOperadorDen[1] == "-")
									{
										resultFinalDenMenor = resultDenominador[0] - resultDenominador[1] - resultDenominador[2];
									}
									else if (vOperadorDen[0] == "-" && vOperadorDen[1] == "+")
									{
										resultFinalDenMenor = resultDenominador[0] - resultDenominador[1] + resultDenominador[2];
									}
								}

								x = x + 1;

								resultFinalLateralMenor = resultFinalNumeradorMenor / resultFinalDenMenor;

								Console.WriteLine($"Para o valor de X valendo: {lateralMenor}.O limite será igual a: {resultFinalLateralMenor}.");
							}
						}
						else
							break;
					}

					x = 0;
					Console.WriteLine(" ");

					for (double valorLimite = 0.1; valorLimite <= valueX; valorLimite = valorLimite / 10)
					{
						double lateralMaior = valueX + valorLimite;

						if (x < 5)
						{

							if (lateralMaior > valueX)
							{

								for (int parte = 0; parte < qtdTermoNum; parte++)
								{
									double resultadoNumerador = 0;

									if (valorNum[parte].ToUpper().IndexOf("X") == -1)
									{
										resultadoNumerador = double.Parse(valorNum[parte]);
									}
									else
									{
										String[] separado = valorNum[parte].ToUpper().Split('X');

										if (separado.Length == 2 && separado[1] != "")
										{
											resultadoNumerador = Math.Pow(lateralMaior, double.Parse(separado[1]));
											resultadoNumerador = resultadoNumerador * double.Parse(separado[0]);
										}
										else
											resultadoNumerador = lateralMaior * double.Parse(separado[0]);
									}

									resultNumerador[parte] = resultadoNumerador;

								}

								if (vOperadorNum.Length == 1)
								{
									if (vOperadorNum[0] == "+")
									{
										resultFinalNumeradorMaior = resultNumerador[0] + resultNumerador[1];
									}
									else
										resultFinalNumeradorMaior = resultNumerador[0] - resultNumerador[1];
								}

								if (vOperadorNum.Length == 2)
								{
									if (vOperadorNum[0] == "+" && vOperadorNum[1] == "+")
									{
										resultFinalNumeradorMaior = resultNumerador[0] + resultNumerador[1] + resultNumerador[2];
									}
									else if (vOperadorNum[0] == "+" && vOperadorNum[1] == "-")
									{
										resultFinalNumeradorMaior = resultNumerador[0] + resultNumerador[1] - resultNumerador[2];
									}
									else if (vOperadorNum[0] == "-" && vOperadorNum[1] == "-")
									{
										resultFinalNumeradorMaior = resultNumerador[0] - resultNumerador[1] - resultNumerador[2];
									}
									else if (vOperadorNum[0] == "-" && vOperadorNum[1] == "+")
									{
										resultFinalNumeradorMaior = resultNumerador[0] - resultNumerador[1] + resultNumerador[2];
									}
								}

								for (int parte = 0; parte < qtdTermoDen; parte++)
								{
									double resultDen = 0;

									if (valorDen[parte].ToUpper().IndexOf("X") == -1)
									{
										resultDen = double.Parse(valorDen[parte]);
									}
									else
									{
										String[] separado = valorDen[parte].ToUpper().Split('X');

										if (separado.Length == 2 && separado[1] != "")
										{
											resultDen = Math.Pow(lateralMaior, double.Parse(separado[1]));
											resultDen = resultDen * double.Parse(separado[0]);
										}
										else
											resultDen = lateralMaior * double.Parse(separado[0]);

									}

									resultDenominador[parte] = resultDen;
								}


								if (vOperadorDen.Length == 1)
								{
									if (vOperadorDen[0] == "+")
									{
										resultFinalDenMaior = resultDenominador[0] + resultDenominador[1];
									}
									else
										resultFinalDenMaior = resultDenominador[0] - resultDenominador[1];
								}

								if (vOperadorDen.Length == 2)
								{
									if (vOperadorDen[0] == "+" && vOperadorDen[1] == "+")
									{
										resultFinalDenMaior = resultDenominador[0] + resultDenominador[1] + resultDenominador[2];
									}
									else if (vOperadorDen[0] == "+" && vOperadorDen[1] == "-")
									{
										resultFinalDenMaior = resultDenominador[0] + resultDenominador[1] - resultDenominador[2];
									}
									else if (vOperadorDen[0] == "-" && vOperadorDen[1] == "-")
									{
										resultFinalDenMaior = resultDenominador[0] - resultDenominador[1] - resultDenominador[2];
									}
									else if (vOperadorDen[0] == "-" && vOperadorDen[1] == "+")
									{
										resultFinalDenMaior = resultDenominador[0] - resultDenominador[1] + resultDenominador[2];
									}
								}

								x = x + 1;

								resultFinalLateralMaior = resultFinalNumeradorMaior / resultFinalDenMaior;

								Console.WriteLine($"Para o valor de X valendo: {lateralMaior}.O limite será igual a: {resultFinalLateralMaior}.");
							}
						}
						else
							break;
					}

					resultFinalLateralMenor = Math.Round(resultFinalLateralMenor, 1);
					resultFinalLateralMaior = Math.Round(resultFinalLateralMaior, 1);


					if (resultFinalLateralMaior != resultFinalLateralMenor)
					{
						Console.WriteLine("\nOs limites laterais não coincidem, portanto, não existe um limite.");
					}
					else
						Console.WriteLine($"\nO valor do limite lateral é igual a: {resultFinalLateralMaior}");

				}

				else
				{
					resultFinalExp = resultFinalNum / resultFinalDen;
					Console.WriteLine($"O valor do limite é: {resultFinalExp}");
				}
			}


			else if (choose == "NAO" || choose == "NÃO")
			{
				Console.WriteLine("Digite a quantidade de termos da função: ");
				qtdTermo = Int32.Parse(Console.ReadLine());

				string[] valor = new string[qtdTermo];
				string[] valorOperador = new string[qtdTermo - 1];
				double[] resultados = new double[qtdTermo];

				for (int termo = 0; termo < qtdTermo; termo++)
				{
					Console.WriteLine($"Digite o valor do {termo + 1}º termo da função");

					expressao = Console.ReadLine();

					valor[termo] = expressao;

					if (termo != qtdTermo - 1)
					{
						Console.WriteLine($"Digite o valor da {termo + 1}ª operação: ");
						valorOperador[termo] = Console.ReadLine();
					}
				}

				Console.WriteLine("Digite o valor que X está tendendo ao Limite");
				valueX = double.Parse(Console.ReadLine());

				for (int parte = 0; parte < qtdTermo; parte++)
				{
					double resultado = 0;

					if (valor[parte].ToUpper().IndexOf("X") == -1)
					{
						resultado = double.Parse(valor[parte]);
					}
					else
					{
						String[] separado = valor[parte].ToUpper().Split('X');

						if (separado.Length == 2 && separado[1] != "")
						{
							resultado = Math.Pow(valueX, double.Parse(separado[1]));
							resultado = resultado * double.Parse(separado[0]);
						}
						else
							resultado = valueX * double.Parse(separado[0]);
					}

					resultados[parte] = resultado;
				}

				if (valorOperador.Length == 1)
				{
					if (valorOperador[0] == "+")
					{
						resultFinalExp = resultados[0] + resultados[1];
					}
					else
						resultFinalExp = resultados[0] - resultados[1];
				}

				if (valorOperador.Length == 2)
				{
					if (valorOperador[0] == "+" && valorOperador[1] == "+")
					{
						resultFinalExp = resultados[0] + resultados[1] + resultados[2];
					}
					else if (valorOperador[0] == "+" && valorOperador[1] == "-")
					{
						resultFinalExp = resultados[0] + resultados[1] - resultados[2];
					}
					else if (valorOperador[0] == "-" && valorOperador[1] == "-")
					{
						resultFinalExp = resultados[0] - resultados[1] - resultados[2];
					}
					else if (valorOperador[0] == "-" && valorOperador[1] == "+")
					{
						resultFinalExp = resultados[0] - resultados[1] + resultados[2];
					}
				}

				Console.WriteLine($"O valor do limite é:  {resultFinalExp}");
			}

			Console.ReadKey();


		}
    }
}
