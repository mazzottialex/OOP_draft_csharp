using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UITimer = System.Windows.Forms.Timer;

public class Shootout : Form
{
    private readonly Team t1;
    private readonly Team t2;
    private readonly TextBox resultsT1;
    private readonly TextBox resultsT2;
    private readonly Label finalScore;
    private int goalT1;
    private int goalT2;
    private int shootsT1;
    private int shootsT2;
    private int totShoots;
    private Team? winner;
    private readonly Button startButton;
    private readonly Button closeButton;
    private readonly Dictionary<int, Pair<Player, string>> shootoutT1;
    private readonly Dictionary<int, Pair<Player, string>> shootoutT2;
    private readonly Label nameTeam1;
    private readonly Label nameTeam2;
    private string stringT1;
    private string stringT2;
    private readonly UITimer timer;
    private bool shootoutFinished;


    public Shootout(Team t1, Team t2)
    {
        this.t1 = t1;
        this.t2 = t2;
        goalT1 = 0;
        goalT2 = 0;
        shootsT1 = 0;
        shootsT2 = 0;
        totShoots = 0;
        ILogicsShootout logics = new LogicsShootoutImpl(t1, t2);
        shootoutT1 = logics.Compute()[0];
        shootoutT2 = logics.Compute()[1];
        stringT1 = "";
        stringT2 = "";
        shootoutFinished = false;

        // Imposta le dimensioni e la posizione del form
        Width = 400;
        Height = 400;
        CenterToScreen();

        // Crea i controlli della GUI
        startButton = new Button();
        startButton.Text = "Inizia";

        closeButton = new Button();
        closeButton.Text = "Chiudi";
        closeButton.Enabled = false;

        finalScore = new Label();
        finalScore.Text = "Risultato finale";
        finalScore.TextAlign = ContentAlignment.MiddleCenter;

        nameTeam1 = new Label();
        nameTeam1.Text = t1.Name;
        nameTeam1.TextAlign = ContentAlignment.MiddleCenter;

        nameTeam2 = new Label();
        nameTeam2.Text = t2.Name;
        nameTeam2.TextAlign = ContentAlignment.MiddleCenter;

        resultsT1 = new TextBox();
        resultsT1.Multiline = true;
        resultsT1.ScrollBars = ScrollBars.Vertical;
        resultsT1.Size = new Size(200, 200);
        resultsT1.ReadOnly = true;

        resultsT2 = new TextBox();
        resultsT2.Multiline = true;
        resultsT2.ScrollBars = ScrollBars.Vertical;
        resultsT2.Size = new Size(200, 200);
        resultsT2.ReadOnly = true;

        timer = new UITimer();
        timer.Interval = 1000; // 100 ms
        timer.Tick += Timer_Tick;

        // Crea il layout della GUI utilizzando il controllo TableLayoutPanel
        var tableLayoutPanel = new TableLayoutPanel();
        tableLayoutPanel.Dock = DockStyle.Fill;
        tableLayoutPanel.ColumnCount = 2;
        tableLayoutPanel.RowCount = 4;
        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        tableLayoutPanel.Controls.Add(startButton, 0, 0);
        tableLayoutPanel.Controls.Add(closeButton, 1, 0);
        tableLayoutPanel.SetColumnSpan(finalScore, 2);
        tableLayoutPanel.Controls.Add(finalScore, 0, 1);
        tableLayoutPanel.Controls.Add(nameTeam1, 0, 2);
        tableLayoutPanel.Controls.Add(nameTeam2, 1, 2);
        tableLayoutPanel.SetColumnSpan(resultsT1, 1);
        tableLayoutPanel.SetRowSpan(resultsT1, 2);
        tableLayoutPanel.Controls.Add(resultsT1, 0, 3);
        tableLayoutPanel.SetColumnSpan(resultsT2, 1);
        tableLayoutPanel.SetRowSpan(resultsT2, 2);
        tableLayoutPanel.Controls.Add(resultsT2, 1, 3);

        // Centra i controlli all'interno del TableLayoutPanel
        startButton.Anchor = AnchorStyles.None;
        closeButton.Anchor = AnchorStyles.None;
        finalScore.Anchor = AnchorStyles.None;
        nameTeam1.Anchor = AnchorStyles.None;
        nameTeam2.Anchor = AnchorStyles.None;
        resultsT1.Anchor = AnchorStyles.None;
        resultsT2.Anchor = AnchorStyles.None;

        // Aggiungi il layout al form
        Controls.Add(tableLayoutPanel);

        // Aggiungi gli event handler
        startButton.Click += StartButton_Click;
        closeButton.Click += CloseButton_Click;
    }

    private void StartButton_Click(object? sender, EventArgs e)
    {
        // Gestisci l'evento di click del pulsante "Inizia"
        // Inizia il timer per aggiornare la ProgressBar
        startButton.Enabled = false;
        timer.Start();
    }

    private void CloseButton_Click(object? sender, EventArgs e)
    {
        // Gestisci l'evento di click del pulsante "Chiudi"
        // Inserisci qui la logica desiderata
        Close();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        // Esegui l'azione ogni 1000ms
        if (!shootoutT1.ContainsKey(shootsT1) && !shootoutT2.ContainsKey(shootsT2) && !shootoutFinished)
        {
            shootoutFinished = true;
            closeButton.Enabled = true;
            finalScore.Text = goalT1 + " - " + goalT2;
            SetWinner(goalT1, goalT2);
            if (winner != null)
            {
                MessageBox.Show("Tiri di rigore terminati. Squadra vincente: " + winner.Name);
            }
            timer.Stop();
        }
        else
        {
            if (totShoots % 2 == 0)
            {
                if (shootoutT1.ContainsKey(shootsT1))
                {
                    string res = shootoutT1[shootsT1].Y;
                    string shooter = shootoutT1[shootsT1].X.Name;
                    string resultLabel = shooter + ": " + res;
                    stringT1 += resultLabel + Environment.NewLine;
                    resultsT1.Text = stringT1;
                    if (res == "Gol")
                    {
                        goalT1++;
                    }
                    shootsT1++;
                }
            }
            else
            {
                if (shootoutT2.ContainsKey(shootsT2))
                {
                    string res = shootoutT2[shootsT2].Y;
                    string shooter = shootoutT2[shootsT2].X.Name;
                    string resultLabel = shooter + ": " + res;
                    stringT2 += resultLabel + Environment.NewLine;
                    resultsT2.Text = stringT2;
                    if (res == "Gol")
                    {
                        goalT2++;
                    }
                    shootsT2++;
                }
            }
            totShoots = shootsT1 + shootsT2;
        }
    }

    public void SetWinner(int gol1, int gol2)
    {
        if (gol1 > gol2)
        {
            winner = t1;
        }
        else
        {
            winner = t2;
        }
    }

    [STAThread]
    public void CreateAndShowGUI()
    {
        Application.EnableVisualStyles();
        Application.Run(new Shootout(t1, t2));
    }
}
