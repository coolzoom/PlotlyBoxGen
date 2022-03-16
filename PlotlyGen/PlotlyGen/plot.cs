using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace PlotlyGen
{
    public partial class plot : UserControl
    {
        public plot()
        {
            InitializeComponent();
        }

        private void plot_Load(object sender, EventArgs e)
        {
            lists l1 = new lists();
            l1.materialTextBoxDataName.Text = "data1";
            this.flowLayoutPanel1.Controls.Add(l1);
            lists l2 = new lists();
            l2.materialTextBoxDataName.Text = "data2";
            this.flowLayoutPanel1.Controls.Add(l2);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string div = $"<div id=\"{materialTextBoxDIVID.Text}\"></div>";


            string xs = "";
            string ys = "";
            foreach (lists l in flowLayoutPanel1.Controls)
            {
                //x label
                string x = "'" + l.materialTextBoxDataName.Text + "'";
                if (xs == "")
                {
                    xs = x;
                }
                else
                {
                    xs = xs + "," + x;
                }

                //y data
                if (ys == "")
                {
                    ys = l.datastring;
                }
                else
                {
                    ys = ys + "," + l.datastring;
                }
            }

            string xdata = $"var xData = [{xs}]";
            string ydata = $"var yData = [{ys}]";

            string linespace = materialTextBoxYstep.Text;
            string data = @"       
                    var data = [];

                    for (var i = 0; i < xData.length; i++)
                        {
                            var result = {
                            type: 'box',
                            y: yData[i],
                            name: xData[i],
                            boxpoints: 'all',
                            jitter: 0.5,
                            whiskerwidth: 0.2,
                            fillcolor: 'cls',
                            marker:
                            {
                            size: 2
                            },
                            line:
                            {
                            width: 1
                            }
                        };
                        data.push(result);
                    };";

            string layout = @"
                layout = {
                    title: '" + materialTextBoxPlotName.Text + @"',
                    autosize: false,
                    width:  " + materialTextBoxPlotWidth.Text + @",
                    height:  " + materialTextBoxPlotHeight.Text + @",
                    // xaxis: {
                    //     title: 'X-axi'},
                    yaxis: {
                        title: 'Y-axis (mm)',
                
                        autorange: true,
                        showgrid: true,
                        zeroline: true,
                        dtick: " + linespace + @",
                        gridcolor: 'rgb(255, 255, 255)',
                        gridwidth: 1,
                        zerolinecolor: 'rgb(255, 255, 255)',
                        zerolinewidth: 2
                    },
                    margin: {
                        l: 40,
                        r: 30,
                        b: 80,
                        t: 100
                    }, " + buildshapes() + @"

                    " + buildanno() + @"

                    paper_bgcolor: 'rgb(243, 243, 243)',
                    plot_bgcolor: 'rgb(243, 243, 243)',
                    showlegend: false
                };
  
                    Plotly.newPlot('" + materialTextBoxDIVID.Text + @"', data, layout); ";


            string html = @"
                    <html>
                    <head>
                        <script src='plotly-2.9.0.min.js'></script>
                    </head >
                    <body>
  
                    " + div + @"
    
                        <script>   
                         " + xdata + @"
                         " + ydata + @"
                         " + data + @"
                         " + layout + @"
                        </script>
                    </body>
                    </html>";
            File.WriteAllText(materialTextBoxDIVID + ".html",html);

            webView21.CoreWebView2.Navigate(Path.Combine(Environment.CurrentDirectory, materialTextBoxDIVID + ".html"));
        }
        /// <summary>
        /// adding control line
        /// </summary>
        /// <returns></returns>
        private string buildshapes()
        {
            ///shape
            string shapes = "";

            if (ckbCL.Checked)
            {
                shapes = @"  
                        //目标中线
                        {
                            type: 'line',
                            xref: 'paper',//relative to the screen
                            yref: 'y',//relative to y axis，or container
                            x0: 0,
                            y0: " + txtCL.Text + @",
                            x1: 1,
                            y1: " + txtCL.Text + @",
                            line:{
                                color: 'rgb(0, 255, 0)',
                                width: 4,
                                dash:'dot'
                            }
                        }";
            }

            //USL
            if (ckbUSL.Checked)
            {
                if (shapes == "")
                {
                    shapes = @"  
                        //USL
                        {
                            type: 'line',
                            xref: 'paper',//relative to the screen
                            yref: 'y',//relative to y axis，or container
                            x0: 0,
                            y0: " + txtUSL.Text + @",
                            x1: 1,
                            y1: " + txtUSL.Text + @",
                            line:{
                                color: 'rgb(255, 0, 0)',
                                width: 4,
                                dash:'dot'
                            }
                        }";
                }
                else 
                {
                    shapes = shapes + "," + @"  
                        //USL
                        {
                            type: 'line',
                            xref: 'paper',//relative to the screen
                            yref: 'y',//relative to y axis，or container
                            x0: 0,
                            y0: " + txtUSL.Text + @",
                            x1: 1,
                            y1: " + txtUSL.Text + @",
                            line:{
                                color: 'rgb(255, 0, 0)',
                                width: 4,
                                dash:'dot'
                            }
                        }";
                }

            }

            //LSL
            if (ckbLSL.Checked)
            {
                if (shapes == "")
                {
                    shapes = @"  
                        //LSL
                        {
                            type: 'line',
                            xref: 'paper',//relative to the screen
                            yref: 'y',//relative to y axis，or container
                            x0: 0,
                            y0: " + txtLSL.Text + @",
                            x1: 1,
                            y1: " + txtLSL.Text + @",
                            line:{
                                color: 'rgb(0, 0, 255)',
                                width: 4,
                                dash:'dot'
                            }
                        }";
                }
                else
                {
                    shapes = shapes + "," + @"  
                        //LSL
                        {
                            type: 'line',
                            xref: 'paper',//relative to the screen
                            yref: 'y',//relative to y axis，or container
                            x0: 0,
                            y0: " + txtLSL.Text + @",
                            x1: 1,
                            y1: " + txtLSL.Text + @",
                            line:{
                                color: 'rgb(0, 0, 255)',
                                width: 4,
                                dash:'dot'
                            }
                        }";
                }

            }

            if (shapes != "")
            {
                return @"//control line
                        shapes: [
                         " + shapes + @"
                        ],";
            }
            else
                return "";
        }

        /// <summary>
        /// adding text to control line
        /// </summary>
        /// <returns></returns>
        private string buildanno()
        {

            string anno = "";

            if (ckbCL.Checked)
            {
                anno = @"  
                            //CL
                            {
                            x: 0.9,
                            y: " + txtCL.Text + @",
                            xref: 'paper',
                            yref: 'y',
                            text: 'CL',
                            showarrow: true,
                            font: {
                                family: 'Courier New, monospace',
                                size: 16,
                                color: '#00ff00'
                            },
                            align: 'center',
                            arrowhead: 2,
                            arrowsize: 1,
                            arrowwidth: 2,
                            arrowcolor: '#636363',
                            ax: 20,
                            ay: -30,
                            //bordercolor: '#c7c7c7',
                            //borderwidth: 2,
                            //borderpad: 4,
                            //bgcolor: '#ff7f0e',
                            opacity: 0.8
                            }";
            }

            //USL
            if (ckbUSL.Checked)
            {
                if (anno == "")
                {
                    anno = @"  
                            //USL
                            {
                            x: 0.9,
                            y: " + txtUSL.Text + @",
                            xref: 'paper',
                            yref: 'y',
                            text: ' USL',
                            showarrow: true,
                            font: {
                                family: 'Courier New, monospace',
                                size: 16,
                                color: '#00ff00'
                            },
                            align: 'center',
                            arrowhead: 2,
                            arrowsize: 1,
                            arrowwidth: 2,
                            arrowcolor: '#636363',
                            ax: 20,
                            ay: -30,
                            //bordercolor: '#c7c7c7',
                            //borderwidth: 2,
                            //borderpad: 4,
                            //bgcolor: '#ff7f0e',
                            opacity: 0.8
                            }";
                }
                else
                {
                    anno = anno + "," + @"  
                            //USL
                            {
                            x: 0.9,
                            y: " + txtUSL.Text + @",
                            xref: 'paper',
                            yref: 'y',
                            text: ' USL',
                            showarrow: true,
                            font: {
                                family: 'Courier New, monospace',
                                size: 16,
                                color: '#00ff00'
                            },
                            align: 'center',
                            arrowhead: 2,
                            arrowsize: 1,
                            arrowwidth: 2,
                            arrowcolor: '#636363',
                            ax: 20,
                            ay: -30,
                            //bordercolor: '#c7c7c7',
                            //borderwidth: 2,
                            //borderpad: 4,
                            //bgcolor: '#ff7f0e',
                            opacity: 0.8
                            }";
                }

            }

            //LSL
            if (ckbLSL.Checked)
            {
                if (anno == "")
                {
                    anno = @"  
                            //LSL
                            {
                            x: 0.9,
                            y: " + txtLSL.Text + @",
                            xref: 'paper',
                            yref: 'y',
                            text: ' LSL',
                            showarrow: true,
                            font: {
                                family: 'Courier New, monospace',
                                size: 16,
                                color: '#00ff00'
                            },
                            align: 'center',
                            arrowhead: 2,
                            arrowsize: 1,
                            arrowwidth: 2,
                            arrowcolor: '#636363',
                            ax: 20,
                            ay: -30,
                            //bordercolor: '#c7c7c7',
                            //borderwidth: 2,
                            //borderpad: 4,
                            //bgcolor: '#ff7f0e',
                            opacity: 0.8
                            }";
                }
                else
                {
                    anno = anno + "," + @"  
                            //LSL
                            {
                            x: 0.9,
                            y: " + txtLSL.Text + @",
                            xref: 'paper',
                            yref: 'y',
                            text: ' LSL',
                            showarrow: true,
                            font: {
                                family: 'Courier New, monospace',
                                size: 16,
                                color: '#00ff00'
                            },
                            align: 'center',
                            arrowhead: 2,
                            arrowsize: 1,
                            arrowwidth: 2,
                            arrowcolor: '#636363',
                            ax: 20,
                            ay: -30,
                            //bordercolor: '#c7c7c7',
                            //borderwidth: 2,
                            //borderpad: 4,
                            //bgcolor: '#ff7f0e',
                            opacity: 0.8
                            }";
                }

            }

            if (anno != "")
            {
                return @"//arrow
                        annotations: [
                         " + anno + @"
                        ],";
            }
            else
                return "";
        }
    }
}
