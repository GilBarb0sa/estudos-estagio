using System;
using System.Threading.Tasks;

namespace ProjectAsync
{
	internal class ExemploAsync
	{
		//método Task com retorno Task<TResult>
		async Task<bool> Task_TResult_Async()
		{
			return await Task.FromResult<bool>(DateTime.IsLeapYear(DateTime.Now.Year));
		}

		//método com retorno void (Task)
		async Task Task_Void_Async()
		{
			await Task.Delay(2000);
			Form1.lstRes.Items.Add("Tarefa longa executada");
		}

		public async Task Task_LongaDuracao()
		{
			bool isAnoBissexto =  await Task_TResult_Async();

			Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto ? " é " : " não é ")} um Ano Bissexto");
			await Task_Void_Async();
		}
	}
}
