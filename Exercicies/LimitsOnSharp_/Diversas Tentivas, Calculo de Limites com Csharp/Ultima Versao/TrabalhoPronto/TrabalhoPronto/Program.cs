//Nomes: Gustavo Laurindo dos Santos (082230032)
//Arthur Benevides do Santos (082230016)
//Projeto de Calculo de Limites, em Chsarp.

int qntdeTermos = 0, qntdeTermosNumerador = 0, qntdeTermosDenominador = 0, x = 0;
double valorX = 0, resultadoFinalExpressao = 0, resultadoFinalNumerador = 0, resultadoFinalDenominador = 0, resultadoFinalLateral = 0, resultadoFinalLateralMenor = 0, resultadoFinalLateralMaior = 0, resultadoFinalNumeradorLateralMenor = 0, resultadoFinalDenominadorLateralMenor = 0, resultadoFinalNumeradorLateralMaior = 0, resultadoFinalDenominadorLateralMaior = 0;
string escolha = " ", expressaoNumerador = " ", expressaoDenominador = " ", expressao = " ";

	Console.WriteLine("O seu cálculo possuí divisão? (Sim ou Não)");
	escolha = Console.ReadLine().ToUpper();

if (escolha == "SIM"){
	Console.WriteLine("Quantos termos existem no numerador?");
	qntdeTermosNumerador = Int32.Parse(Console.ReadLine());

	Console.WriteLine("Quantos termos existem no denominador?");
	qntdeTermosDenominador = Int32.Parse(Console.ReadLine());

	String[] valorOperadorDenominador = new string[qntdeTermosDenominador - 1];
	String[] valorOperadorNumerador = new string[qntdeTermosNumerador - 1];
	String[] valorNumerador = new string[qntdeTermosNumerador];
	String[] valorDenominador = new string[qntdeTermosDenominador];
	double[] resultadosNumerador = new double[qntdeTermosNumerador];
	double[] resultadosDenominador = new double[qntdeTermosDenominador];

	for (int termoNumerador = 0; termoNumerador < qntdeTermosNumerador; termoNumerador++){
		Console.WriteLine($"Escreva o valor do {termoNumerador + 1}º termo do numerador: ");
		expressaoNumerador = Console.ReadLine();

		valorNumerador[termoNumerador] = expressaoNumerador;

		if (termoNumerador != qntdeTermosNumerador - 1){
			Console.WriteLine($"Escreva o valor da {termoNumerador + 1}ª operação: ");
			valorOperadorNumerador[termoNumerador] = Console.ReadLine();
		}
	}

	for (int termoDenominador = 0; termoDenominador < qntdeTermosDenominador; termoDenominador++){
		Console.WriteLine($"Escreva o valor do {termoDenominador + 1}º termo do denominador: ");
		expressaoDenominador = Console.ReadLine();

		valorDenominador[termoDenominador] = expressaoDenominador;

		if (termoDenominador != qntdeTermosDenominador - 1){
			Console.WriteLine($"Escreva o valor da {termoDenominador + 1}ª operação: ");
			valorOperadorDenominador[termoDenominador] = Console.ReadLine();
		}
	}

	Console.WriteLine(" ");

	for(int parte = 0; parte < qntdeTermosNumerador; parte++){
		if(parte != qntdeTermosNumerador - 1){
			Console.Write($"  {valorNumerador[parte]} {valorOperadorNumerador[parte]}");
		}else
			Console.Write($" {valorNumerador[parte]}");
	}

	if(qntdeTermosNumerador == 3 || qntdeTermosDenominador == 3) {
		Console.WriteLine("\n------------------");
	}else
		Console.WriteLine("\n-----------");

	for (int parte = 0; parte < qntdeTermosDenominador; parte++){
		if(parte != qntdeTermosDenominador - 1){
			Console.Write($"  {valorDenominador[parte]} {valorOperadorDenominador[parte]}");
		}else
			Console.Write($" {valorDenominador[parte]}");
	}

	Console.WriteLine(" ");

	Console.WriteLine("\nEscreva o valor de X");
	valorX = double.Parse(Console.ReadLine());

	for (int parte = 0; parte < qntdeTermosNumerador; parte++){
		double resultadoNumerador = 0;

		if (valorNumerador[parte].ToUpper().IndexOf("X") == -1){
			resultadoNumerador = double.Parse(valorNumerador[parte]);
		}
			else{
				String[] separado = valorNumerador[parte].ToUpper().Split('X');

				if (separado.Length == 2 && separado[1] != ""){
					resultadoNumerador = Math.Pow(valorX, double.Parse(separado[1]));
					resultadoNumerador = resultadoNumerador * double.Parse(separado[0]);
				}
					else
						resultadoNumerador = valorX * double.Parse(separado[0]);
			}

		resultadosNumerador[parte] = resultadoNumerador;

	}

	if (valorOperadorNumerador.Length == 1){
		if (valorOperadorNumerador[0] == "+"){
			resultadoFinalNumerador = resultadosNumerador[0] + resultadosNumerador[1];
		}
			else
				resultadoFinalNumerador = resultadosNumerador[0] - resultadosNumerador[1];
	}

	if (valorOperadorNumerador.Length == 2){
		if (valorOperadorNumerador[0] == "+" && valorOperadorNumerador[1] == "+"){
			resultadoFinalNumerador = resultadosNumerador[0] + resultadosNumerador[1] + resultadosNumerador[2];
		}
			else if (valorOperadorNumerador[0] == "+" && valorOperadorNumerador[1] == "-"){
				resultadoFinalNumerador = resultadosNumerador[0] + resultadosNumerador[1] - resultadosNumerador[2];
			}
				else if (valorOperadorNumerador[0] == "-" && valorOperadorNumerador[1] == "-"){
					resultadoFinalNumerador = resultadosNumerador[0] - resultadosNumerador[1] - resultadosNumerador[2];
				}
					else if (valorOperadorNumerador[0] == "-" && valorOperadorNumerador[1] == "+"){
						resultadoFinalNumerador = resultadosNumerador[0] - resultadosNumerador[1] + resultadosNumerador[2];
					}
	}

		for (int parte = 0; parte < qntdeTermosDenominador; parte++){
			double resultadoDenominador = 0;

			if (valorDenominador[parte].ToUpper().IndexOf("X") == -1){
				resultadoDenominador = double.Parse(valorDenominador[parte]);
			}
				else{
					String[] separado = valorDenominador[parte].ToUpper().Split('X');

					if (separado.Length == 2 && separado[1] != ""){
						resultadoDenominador = Math.Pow(valorX, double.Parse(separado[1]));
						resultadoDenominador = resultadoDenominador * double.Parse(separado[0]);
					}
						else
							resultadoDenominador = valorX * double.Parse(separado[0]);
					
					}


		resultadosDenominador[parte] = resultadoDenominador;
	}


	if (valorOperadorDenominador.Length == 1){
		if (valorOperadorDenominador[0] == "+"){
			resultadoFinalDenominador = resultadosDenominador[0] + resultadosDenominador[1];
		}
			else
				resultadoFinalDenominador = resultadosDenominador[0] - resultadosDenominador[1];
	}

	if (valorOperadorDenominador.Length == 2){
		if (valorOperadorDenominador[0] == "+" && valorOperadorDenominador[1] == "+"){
			resultadoFinalDenominador = resultadosDenominador[0] + resultadosDenominador[1] + resultadosDenominador[2];
		}
			else if (valorOperadorDenominador[0] == "+" && valorOperadorDenominador[1] == "-"){
				resultadoFinalDenominador = resultadosDenominador[0] + resultadosDenominador[1] - resultadosDenominador[2];
			}
				else if (valorOperadorDenominador[0] == "-" && valorOperadorDenominador[1] == "-"){
					resultadoFinalDenominador = resultadosDenominador[0] - resultadosDenominador[1] - resultadosDenominador[2];
				}
					else if (valorOperadorDenominador[0] == "-" && valorOperadorDenominador[1] == "+"){
						resultadoFinalDenominador = resultadosDenominador[0] - resultadosDenominador[1] + resultadosDenominador[2];
					}
	}

	Console.WriteLine(" ");

	if ((resultadoFinalNumerador == 0 && resultadoFinalDenominador == 0) || resultadoFinalDenominador == 0){
		
		for (double valorLimite = 0.1; valorLimite <= valorX; valorLimite = valorLimite / 10)
		{
			double lateralMenor = valorX - valorLimite;
			
			if (x < 5){

				if (lateralMenor < valorX){

				for (int parte = 0; parte < qntdeTermosNumerador; parte++){
					double	resultadoNumerador = 0;

						if (valorNumerador[parte].ToUpper().IndexOf("X") == -1){
							resultadoNumerador = double.Parse(valorNumerador[parte]);
						}
							else{
								String[] separado = valorNumerador[parte].ToUpper().Split('X');

								if (separado.Length == 2 && separado[1] != ""){
									resultadoNumerador = Math.Pow(lateralMenor, double.Parse(separado[1]));
									resultadoNumerador = resultadoNumerador * double.Parse(separado[0]);
								}
									else
										resultadoNumerador = lateralMenor * double.Parse(separado[0]);
							}

						resultadosNumerador[parte] = resultadoNumerador;

				}

					if (valorOperadorNumerador.Length == 1){
						if (valorOperadorNumerador[0] == "+"){
							resultadoFinalNumeradorLateralMenor = resultadosNumerador[0] + resultadosNumerador[1];
						}
							else
								resultadoFinalNumeradorLateralMenor = resultadosNumerador[0] - resultadosNumerador[1];
					}

					if (valorOperadorNumerador.Length == 2){
						if (valorOperadorNumerador[0] == "+" && valorOperadorNumerador[1] == "+"){
							resultadoFinalNumeradorLateralMenor = resultadosNumerador[0] + resultadosNumerador[1] + resultadosNumerador[2];
						}
							else if (valorOperadorNumerador[0] == "+" && valorOperadorNumerador[1] == "-"){
								resultadoFinalNumeradorLateralMenor = resultadosNumerador[0] + resultadosNumerador[1] - resultadosNumerador[2];
							}
								else if (valorOperadorNumerador[0] == "-" && valorOperadorNumerador[1] == "-"){
									resultadoFinalNumeradorLateralMenor = resultadosNumerador[0] - resultadosNumerador[1] - resultadosNumerador[2];
								}
									else if (valorOperadorNumerador[0] == "-" && valorOperadorNumerador[1] == "+"){
										resultadoFinalNumeradorLateralMenor = resultadosNumerador[0] - resultadosNumerador[1] + resultadosNumerador[2];
									}
					}

						for (int parte = 0; parte < qntdeTermosDenominador; parte++){
							double resultadoDenominador = 0;

							if (valorDenominador[parte].ToUpper().IndexOf("X") == -1){
								resultadoDenominador = double.Parse(valorDenominador[parte]);
							}
								else{
									String[] separado = valorDenominador[parte].ToUpper().Split('X');

									if (separado.Length == 2 && separado[1] != "")
						{
										resultadoDenominador = Math.Pow(lateralMenor, double.Parse(separado[1]));
										resultadoDenominador = resultadoDenominador * double.Parse(separado[0]);
									}
										else
											resultadoDenominador = lateralMenor * double.Parse(separado[0]);
					
									}

						resultadosDenominador[parte] = resultadoDenominador;
					}


					if (valorOperadorDenominador.Length == 1){
						if (valorOperadorDenominador[0] == "+"){
							resultadoFinalDenominadorLateralMenor = resultadosDenominador[0] + resultadosDenominador[1];
						}
							else
								resultadoFinalDenominadorLateralMenor = resultadosDenominador[0] - resultadosDenominador[1];
					}

					if (valorOperadorDenominador.Length == 2){
						if (valorOperadorDenominador[0] == "+" && valorOperadorDenominador[1] == "+"){
							resultadoFinalDenominadorLateralMenor = resultadosDenominador[0] + resultadosDenominador[1] + resultadosDenominador[2];
						}
							else if (valorOperadorDenominador[0] == "+" && valorOperadorDenominador[1] == "-"){
								resultadoFinalDenominadorLateralMenor = resultadosDenominador[0] + resultadosDenominador[1] - resultadosDenominador[2];
							}
								else if (valorOperadorDenominador[0] == "-" && valorOperadorDenominador[1] == "-"){
									resultadoFinalDenominadorLateralMenor = resultadosDenominador[0] - resultadosDenominador[1] - resultadosDenominador[2];
								}
									else if (valorOperadorDenominador[0] == "-" && valorOperadorDenominador[1] == "+"){
										resultadoFinalDenominadorLateralMenor = resultadosDenominador[0] - resultadosDenominador[1] + resultadosDenominador[2];
									}
					}

					x = x + 1;

					resultadoFinalLateralMenor = resultadoFinalNumeradorLateralMenor / resultadoFinalDenominadorLateralMenor;

					Console.WriteLine($"Para o valor de X valendo: {lateralMenor}.O limite será igual a: {resultadoFinalLateralMenor}.");				
				}
			} else
				break;
		}

		x = 0;
		Console.WriteLine(" ");

		for (double valorLimite = 0.1; valorLimite <= valorX; valorLimite = valorLimite / 10){
			double lateralMaior = valorX + valorLimite;

			if(x < 5) {
						
				if(lateralMaior > valorX){

					for (int parte = 0; parte < qntdeTermosNumerador; parte++){
						double	resultadoNumerador = 0;

							if (valorNumerador[parte].ToUpper().IndexOf("X") == -1){
								resultadoNumerador = double.Parse(valorNumerador[parte]);
							}
								else{
									String[] separado = valorNumerador[parte].ToUpper().Split('X');

									if (separado.Length == 2 && separado[1] != ""){
										resultadoNumerador = Math.Pow(lateralMaior, double.Parse(separado[1]));
										resultadoNumerador = resultadoNumerador * double.Parse(separado[0]);
									}
										else
											resultadoNumerador = lateralMaior * double.Parse(separado[0]);
								}

							resultadosNumerador[parte] = resultadoNumerador;

					}

						if (valorOperadorNumerador.Length == 1){
							if (valorOperadorNumerador[0] == "+"){
								resultadoFinalNumeradorLateralMaior = resultadosNumerador[0] + resultadosNumerador[1];
							}
								else
									resultadoFinalNumeradorLateralMaior = resultadosNumerador[0] - resultadosNumerador[1];
						}

						if (valorOperadorNumerador.Length == 2){
							if (valorOperadorNumerador[0] == "+" && valorOperadorNumerador[1] == "+"){
								resultadoFinalNumeradorLateralMaior = resultadosNumerador[0] + resultadosNumerador[1] + resultadosNumerador[2];
							}
								else if (valorOperadorNumerador[0] == "+" && valorOperadorNumerador[1] == "-"){
									resultadoFinalNumeradorLateralMaior = resultadosNumerador[0] + resultadosNumerador[1] - resultadosNumerador[2];
								}
									else if (valorOperadorNumerador[0] == "-" && valorOperadorNumerador[1] == "-"){
										resultadoFinalNumeradorLateralMaior = resultadosNumerador[0] - resultadosNumerador[1] - resultadosNumerador[2];
									}
										else if (valorOperadorNumerador[0] == "-" && valorOperadorNumerador[1] == "+"){
											resultadoFinalNumeradorLateralMaior = resultadosNumerador[0] - resultadosNumerador[1] + resultadosNumerador[2];
										}
						}

							for (int parte = 0; parte < qntdeTermosDenominador; parte++){
								double resultadoDenominador = 0;

								if (valorDenominador[parte].ToUpper().IndexOf("X") == -1){
									resultadoDenominador = double.Parse(valorDenominador[parte]);
								}
									else{
										String[] separado = valorDenominador[parte].ToUpper().Split('X');

										if (separado.Length == 2 && separado[1] != "")
							{
											resultadoDenominador = Math.Pow(lateralMaior, double.Parse(separado[1]));
											resultadoDenominador = resultadoDenominador * double.Parse(separado[0]);
										}
											else
												resultadoDenominador = lateralMaior * double.Parse(separado[0]);
					
										}

							resultadosDenominador[parte] = resultadoDenominador;
						}


						if (valorOperadorDenominador.Length == 1){
							if (valorOperadorDenominador[0] == "+"){
								resultadoFinalDenominadorLateralMaior = resultadosDenominador[0] + resultadosDenominador[1];
							}
								else
									resultadoFinalDenominadorLateralMaior = resultadosDenominador[0] - resultadosDenominador[1];
						}

						if (valorOperadorDenominador.Length == 2){
							if (valorOperadorDenominador[0] == "+" && valorOperadorDenominador[1] == "+"){
								resultadoFinalDenominadorLateralMaior = resultadosDenominador[0] + resultadosDenominador[1] + resultadosDenominador[2];
							}
								else if (valorOperadorDenominador[0] == "+" && valorOperadorDenominador[1] == "-"){
									resultadoFinalDenominadorLateralMaior = resultadosDenominador[0] + resultadosDenominador[1] - resultadosDenominador[2];
								}
									else if (valorOperadorDenominador[0] == "-" && valorOperadorDenominador[1] == "-"){
										resultadoFinalDenominadorLateralMaior = resultadosDenominador[0] - resultadosDenominador[1] - resultadosDenominador[2];
									}
										else if (valorOperadorDenominador[0] == "-" && valorOperadorDenominador[1] == "+"){
											resultadoFinalDenominadorLateralMaior = resultadosDenominador[0] - resultadosDenominador[1] + resultadosDenominador[2];
										}
						}

						x = x +1;

						resultadoFinalLateralMaior = resultadoFinalNumeradorLateralMaior / resultadoFinalDenominadorLateralMaior;

						Console.WriteLine($"Quando X for: {lateralMaior}.O limite será: {resultadoFinalLateralMaior}.");				
				}
			}else
				break;
		}

		resultadoFinalLateralMenor = Math.Round(resultadoFinalLateralMenor,1);
		resultadoFinalLateralMaior = Math.Round(resultadoFinalLateralMaior,1);


		if (resultadoFinalLateralMaior != resultadoFinalLateralMenor){
			Console.WriteLine("\nOs limites laterais não coincidem, portanto, não existe um limite.");
		}
			else 
				Console.WriteLine($"\nO valor do limite lateral é igual a: {resultadoFinalLateralMaior}");
			
	}

		else{
			resultadoFinalExpressao = resultadoFinalNumerador / resultadoFinalDenominador;
			Console.WriteLine($"O valor do limite é: {resultadoFinalExpressao}");
		}
}


