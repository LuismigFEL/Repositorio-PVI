using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Formulario_MDI
{
    public partial class Form4 : Form
    {
        private Chart chartPromedios;

        public Form4()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.chartPromedios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPromedios)).BeginInit();
            this.SuspendLayout();

            ChartArea chartArea1 = new ChartArea("ChartArea1");
            this.chartPromedios.ChartAreas.Add(chartArea1);
            Legend legend1 = new Legend("Legend1");
            this.chartPromedios.Legends.Add(legend1);
            this.chartPromedios.Location = new System.Drawing.Point(12, 12);
            this.chartPromedios.Name = "chartPromedios";
            this.chartPromedios.Size = new System.Drawing.Size(760, 426);
            this.chartPromedios.TabIndex = 0;
            this.chartPromedios.Text = "chart1";
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartPromedios);
            this.Name = "Form4";
            this.Text = "Mejores Promedios";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPromedios)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var series = new Series("Promedios");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.YValueType = ChartValueType.Double;

            series.IsValueShownAsLabel = true;
            series.LabelFormat = "0.00"; 
            
            chartPromedios.Series.Clear();

            // Calcular top 5 por promedio e identificar su mejor asignatura
            var top = DatosCompartidos.Estudiantes
                .Select(est => new
                {
                    est.Nombre,
                    Promedio = est.Asignaturas.Count > 0 ? est.Asignaturas.Average(a => a.Nota) : 0,
                    MejorAsignatura = est.Asignaturas
                        .OrderByDescending(a => a.Nota)
                        .Select(a => a.Nombre)
                        .FirstOrDefault() ?? "Sin Asignaturas"
                })
                .OrderByDescending(x => x.Promedio)
                .Take(5)
                .ToList();

            foreach (var item in top)
            {
                var xLabel = $"{item.Nombre} - {item.MejorAsignatura}";
                series.Points.AddXY(xLabel, item.Promedio);
            }

            chartPromedios.Series.Add(series);
        }
    }
}
