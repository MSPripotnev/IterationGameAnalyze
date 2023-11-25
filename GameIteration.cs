using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IterationGame {
	internal class GameIteration {
		/// <summary>
		/// Список стратегий, выбранных игроками на текущей итерации
		/// </summary>
		public int[] Strategies { get; private set; }

		/// <summary>
		/// Список выигрышей игроков. Первый индекс - игрок, далее - выигрыши игрока
		/// </summary>
		public List<double[]> PlayerGains { get; private set; } = new List<double[]>();
		/// <summary>
		/// Конструктор начальной итерации игры
		/// </summary>
		/// <param name="GameMatrix">Матрица игры</param>
		/// <param name="playerStrategies">Начальные стратегии игроков</param>
		public GameIteration(double[,] GameMatrix, int[] playerStrategies) {
			Strategies = playerStrategies;
			double[] gains;

			gains = new double[GameMatrix.GetLength(0)];
			for (int i = 0; i < GameMatrix.GetLength(0); i++)
				gains[i] = GameMatrix[i, Strategies[1]];
			PlayerGains.Add(gains);

			gains = new double[GameMatrix.GetLength(1)];
			for (int i = 0; i < GameMatrix.GetLength(1); i++)
				gains[i] = -GameMatrix[Strategies[0], i];
			PlayerGains.Add(gains);
		}
		/// <summary>
		/// Конструктор следующей итерации игры
		/// </summary>
		/// <param name="GameMatrix">Матрица игры</param>
		/// <param name="last">Предыдущая итерация игры</param>
		public GameIteration(double[,] GameMatrix, GameIteration last) {
			Strategies = new int[last.PlayerGains.Count];

			Strategies[0] = Array.IndexOf(last.PlayerGains[1], last.PlayerGains[1].Max());
			Strategies[1] = Array.IndexOf(last.PlayerGains[0], last.PlayerGains[0].Max());
			double[] gains1 = new double[last.PlayerGains[0].Length],
					 gains2 = new double[last.PlayerGains[1].Length];
			for (int i = 0; i < last.PlayerGains[0].Length; i++)
				gains1[i] = last.PlayerGains[0][i] + GameMatrix[i, Strategies[0]];
			for (int i = 0; i < last.PlayerGains[1].Length; i++)
				gains2[i] = last.PlayerGains[1][i] - GameMatrix[Strategies[1], i];

			PlayerGains.Add(gains1);
			PlayerGains.Add(gains2);
		}
	}
}