else if (escolha == "NAO" || escolha == "NÃO"){
		Console.WriteLine("Escreva a quantidade de termos: ");
		qntdeTermos = Int32.Parse(Console.ReadLine());

		string[] valor = new string[qntdeTermos];
		string[] valorOperador = new string[qntdeTermos - 1];
		double[] resultados = new double[qntdeTermos];

		for (int termo = 0; termo < qntdeTermos; termo++){
			Console.WriteLine($"Escreva o valor do {termo + 1}º termo");

			expressao = Console.ReadLine();

			valor[termo] = expressao;

			if (termo != qntdeTermos - 1)
			{
				Console.WriteLine($"Escreva o valor da {termo + 1}ª operação: ");
				valorOperador[termo] = Console.ReadLine();
			}
		}

		Console.WriteLine("Escreva o valor de X");
		valorX = double.Parse(Console.ReadLine());

		for (int parte = 0; parte < qntdeTermos; parte++){
			double resultado = 0;

			if (valor[parte].ToUpper().IndexOf("X") == -1){
				resultado = double.Parse(valor[parte]);
			}
				else{
					String[] separado = valor[parte].ToUpper().Split('X');

					if (separado.Length == 2 && separado[1] != ""){
						resultado = Math.Pow(valorX, double.Parse(separado[1]));
						resultado = resultado * double.Parse(separado[0]);
					}
						else
							resultado = valorX * double.Parse(separado[0]);
			}

			resultados[parte] = resultado;
		}

		if (valorOperador.Length == 1){
			if (valorOperador[0] == "+"){
				resultadoFinalExpressao = resultados[0] + resultados[1];
			}
				else
					resultadoFinalExpressao = resultados[0] - resultados[1];
		}

		if (valorOperador.Length == 2) {
			if (valorOperador[0] == "+" && valorOperador[1] == "+") {
				resultadoFinalExpressao = resultados[0] + resultados[1] + resultados[2];
			}
				else if (valorOperador[0] == "+" && valorOperador[1] == "-"){
					resultadoFinalExpressao = resultados[0] + resultados[1] - resultados[2];
				}
					else if (valorOperador[0] == "-" && valorOperador[1] == "-"){
						resultadoFinalExpressao = resultados[0] - resultados[1] - resultados[2];
					}
						else if (valorOperador[0] == "-" && valorOperador[1] == "+"){
							resultadoFinalExpressao = resultados[0] - resultados[1] + resultados[2];
						}
		}

		Console.WriteLine($"O valor do limite é:  {resultadoFinalExpressao}");
	}

Console.ReadKey();