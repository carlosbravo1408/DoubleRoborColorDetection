using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Math.Geometry;
using AForge.Math;
using System.IO.Ports;

namespace VideoCapture
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] videoCapabilities;
        private SerialPort puerto;
        private string[] puertos;
        bool condr = false;
        bool condg = false;
        bool condb = false;
        int o = 0, p = 0, q = 0;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            puertos_disponibles();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count != 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    cbx_camaras.Items.Add(device.Name);
                }
            }
            else
            {
                cbx_camaras.Items.Add("No DirectShow devices found");
            }
        }

        private void EnumeratedSupportedFrameSizes(VideoCaptureDevice videoDevice)
        {
            this.Cursor = Cursors.WaitCursor;

            cbx_resolucion.Items.Clear();

            try
            {
                videoCapabilities = videoDevice.VideoCapabilities;
                foreach (VideoCapabilities capabilty in videoCapabilities)
                {
                    cbx_resolucion.Items.Add(string.Format("{0} x {1}",
                        capabilty.FrameSize.Width, capabilty.FrameSize.Height));
                }

                if (videoCapabilities.Length == 0)
                {
                    cbx_resolucion.Items.Add("Not supported");
                }
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cbx_camaras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoDevices.Count != 0)
            {
                videoDevice = new VideoCaptureDevice(videoDevices[cbx_camaras.SelectedIndex].MonikerString);
                EnumeratedSupportedFrameSizes(videoDevice);
                cbx_resolucion.SelectedIndex=0;
            }
            rtx_indicativo.Text = rtx_indicativo.Text + "Cámara " + videoDevices[cbx_camaras.SelectedIndex].Name+" seleccionada\n";
        }

        private void cbx_resolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtx_indicativo.Text = rtx_indicativo.Text + "Resolucion de la cámara " + videoCapabilities[cbx_resolucion.SelectedIndex].FrameSize.Width +"x"+ videoCapabilities[cbx_resolucion.SelectedIndex].FrameSize.Height +"\n";
        }

        private void btn_camara_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    videoDevice.VideoResolution = videoCapabilities[cbx_resolucion.SelectedIndex];
                }
                videoSourceCaptura.VideoSource = videoDevice;
                videoSourceCaptura.Start();

                videoDevice.NewFrame += new NewFrameEventHandler(get_Frame);
                videoDevice.Start();
                rtx_indicativo.Text = rtx_indicativo.Text + "*Cámara conectada*\n";
            }
        }
        private void get_Frame(object sender, NewFrameEventArgs eventArgs)
        {
            //Insert image into Picuture Box
            Bitmap _BsourceFrame = (Bitmap)eventArgs.Frame.Clone();
            Bitmap imageR = (Bitmap)eventArgs.Frame.Clone();
            Bitmap imageG = (Bitmap)eventArgs.Frame.Clone();
            Bitmap imageB = (Bitmap)eventArgs.Frame.Clone();

            Bitmap imagenR = (Bitmap)eventArgs.Frame.Clone();
            Bitmap imagenG = (Bitmap)eventArgs.Frame.Clone();
            Bitmap imagenB = (Bitmap)eventArgs.Frame.Clone();

            EuclideanColorFiltering filterR = new EuclideanColorFiltering();
            EuclideanColorFiltering filterG = new EuclideanColorFiltering();
            EuclideanColorFiltering filterB = new EuclideanColorFiltering();

            //EuclideanColorFiltering filternR = new EuclideanColorFiltering();
            //EuclideanColorFiltering filternG = new EuclideanColorFiltering();
            //EuclideanColorFiltering filternB = new EuclideanColorFiltering();

            filterR.CenterColor = new RGB(Color.FromArgb((int)nudRr.Value, (int)nudRg.Value, (int)nudRb.Value));
            filterR.Radius = 100;
            filterR.ApplyInPlace(imagenR);
            filterR.ApplyInPlace(imageR);
            videoSourceR.Image = imagenR;

            //filternR.CenterColor = new RGB(Color.FromArgb(215, 0, 0));
            //filternR.Radius = 100;
            //filternR.ApplyInPlace(imageR);

            filterG.CenterColor = new RGB(Color.FromArgb((int)nudGr.Value, (int)nudGg.Value, (int)nudGb.Value));
            filterG.Radius = 100;
            filterG.ApplyInPlace(imagenG);
            filterG.ApplyInPlace(imageG);
            videoSourceG.Image = imagenG;

            //filternG.CenterColor = new RGB(Color.FromArgb(0, 215, 0));
            //filternG.Radius = 100;
            //filternG.ApplyInPlace(imageG);

            filterB.CenterColor = new RGB(Color.FromArgb((int)nudBr.Value, (int)nudBg.Value, (int)nudBb.Value));
            filterB.Radius = 100;
            filterB.ApplyInPlace(imagenB);
            filterB.ApplyInPlace(imageB);
            videoSourceB.Image = imagenB;

            //filternB.CenterColor = new RGB(Color.FromArgb(30, 144, 255));
            //filternB.Radius = 100;
            //filternB.ApplyInPlace(imageB);

            try
            {
                ImageStatistics statR = new ImageStatistics(imageR);
                Histogram red = statR.Red;

                ImageStatistics statG = new ImageStatistics(imageG);
                Histogram green = statG.Green;

                ImageStatistics statB = new ImageStatistics(imageB);
                Histogram blue = statB.Green;

                label4.Text = red.Max.ToString();
                label5.Text = blue.Max.ToString();
                label6.Text = green.Max.ToString();

                if (red.Max > 185)
                    label1.Text = "Red";
                else
                    label1.Text = "black";

                if (green.Max > 170)
                    label2.Text = "Green";
                else
                    label2.Text = "black";

                if (blue.Max > 90)
                    label3.Text = "Blue";
                else
                    label3.Text = "black";
            }catch (Exception ex)
            {}
            videoSourceBlob.Image = BlobDetection(_BsourceFrame);
        }
       
       private Bitmap BlobDetection(Bitmap _bitmapSourceImage)
        {
           Grayscale _grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap _bitmapGreyImage = _grayscale.Apply(_bitmapSourceImage);

            //create a edge detector instance
            DifferenceEdgeDetector _differeceEdgeDetector = new DifferenceEdgeDetector();
            Bitmap _bitmapEdgeImage = _differeceEdgeDetector.Apply(_bitmapGreyImage);

            Threshold _threshold = new Threshold(40);
            Bitmap _bitmapBinaryImage = _threshold.Apply(_bitmapEdgeImage);

            //Create a instance of blob counter algorithm
            BlobCounter _blobCounter = new BlobCounter();
            //Configure Filter
            _blobCounter.MinWidth = 70;
            _blobCounter.MinHeight = 70;
            _blobCounter.FilterBlobs = true;

            _blobCounter.ProcessImage(_bitmapBinaryImage);
            Blob[] _blobPoints = _blobCounter.GetObjectsInformation();

            Graphics _g = Graphics.FromImage(_bitmapSourceImage);

            SimpleShapeChecker _shapeChecker = new SimpleShapeChecker();
            for (int i = 0; i < _blobPoints.Length; i++)
            {
                List<IntPoint> _edgePoint = _blobCounter.GetBlobsEdgePoints(_blobPoints[i]);
                List<IntPoint> _corners = null;
                AForge.Point _center;
                float _radius;
                if (_shapeChecker.IsQuadrilateral(_edgePoint, out _corners))
                {
                    //MessageBox.Show(""+_shapeChecker.CheckShapeType(_edgePoint));
                    label13.Text = "Cuadrilatero";
                    System.Drawing.Font _font = new System.Drawing.Font("Segoe UI", 16);
                    System.Drawing.SolidBrush _brush = new System.Drawing.SolidBrush(System.Drawing.Color.PaleGreen);
                    System.Drawing.Point[] _coordinates = ToPointsArray(_corners);
                    if (_coordinates.Length == 4)
                    {
                        int _x = _coordinates[0].X;
                        int _y = _coordinates[0].Y;
                        Pen _pen = new Pen(Color.Brown);
                        string _shapeString = "" + _shapeChecker.CheckShapeType(_edgePoint);
                        _g.DrawString(_shapeString, _font, _brush, _x, _y);
                        _g.DrawPolygon(_pen, ToPointsArray(_corners));
                    }
                }
                else label13.Text = "";
                if (_shapeChecker.IsCircle(_edgePoint, out _center, out _radius))
                {
                    label14.Text = "Circulo";
                    string _shapeString = "" + _shapeChecker.CheckShapeType(_edgePoint);
                    System.Drawing.Font _font = new System.Drawing.Font("Segoe UI", 16);
                    System.Drawing.SolidBrush _brush = new System.Drawing.SolidBrush(System.Drawing.Color.Chocolate);
                    Pen _pen = new Pen(Color.GreenYellow);
                    int x = (int)_center.X;
                    int y = (int)_center.Y;
                    _g.DrawString(_shapeString, _font, _brush, x, y);
                    _g.DrawEllipse(_pen, (float)(_center.X - _radius),
                                         (float)(_center.Y - _radius),
                                         (float)(_radius * 2),
                                         (float)(_radius * 2));
                }
                else label14.Text = "";
                if (_shapeChecker.IsTriangle(_edgePoint, out _corners))
                {
                    label15.Text = "Triangulo";
                    string _shapeString = "" + _shapeChecker.CheckShapeType(_edgePoint);
                    System.Drawing.Font _font = new System.Drawing.Font("Segoe UI", 16);
                    System.Drawing.SolidBrush _brush = new System.Drawing.SolidBrush(System.Drawing.Color.Brown);
                    Pen _pen = new Pen(Color.GreenYellow);
                    int x = (int)_center.X;
                    int y = (int)_center.Y;
                    _g.DrawString(_shapeString, _font, _brush, x, y);
                    _g.DrawPolygon(_pen, ToPointsArray(_corners));
                }
                else label15.Text = "";
            }
            return _bitmapSourceImage;
        }

        private System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];

            for (int i = 0, n = points.Count; i < n; i++)
            {
                array[i] = new System.Drawing.Point(points[i].X, points[i].Y);
            }

            return array;
        }

        private void videoSourceR_DoubleClick(object sender, EventArgs e)
        {
            if (condr == false)
            {
                groupBox5.Enabled = true;
                condr = true;
            }
            else
            {
                condr = false;
                groupBox5.Enabled = false;
            }
        }

        private void videoSourceG_DoubleClick(object sender, EventArgs e)
        {
            if (condg == false)
            {
                groupBox6.Enabled = true;
                condg = true;
            }
            else
            {
                condg = false;
                groupBox6.Enabled = false;
            }
        }

        private void videoSourceB_DoubleClick(object sender, EventArgs e)
        {
            if (condb == false)
            {
                groupBox7.Enabled = true;
                condb = true;
            }
            else
            {
                condb = false;
                groupBox7.Enabled = false;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Red" && label14.Text == "Circulo" && o == 1)
            {
                //aquí enviar secuencia para circulo rojo
                rtx_indicativo.Text = rtx_indicativo.Text + "Comando Enviado: *CirculoRojo*\n";
                rtx_indicativo.Text = rtx_indicativo.Text + "rd\n";
                if (puerto.IsOpen)
                {
                    puerto.WriteLine("r");
                    puerto.WriteLine("d");
                }
            }
            if (label2.Text == "Green" && label14.Text == "Circulo" && p == 1)
            {
                //aquí enviar secuencia para circulo verde
                rtx_indicativo.Text = rtx_indicativo.Text + "Comando Enviado: *CirculoVerde*\n";
                rtx_indicativo.Text = rtx_indicativo.Text + "re\n";
                if (puerto.IsOpen)
                {
                    puerto.WriteLine("r");
                    puerto.WriteLine("e");
                }
            }
            if (label3.Text == "Blue" && label14.Text == "Circulo" && q == 1)
            {
                //aquí enviar secuencia para circulo verde
                rtx_indicativo.Text = rtx_indicativo.Text + "Comando Enviado: *CirculoAzul*\n";
                rtx_indicativo.Text = rtx_indicativo.Text + "rf\n";
                if (puerto.IsOpen)
                {
                    puerto.WriteLine("r");
                    puerto.WriteLine("f");
                }
            }
            //rtx_indicativo.Text = rtx_indicativo.Text + "Inicialización";
            if (label1.Text == "Red" && label14.Text == "Circulo" && o==0)
            {
                //aquí enviar secuencia para circulo rojo
                rtx_indicativo.Text = rtx_indicativo.Text + "Comando Enviado: *CirculoRojo*\n";
                rtx_indicativo.Text = rtx_indicativo.Text + "ra\n";
                if (puerto.IsOpen)
                {
                    puerto.WriteLine("r");
                    puerto.WriteLine("a");
                }
                o = 1;
            }
            if (label2.Text == "Green" && label14.Text == "Circulo" && p==0)
            {
                //aquí enviar secuencia para circulo verde
                rtx_indicativo.Text = rtx_indicativo.Text + "Comando Enviado: *CirculoVerde*\n";
                rtx_indicativo.Text = rtx_indicativo.Text + "rb\n";
                if (puerto.IsOpen)
                {
                    puerto.WriteLine("r");
                    puerto.WriteLine("b");
                }
                p = 1;
            }
            if (label3.Text == "Blue" && label14.Text == "Circulo" && q==0)
            {
                //aquí enviar secuencia para circulo verde
                rtx_indicativo.Text = rtx_indicativo.Text + "Comando Enviado: *CirculoAzul*\n";
                rtx_indicativo.Text = rtx_indicativo.Text + "rc\n";
                if (puerto.IsOpen)
                {
                    puerto.WriteLine("r");
                    puerto.WriteLine("c");
                }
                q = 1;
            }
            if (label1.Text == "Red" && label13.Text == "Cuadrilatero")
            {
                //aquí enviar secuencia para circulo rojo
                rtx_indicativo.Text = rtx_indicativo.Text + "Comando Enviado: *CuadrilateroRojo*\n";
                rtx_indicativo.Text = rtx_indicativo.Text + "RA\n";
                if (puerto.IsOpen)
                {
                    puerto.WriteLine("R");
                    puerto.WriteLine("A");
                }
            }
            if (label2.Text == "Green" && label13.Text == "Cuadrilatero")
            {
                //aquí enviar secuencia para circulo verde
                rtx_indicativo.Text = rtx_indicativo.Text + "Comando Enviado: *CuadrilateroVerde*\n";
                rtx_indicativo.Text = rtx_indicativo.Text + "RB\n";
                if (puerto.IsOpen)
                {
                    puerto.WriteLine("R");
                    puerto.WriteLine("B");
                }
            }
            if (label3.Text == "Blue" && label13.Text == "Cuadrilatero")
            {
                //aquí enviar secuencia para circulo verde
                rtx_indicativo.Text = rtx_indicativo.Text + "Comando Enviado: *CuadrilateroAzul*\n";
                rtx_indicativo.Text = rtx_indicativo.Text + "RC\n";
                if (puerto.IsOpen)
                {
                    puerto.WriteLine("R");
                    puerto.WriteLine("C");
                }
            }
            //rtx_indicativo.Text = rtx_indicativo.Text + "Comando enviado ";
        }

        private void cbx_Puerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtx_indicativo.Text = rtx_indicativo.Text + "Puerto Seleccionado " + cbx_Puerto.SelectedItem.ToString()+"\n";
        }
        private void puertos_disponibles()
        {
            puertos = SerialPort.GetPortNames();
            if (puertos.Length > 0)
            {
                cbx_Puerto.Items.Clear();
                foreach (string puertosseriales in SerialPort.GetPortNames())
                {
                    cbx_Puerto.Items.Add(puertosseriales);
                }
                //estado = false;
            }
            else
            {
                MessageBox.Show(this, "Lo sentimos, no hubo puertos disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //estado = false;
            }
        }

        private void btn_puerto_Click(object sender, EventArgs e)
        {
            try
            {
                puerto = new SerialPort();
                puerto.PortName = cbx_Puerto.SelectedItem.ToString();
                puerto.BaudRate = 9600;

                if (!puerto.IsOpen)
                {
                    puerto.Open();
                    rtx_indicativo.Text = rtx_indicativo.Text + "Puerto Conectado " + cbx_Puerto.SelectedItem.ToString() + "@9600 baud\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Seleccione un puerto adecuado.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtx_indicativo.Text = rtx_indicativo.Text + "Error de Conexion! " + "\n";
            }
        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont++;
            label7.Text = Convert.ToString(cont);
            if(cont==5)
            {
                button1_Click(sender, e);
            }
        }

        private void label13_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text != "black" || label2.Text != "black" || label3.Text != "black")
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }

        private void label15_TextChanged(object sender, EventArgs e)
        {
            label13_TextChanged(sender, e);
        }

        private void label14_TextChanged(object sender, EventArgs e)
        {
            label13_TextChanged(sender, e);
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            label13_TextChanged(sender, e);
        }
    }
}
