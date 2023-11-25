using System;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace IterationGame {
	public partial class Form : System.Windows.Forms.Form {
		int N = 20;
		Chart chart;
		public Form() {
			InitializeComponent();

			chart = new Chart();
			chart.Dock = DockStyle.Fill;
			viewSC.Panel2.Controls.Add(chart);
		}

		private void buildResultGrid(Game game) {
			viewSC.Panel1.Controls.Clear();
			resultGrid = new SourceGrid.Grid();
			resultGrid.AllowOverlappingCells = true;
			resultGrid.AutoStretchColumnsToFitWidth = true;
			resultGrid.Dock = DockStyle.Fill;
			resultGrid.EnableSort = true;
			resultGrid.FixedRows = 2;
			resultGrid.Location = new Point(0, 0);
			resultGrid.Name = "resultGrid";
			resultGrid.Size = new Size(650, 312);
			resultGrid.TabIndex = 1;

			resultGrid.Redim(N + 3, 1 + 2 + game.StrategyCount.Sum() + 2);
			resultGrid.Font = new Font(FontFamily.GenericSansSerif, 12);
			resultGrid[0, 0] = new SourceGrid.Cells.Cell("№ п/п") { RowSpan = 2 };
			for (int player = 0; player < game.PlayersCount; player++) {
				int gainsStartPosForPlayer = 3 + (player > 0 ? player * game.StrategyCount[player - 1] : 0);

				resultGrid[0, player + 1] = new SourceGrid.Cells.Cell($"Стратегии игрока {player + 1}") { RowSpan = 2 };
				resultGrid[0, gainsStartPosForPlayer] = new SourceGrid.Cells.Cell($"Выигрыши игрока {player + 1}") {
					ColumnSpan = game.StrategyCount[player]
				};
				for (int i = 0; i < game.StrategyCount[player]; i++) {
					resultGrid[1, gainsStartPosForPlayer + i] = new SourceGrid.Cells.Cell(i + 1);
					resultGrid[1, gainsStartPosForPlayer + i].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
				}
				resultGrid[0, 3 + game.StrategyCount.Sum() + player] = new SourceGrid.Cells.Cell($"Сред. выигрыш игрока {player + 1}") {
					RowSpan = 2
				};
			}
			viewSC.Panel1.Controls.Add(resultGrid);
		}

		private void AddIteration(Game game) {
			int iteration = game.Iterations.Count;
			resultGrid[iteration + 1, 0] = new SourceGrid.Cells.Cell($"{iteration}") { ColumnSpan = 1, RowSpan = 1 };
			for (int player = 0; player < game.PlayersCount; player++) {
				int gainsStartPosForPlayer = 3 + (player > 0 ? player * game.StrategyCount[player - 1] : 0);

				resultGrid[iteration + 1, player + 1] = new SourceGrid.Cells.Cell($"{game.Iterations[iteration - 1].Strategies[player] + 1}");
				for (int i = 0; i < game.StrategyCount[player]; i++)
					resultGrid[iteration + 1, gainsStartPosForPlayer + i] = new SourceGrid.Cells.Cell(game.Iterations[iteration - 1].PlayerGains[player][i]);
				resultGrid[iteration + 1, 3 + game.StrategyCount.Sum() + player] = new SourceGrid.Cells.Cell(
					Math.Round(game.Iterations[iteration - 1].PlayerGains[player].Max() / iteration, 4));
				}
		}

		private void MatrixNUD_ValueChanged(object sender, EventArgs e) {
			firstStrategyPlayerCB1.Items.Clear();
			firstStrategyPlayerCB2.Items.Clear();
			if (verticalMatrixNUD.Value < 1 || horizontalMatrixNUD.Value < 1) {
				matrixInputGrid.Redim(0, 0);
				return;
			}

			double[,] old_values = new double[matrixInputGrid.RowsCount, matrixInputGrid.ColumnsCount];
			for (int i = 0; i < matrixInputGrid.RowsCount; i++)
				for (int j = 0; j < matrixInputGrid.ColumnsCount; j++)
					old_values[i, j] = (double)matrixInputGrid[i, j].Value;

			matrixInputGrid.Redim(0 + ((int)horizontalMatrixNUD.Value), 0 + ((int)verticalMatrixNUD.Value));
			for (int i = 0; i < horizontalMatrixNUD.Value; i++) {
				firstStrategyPlayerCB1.Items.Add(i + 1);
				for (int j = 0; j < verticalMatrixNUD.Value; j++) {
					if (i == 0)
						firstStrategyPlayerCB2.Items.Add(j + 1);
					matrixInputGrid[i, j] = new SourceGrid.Cells.Cell(
						i < old_values.GetLength(0) && j < old_values.GetLength(1) ?
						old_values[i, j] : 0, typeof(double));
					matrixInputGrid[i, j].View.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleCenter;
				}
			}

			firstStrategyPlayerCB1.SelectedIndex = firstStrategyPlayerCB2.SelectedIndex = 0;
		}

		private void playB_Click(object sender, EventArgs e) {
			if (firstStrategyPlayerCB1.SelectedIndex < 0 || firstStrategyPlayerCB2.SelectedIndex < 0)
				return;

			double[,] game_matrix = new double[(int)horizontalMatrixNUD.Value, (int)verticalMatrixNUD.Value];
			for (int i = 0; i < horizontalMatrixNUD.Value; i++)
				for (int j = 0; j < verticalMatrixNUD.Value; j++)
					game_matrix[i, j] = (double)matrixInputGrid[i, j].Value;
			Game game = new Game(game_matrix, new int[] { firstStrategyPlayerCB1.SelectedIndex, firstStrategyPlayerCB2.SelectedIndex });
			buildResultGrid(game);

			AddIteration(game);
			for (int i = 0; i < N - 1; i++) {
				game.PlayIteration();
				AddIteration(game);
			}
			resultGrid.AutoSizeCells();
			maxminL.Text = Math.Round(game.MaxMin).ToString();
			minmaxL.Text = Math.Round(game.MinMax).ToString();
			gamePriceL.Text = $"({Math.Round(game.GamePrice[0], 2)}; {Math.Round(game.GamePrice[1], 2)})";

			chart.Series.Clear();
			Label[] playerOptimalStrategyLabels = { optimalStrategyL1, optimalStrategyL2 };
			for (int player = 0; player < game.PlayersCount; player++) {
				double[] optS = game.GetOptimalStrategyForPlayer(player);
				chart.Series.Add("Игрок " + (player + 1));
				playerOptimalStrategyLabels[player].Text = (char)('X' + player) + $"* = (";
				for (int i = 0; i < game.StrategyCount[player]; i++) {
					playerOptimalStrategyLabels[player].Text += $"{Math.Round(optS[i], 3)}; ";
					chart.Series[player].Points.AddXY(i + 1, optS[i] * game.Iterations.Count);
				}
				playerOptimalStrategyLabels[player].Text = playerOptimalStrategyLabels[player].Text[0..^2] + ")";
			}

			chart.ChartAreas.Clear();
			chart.ChartAreas.Add("0");
			chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
			chart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
			chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
			chart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
			chart.Legends.Add(new Legend());
			chart.Update();
		}

		private void iterationsCB_SelectedIndexChanged(object sender, EventArgs e) {
			N = int.Parse(iterationsCB.Text);
		}

		private void openFileB_Click(object sender, EventArgs e) {
			if (oFD.ShowDialog() == DialogResult.OK) {
				try {
					string[] text = File.ReadAllLines(oFD.FileName);

					horizontalMatrixNUD.Value = text.Length;
					for (int i = 0; i < text.Length; i++) {
						string[] columns = text[i].Trim().Split(' ');
						verticalMatrixNUD.Value = columns.Length;
						for (int j = 0; j < columns.Length; j++) {
							matrixInputGrid[i, j] = new SourceGrid.Cells.Cell(double.Parse(columns[j]), typeof(double));
						}
					}
				} catch (Exception ex) {
					MessageBox.Show(ex.Message, "Ошибка при открытии файла");
				}
			}
		}

		private void saveFileB_Click(object sender, EventArgs e) {
			if (sFD.ShowDialog() == DialogResult.OK) {
				var csv = new StringBuilder();
				for (int i = 0; i < verticalMatrixNUD.Value; i++) {
					string newLine = "";
					for (int j = 0; j < horizontalMatrixNUD.Value; j++) {
						newLine += $"{matrixInputGrid[i, j]} ";
					}
					csv.AppendLine(newLine);
				}
				File.WriteAllText(sFD.FileName, csv.ToString());
			}
		}
	}
}