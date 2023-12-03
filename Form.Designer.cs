using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IterationGame {
	partial class Form {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			mainSC = new SplitContainer();
			groupBox8 = new GroupBox();
			groupBox14 = new GroupBox();
			optimalStrategyL2 = new Label();
			groupBox13 = new GroupBox();
			optimalStrategyL1 = new Label();
			groupBox12 = new GroupBox();
			gamePriceL = new Label();
			groupBox10 = new GroupBox();
			maxminL = new Label();
			groupBox9 = new GroupBox();
			minmaxL = new Label();
			groupBox2 = new GroupBox();
			groupBox11 = new GroupBox();
			iterationsCB = new ComboBox();
			playB = new Button();
			firstStrategyPlayerCB2 = new ComboBox();
			firstStrategyPlayerCB1 = new ComboBox();
			player2L = new Label();
			player1L = new Label();
			groupBox1 = new GroupBox();
			groupBox5 = new GroupBox();
			groupBox7 = new GroupBox();
			horizontalMatrixNUD = new NumericUpDown();
			groupBox6 = new GroupBox();
			verticalMatrixNUD = new NumericUpDown();
			groupBox4 = new GroupBox();
			saveFileB = new Button();
			openFileB = new Button();
			groupBox3 = new GroupBox();
			matrixInputGrid = new SourceGrid.Grid();
			viewSC = new SplitContainer();
			resultGrid = new SourceGrid.Grid();
			oFD = new OpenFileDialog();
			sFD = new SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)mainSC).BeginInit();
			mainSC.Panel1.SuspendLayout();
			mainSC.Panel2.SuspendLayout();
			mainSC.SuspendLayout();
			groupBox8.SuspendLayout();
			groupBox14.SuspendLayout();
			groupBox13.SuspendLayout();
			groupBox12.SuspendLayout();
			groupBox10.SuspendLayout();
			groupBox9.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox11.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox5.SuspendLayout();
			groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)horizontalMatrixNUD).BeginInit();
			groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)verticalMatrixNUD).BeginInit();
			groupBox4.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)viewSC).BeginInit();
			viewSC.Panel1.SuspendLayout();
			viewSC.SuspendLayout();
			SuspendLayout();
			// 
			// mainSC
			// 
			mainSC.Dock = DockStyle.Fill;
			mainSC.FixedPanel = FixedPanel.Panel1;
			mainSC.IsSplitterFixed = true;
			mainSC.Location = new Point(0, 0);
			mainSC.Margin = new Padding(4);
			mainSC.Name = "mainSC";
			// 
			// mainSC.Panel1
			// 
			mainSC.Panel1.Controls.Add(groupBox8);
			mainSC.Panel1.Controls.Add(groupBox2);
			mainSC.Panel1.Controls.Add(groupBox1);
			mainSC.Panel1MinSize = 385;
			// 
			// mainSC.Panel2
			// 
			mainSC.Panel2.Controls.Add(viewSC);
			mainSC.Size = new Size(1146, 630);
			mainSC.SplitterDistance = 400;
			mainSC.SplitterWidth = 5;
			mainSC.TabIndex = 0;
			// 
			// groupBox8
			// 
			groupBox8.BackColor = SystemColors.GradientActiveCaption;
			groupBox8.Controls.Add(groupBox14);
			groupBox8.Controls.Add(groupBox13);
			groupBox8.Controls.Add(groupBox12);
			groupBox8.Controls.Add(groupBox10);
			groupBox8.Controls.Add(groupBox9);
			groupBox8.Dock = DockStyle.Fill;
			groupBox8.Location = new Point(0, 412);
			groupBox8.Name = "groupBox8";
			groupBox8.Size = new Size(400, 218);
			groupBox8.TabIndex = 2;
			groupBox8.TabStop = false;
			groupBox8.Text = "Анализ игры";
			// 
			// groupBox14
			// 
			groupBox14.Controls.Add(optimalStrategyL2);
			groupBox14.Location = new Point(132, 115);
			groupBox14.Name = "groupBox14";
			groupBox14.Size = new Size(264, 79);
			groupBox14.TabIndex = 4;
			groupBox14.TabStop = false;
			groupBox14.Text = "Оптимальная стратегия игрока 2";
			// 
			// optimalStrategyL2
			// 
			optimalStrategyL2.Dock = DockStyle.Fill;
			optimalStrategyL2.Location = new Point(3, 25);
			optimalStrategyL2.Name = "optimalStrategyL2";
			optimalStrategyL2.Size = new Size(258, 51);
			optimalStrategyL2.TabIndex = 0;
			optimalStrategyL2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox13
			// 
			groupBox13.Controls.Add(optimalStrategyL1);
			groupBox13.Location = new Point(132, 30);
			groupBox13.Name = "groupBox13";
			groupBox13.Size = new Size(261, 79);
			groupBox13.TabIndex = 3;
			groupBox13.TabStop = false;
			groupBox13.Text = "Оптимальная стратегия игрока 1";
			// 
			// optimalStrategyL1
			// 
			optimalStrategyL1.Dock = DockStyle.Fill;
			optimalStrategyL1.Location = new Point(3, 25);
			optimalStrategyL1.Name = "optimalStrategyL1";
			optimalStrategyL1.Size = new Size(255, 51);
			optimalStrategyL1.TabIndex = 0;
			optimalStrategyL1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox12
			// 
			groupBox12.Controls.Add(gamePriceL);
			groupBox12.Location = new Point(0, 136);
			groupBox12.Name = "groupBox12";
			groupBox12.Size = new Size(123, 58);
			groupBox12.TabIndex = 2;
			groupBox12.TabStop = false;
			groupBox12.Text = "Цена игры";
			// 
			// gamePriceL
			// 
			gamePriceL.Dock = DockStyle.Fill;
			gamePriceL.Location = new Point(3, 25);
			gamePriceL.Name = "gamePriceL";
			gamePriceL.Size = new Size(117, 30);
			gamePriceL.TabIndex = 0;
			gamePriceL.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox10
			// 
			groupBox10.Controls.Add(maxminL);
			groupBox10.Location = new Point(0, 30);
			groupBox10.Name = "groupBox10";
			groupBox10.Size = new Size(123, 50);
			groupBox10.TabIndex = 1;
			groupBox10.TabStop = false;
			groupBox10.Text = "Максимин";
			// 
			// maxminL
			// 
			maxminL.Dock = DockStyle.Fill;
			maxminL.Location = new Point(3, 25);
			maxminL.Name = "maxminL";
			maxminL.Size = new Size(117, 22);
			maxminL.TabIndex = 0;
			maxminL.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox9
			// 
			groupBox9.Controls.Add(minmaxL);
			groupBox9.Location = new Point(0, 80);
			groupBox9.Name = "groupBox9";
			groupBox9.Size = new Size(123, 50);
			groupBox9.TabIndex = 0;
			groupBox9.TabStop = false;
			groupBox9.Text = "Минимакс";
			// 
			// minmaxL
			// 
			minmaxL.Dock = DockStyle.Fill;
			minmaxL.Location = new Point(3, 25);
			minmaxL.Name = "minmaxL";
			minmaxL.Size = new Size(117, 22);
			minmaxL.TabIndex = 0;
			minmaxL.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			groupBox2.BackColor = SystemColors.GradientInactiveCaption;
			groupBox2.Controls.Add(groupBox11);
			groupBox2.Controls.Add(playB);
			groupBox2.Controls.Add(firstStrategyPlayerCB2);
			groupBox2.Controls.Add(firstStrategyPlayerCB1);
			groupBox2.Controls.Add(player2L);
			groupBox2.Controls.Add(player1L);
			groupBox2.Dock = DockStyle.Top;
			groupBox2.Location = new Point(0, 300);
			groupBox2.Margin = new Padding(4);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(4);
			groupBox2.Size = new Size(400, 112);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Выбор начальных стратегий";
			// 
			// groupBox11
			// 
			groupBox11.Controls.Add(iterationsCB);
			groupBox11.Location = new Point(162, 27);
			groupBox11.Name = "groupBox11";
			groupBox11.Size = new Size(97, 69);
			groupBox11.TabIndex = 5;
			groupBox11.TabStop = false;
			groupBox11.Text = "Итераций";
			// 
			// iterationsCB
			// 
			iterationsCB.FormattingEnabled = true;
			iterationsCB.Items.AddRange(new object[] { "1", "5", "10", "20", "100", "1000", "10000" });
			iterationsCB.Location = new Point(24, 28);
			iterationsCB.Name = "iterationsCB";
			iterationsCB.Size = new Size(58, 29);
			iterationsCB.TabIndex = 0;
			iterationsCB.Text = "20";
			iterationsCB.SelectedIndexChanged += iterationsCB_SelectedIndexChanged;
			// 
			// playB
			// 
			playB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			playB.Location = new Point(265, 32);
			playB.Name = "playB";
			playB.Size = new Size(128, 64);
			playB.TabIndex = 4;
			playB.Text = "Играть";
			playB.UseVisualStyleBackColor = true;
			playB.Click += playB_Click;
			// 
			// firstStrategyPlayerCB2
			// 
			firstStrategyPlayerCB2.DropDownStyle = ComboBoxStyle.DropDownList;
			firstStrategyPlayerCB2.FormattingEnabled = true;
			firstStrategyPlayerCB2.Location = new Point(87, 67);
			firstStrategyPlayerCB2.Name = "firstStrategyPlayerCB2";
			firstStrategyPlayerCB2.Size = new Size(61, 29);
			firstStrategyPlayerCB2.TabIndex = 3;
			// 
			// firstStrategyPlayerCB1
			// 
			firstStrategyPlayerCB1.DropDownStyle = ComboBoxStyle.DropDownList;
			firstStrategyPlayerCB1.FormattingEnabled = true;
			firstStrategyPlayerCB1.Location = new Point(87, 27);
			firstStrategyPlayerCB1.Name = "firstStrategyPlayerCB1";
			firstStrategyPlayerCB1.Size = new Size(61, 29);
			firstStrategyPlayerCB1.TabIndex = 2;
			// 
			// player2L
			// 
			player2L.AutoSize = true;
			player2L.Location = new Point(10, 70);
			player2L.Margin = new Padding(4, 0, 4, 0);
			player2L.Name = "player2L";
			player2L.Size = new Size(70, 21);
			player2L.TabIndex = 1;
			player2L.Text = "Игрок 2:";
			// 
			// player1L
			// 
			player1L.AutoSize = true;
			player1L.Location = new Point(10, 30);
			player1L.Margin = new Padding(4, 0, 4, 0);
			player1L.Name = "player1L";
			player1L.Size = new Size(70, 21);
			player1L.TabIndex = 0;
			player1L.Text = "Игрок 1:";
			// 
			// groupBox1
			// 
			groupBox1.BackColor = SystemColors.Info;
			groupBox1.Controls.Add(groupBox5);
			groupBox1.Controls.Add(groupBox4);
			groupBox1.Controls.Add(groupBox3);
			groupBox1.Dock = DockStyle.Top;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Margin = new Padding(4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4);
			groupBox1.Size = new Size(400, 300);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Ввод матрицы игры";
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(groupBox7);
			groupBox5.Controls.Add(groupBox6);
			groupBox5.Dock = DockStyle.Left;
			groupBox5.Location = new Point(4, 147);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(158, 149);
			groupBox5.TabIndex = 5;
			groupBox5.TabStop = false;
			groupBox5.Text = "Размеры матрицы";
			// 
			// groupBox7
			// 
			groupBox7.Controls.Add(horizontalMatrixNUD);
			groupBox7.Dock = DockStyle.Top;
			groupBox7.Location = new Point(3, 83);
			groupBox7.Name = "groupBox7";
			groupBox7.Size = new Size(152, 58);
			groupBox7.TabIndex = 1;
			groupBox7.TabStop = false;
			groupBox7.Text = "По горизонтали";
			// 
			// horizontalMatrixNUD
			// 
			horizontalMatrixNUD.Dock = DockStyle.Fill;
			horizontalMatrixNUD.Location = new Point(3, 25);
			horizontalMatrixNUD.Name = "horizontalMatrixNUD";
			horizontalMatrixNUD.Size = new Size(146, 29);
			horizontalMatrixNUD.TabIndex = 0;
			horizontalMatrixNUD.ValueChanged += MatrixNUD_ValueChanged;
			// 
			// groupBox6
			// 
			groupBox6.Controls.Add(verticalMatrixNUD);
			groupBox6.Dock = DockStyle.Top;
			groupBox6.Location = new Point(3, 25);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(152, 58);
			groupBox6.TabIndex = 0;
			groupBox6.TabStop = false;
			groupBox6.Text = "По вертикали";
			// 
			// verticalMatrixNUD
			// 
			verticalMatrixNUD.Dock = DockStyle.Fill;
			verticalMatrixNUD.Location = new Point(3, 25);
			verticalMatrixNUD.Name = "verticalMatrixNUD";
			verticalMatrixNUD.Size = new Size(146, 29);
			verticalMatrixNUD.TabIndex = 0;
			verticalMatrixNUD.ValueChanged += MatrixNUD_ValueChanged;
			// 
			// groupBox4
			// 
			groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			groupBox4.Controls.Add(saveFileB);
			groupBox4.Controls.Add(openFileB);
			groupBox4.Dock = DockStyle.Top;
			groupBox4.Location = new Point(4, 26);
			groupBox4.MaximumSize = new Size(160, 125);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(160, 121);
			groupBox4.TabIndex = 4;
			groupBox4.TabStop = false;
			// 
			// saveFileB
			// 
			saveFileB.Dock = DockStyle.Top;
			saveFileB.Location = new Point(3, 67);
			saveFileB.Margin = new Padding(4);
			saveFileB.Name = "saveFileB";
			saveFileB.Size = new Size(154, 42);
			saveFileB.TabIndex = 3;
			saveFileB.Text = "Сохранить в файл";
			saveFileB.UseVisualStyleBackColor = true;
			saveFileB.Click += saveFileB_Click;
			// 
			// openFileB
			// 
			openFileB.Dock = DockStyle.Top;
			openFileB.Location = new Point(3, 25);
			openFileB.Margin = new Padding(4);
			openFileB.Name = "openFileB";
			openFileB.Size = new Size(154, 42);
			openFileB.TabIndex = 1;
			openFileB.Text = "Открыть файл";
			openFileB.UseVisualStyleBackColor = true;
			openFileB.Click += openFileB_Click;
			// 
			// groupBox3
			// 
			groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			groupBox3.Controls.Add(matrixInputGrid);
			groupBox3.Location = new Point(168, 26);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(228, 270);
			groupBox3.TabIndex = 3;
			groupBox3.TabStop = false;
			groupBox3.Text = "Матрица игры";
			// 
			// matrixInputGrid
			// 
			matrixInputGrid.Dock = DockStyle.Fill;
			matrixInputGrid.EnableSort = true;
			matrixInputGrid.Location = new Point(3, 25);
			matrixInputGrid.Name = "matrixInputGrid";
			matrixInputGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
			matrixInputGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
			matrixInputGrid.Size = new Size(222, 242);
			matrixInputGrid.TabIndex = 0;
			matrixInputGrid.TabStop = true;
			matrixInputGrid.ToolTipText = "";
			// 
			// viewSC
			// 
			viewSC.Dock = DockStyle.Fill;
			viewSC.Location = new Point(0, 0);
			viewSC.Margin = new Padding(4);
			viewSC.Name = "viewSC";
			viewSC.Orientation = Orientation.Horizontal;
			// 
			// viewSC.Panel1
			// 
			viewSC.Panel1.Controls.Add(resultGrid);
			viewSC.Size = new Size(741, 630);
			viewSC.SplitterDistance = 312;
			viewSC.SplitterWidth = 5;
			viewSC.TabIndex = 0;
			// 
			// resultGrid
			// 
			resultGrid.AcceptsInputChar = false;
			resultGrid.BackColor = SystemColors.InactiveCaption;
			resultGrid.Dock = DockStyle.Fill;
			resultGrid.EnableSort = true;
			resultGrid.Location = new Point(0, 0);
			resultGrid.Name = "resultGrid";
			resultGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
			resultGrid.SelectionMode = SourceGrid.GridSelectionMode.Row;
			resultGrid.Size = new Size(741, 312);
			resultGrid.TabIndex = 1;
			resultGrid.TabStop = true;
			resultGrid.ToolTipText = "";
			// 
			// oFD
			// 
			oFD.DefaultExt = "csv";
			oFD.Filter = "\"CSV files|*.csv|Все файлы|*.*\"";
			oFD.InitialDirectory = "../../../Examples";
			oFD.Title = "Файл с матрицей игры";
			// 
			// sFD
			// 
			sFD.DefaultExt = "csv";
			sFD.Filter = "\"CSV input file|*.csv|TXT output file|*.txt|Все файлы|*.*\"";
			// 
			// Form
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1146, 630);
			Controls.Add(mainSC);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "Form";
			Text = "Итерационный метод решения матричных игр";
			mainSC.Panel1.ResumeLayout(false);
			mainSC.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)mainSC).EndInit();
			mainSC.ResumeLayout(false);
			groupBox8.ResumeLayout(false);
			groupBox14.ResumeLayout(false);
			groupBox13.ResumeLayout(false);
			groupBox12.ResumeLayout(false);
			groupBox10.ResumeLayout(false);
			groupBox9.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox11.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)horizontalMatrixNUD).EndInit();
			groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)verticalMatrixNUD).EndInit();
			groupBox4.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			viewSC.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)viewSC).EndInit();
			viewSC.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer mainSC;
		private GroupBox groupBox2;
		private ComboBox firstStrategyPlayerCB2;
		private ComboBox firstStrategyPlayerCB1;
		private Label player2L;
		private Label player1L;
		private GroupBox groupBox1;
		private SplitContainer viewSC;
		private SourceGrid.Grid resultGrid;
		private GroupBox groupBox5;
		private GroupBox groupBox7;
		private NumericUpDown horizontalMatrixNUD;
		private GroupBox groupBox6;
		private NumericUpDown verticalMatrixNUD;
		private Button playB;
		private GroupBox groupBox4;
		private Button saveFileB;
		private Button openFileB;
		private GroupBox groupBox3;
		private SourceGrid.Grid matrixInputGrid;
		private GroupBox groupBox8;
		private GroupBox groupBox10;
		private Label maxminL;
		private GroupBox groupBox9;
		private Label minmaxL;
		private GroupBox groupBox11;
		private ComboBox iterationsCB;
		private GroupBox groupBox14;
		private Label optimalStrategyL2;
		private GroupBox groupBox13;
		private Label optimalStrategyL1;
		private GroupBox groupBox12;
		private Label gamePriceL;
		private OpenFileDialog oFD;
		private SaveFileDialog sFD;
	}
}