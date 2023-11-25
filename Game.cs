using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IterationGame {
	internal class Game {
		/// <summary>
		/// Матрица игры произвольного размера
		/// </summary>
		public double[,] GameMatrix { get; private set; }
		/// <summary>
		/// Максимин - вычисляется как минимум по всем строкам матрицы игры, затем максимум по результатам
		/// </summary>
		public double MaxMin { 
			get {
				double[] mins = new double[GameMatrix.GetLength(0)];
				for (int i = 0; i < GameMatrix.GetLength(0); i++) {
					double min = GameMatrix[i, 0];
					for (int j = 1; j < GameMatrix.GetLength(1); j++)
						if (min > GameMatrix[i, j])
							min = GameMatrix[i, j];
					mins[i] = min;
				}
				return mins.Max();
			} 
		}
		/// <summary>
		/// Минимакс - вычисляется как максимум по всем столбцам матрицы игры, затем минимум по результатам
		/// </summary>
		public double MinMax {
			get {
				double[] maxs = new double[GameMatrix.GetLength(1)];
				for (int i = 0; i < GameMatrix.GetLength(1); i++) {
					double max = GameMatrix[0, i];
					for (int j = 1; j < GameMatrix.GetLength(0); j++)
						if (max < GameMatrix[j, i])
							max = GameMatrix[j, i];
					maxs[i] = max;
				}
				return maxs.Min();
			}
		}
		/// <summary>
		/// Интервал принадлежности цены игры
		/// </summary>
		public double[] GamePrice {
			get {
				List<double> gains = new List<double>(){ 
					Iterations.Last().PlayerGains[0].Max() / Iterations.Count, 
					-Iterations.Last().PlayerGains[1].Max() / Iterations.Count
				};
				gains.Sort();
				return (gains.ToArray());
			}
		}
		/// <summary>
		/// Количество игроков
		/// </summary>
		public int PlayersCount { get; } = 2;
		/// <summary>
		/// Количество доступных стратегий i-го игрока
		/// </summary>
		public int[] StrategyCount {
			get {
				return new int[] {
					GameMatrix.GetLength(0),
					GameMatrix.GetLength(1)
				};
			}
		}
		/// <summary>
		/// Список итераций
		/// </summary>
		public List<GameIteration> Iterations { get; private set; }
		public Game() {
			Iterations = new List<GameIteration>();
		}
		/// <summary>
		/// Конструктор игры
		/// </summary> 
		/// <param name="gameMatrix">Матрица игры</param>
		/// <param name="playerStrategies">Начальные стратегии игроков</param>
		public Game(double[,] gameMatrix, int[] playerStrategies) : this() {
			GameMatrix = gameMatrix;
			Iterations.Add(new GameIteration(GameMatrix, playerStrategies));
		}

		public void PlayIteration() {
			Iterations.Add(new GameIteration(GameMatrix, Iterations.Last()));
		}
		/// <summary>
		/// Вектор оптимальной стратегии игрока: частота использования стратегий N итераций
		/// </summary>
		/// <param name="player">Индекс игрока</param>
		/// <returns></returns>
		public double[] GetOptimalStrategyForPlayer(int player) {
			double[] strategy = new double[StrategyCount[player]];
			for (int i = 0; i < strategy.Length; i++) {
				strategy[i] = Iterations.Count(p => p.Strategies[player] == i) * 1.0 / Iterations.Count;
			}
			return strategy;
		}
	}
}
