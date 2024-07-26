using System;
using System.Threading.Tasks;

namespace ProjectAsync
{
	internal class Exemplo
	{
		//método com retorno
		bool Task_TResult()
		{
			return DateTime.IsLeapYear(DateTime.Now.Year);		
		}

		//método com retorno void
		void Task_Void()
		{
			Task.Delay(2000);
			Form1.lstRes.Items.Add("Tarefa longa executada");
		}

		public void Task_LongaDuracao()
		{
			bool isAnoBissexto = Task_TResult();

			Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto ? " é " : " não é ")} um Ano Bissexto");
			Task_Void();	
		}
	}
}
