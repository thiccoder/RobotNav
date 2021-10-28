using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Drawing;
using System.Media;

namespace RobotNav
{
    public partial class MainForm : Form
    {
        private readonly List<GMapMarker> Markers = new();
        private GMapMarker selectedMarker;
        private int selectedMarkerIdx = -1;
        private readonly GMapOverlay markerOverlay = new("marker");
        private readonly GMapOverlay polyOverlay = new("polygons");
        private GMapMarker Create(int idx,PointLatLng p,GMarkerGoogleType type = GMarkerGoogleType.green)
        {
            GMapMarker marker = new GMarkerGoogle(p, type);
            marker.ToolTip = new GMapRoundedToolTip(marker);
            marker.ToolTipText = string.Format("Point {0} ({1};{2})",idx, p.Lat, p.Lng);
            markerOverlay.Markers.Add(marker);
            return marker;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        public void Map_Load(object sender, EventArgs e)
        {
            Map.MapProvider = GoogleMapProvider.Instance; 
            GMaps.Instance.Mode = AccessMode.ServerAndCache; 
            Map.Position = new PointLatLng(50.6, 36.6);
            Map.Zoom = 10;
            Map.DragButton = MouseButtons.Left;
            Map.ShowCenter = false;
            Map.Overlays.Add(polyOverlay);
            Map.Overlays.Add(markerOverlay);
            Markers.Add(Create(1, Map.Position));          
        }

        void Map_Mouse(object sender, MouseEventArgs e)
        {
            PointLatLng p = Map.FromLocalToLatLng(e.X, e.Y);
            if (e.Button == MouseButtons.Right && !(selectedMarker is null))
            {
                selectedMarker.Position = p;
                selectedMarker.ToolTipText = string.Format("Point {0} ({1};{2})", selectedMarkerIdx + 1, p.Lat, p.Lng);    
            }
            else if (e.Button == MouseButtons.Middle && Markers.Count < 10)
            {
                Markers.Add(Create(Markers.Count + 1, p));
                SelectMarker(Markers.FindLast(x => true));
            }
            RedrawPath();
        }

        private void SendSMS(object sender, EventArgs e)
        {
            PointLatLng[] ps = new PointLatLng[Markers.Count];
            int i = 0;
            Markers.ForEach(x => ps[i++] = x.Position);
            var w = new SendSMS(ps)
            {
                TopMost = true
            };
            w.Show();
        }

        private void SendSerial(object sender, EventArgs e)
        {
            PointLatLng[] ps = new PointLatLng[Markers.Count];
            int i = 0;
            Markers.ForEach(x => ps[i++] = x.Position);
            var w = new SendSerial(ps)
            {
                TopMost = true
            };
            w.Show();
        }

        private void ExportCSV(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = SaveFileDialog.FileName;
            string csv = "Latitude;Longitude;Name;Description;Icon\n";
            for (int i = 0;i<Markers.Count;i++) 
                csv += string.Format("{0};{1};{2};{3};{4}\n", Markers[i].Position.Lat,Markers[i].Position.Lng, i + 1,i,1);

            File.WriteAllText(filePath, csv.ToString());
            MessageBox.Show("File Saved!");
        }
        private void SelectMarker(GMapMarker marker)
        {
            int idx = int.Parse(marker.ToolTipText.Substring(6, 2)) - 1;
            if (!(selectedMarker is null))
            {
                markerOverlay.Markers.Remove(Markers[selectedMarkerIdx]);
                Markers[selectedMarkerIdx] = Create(selectedMarkerIdx + 1, selectedMarker.Position);
            }
            markerOverlay.Markers.Remove(Markers[idx]);
            if (idx == selectedMarkerIdx)
            {
                Markers[idx] = Create(idx + 1, selectedMarker.Position);
                selectedMarker = null;
                selectedMarkerIdx = -1;
            }
            else
            {
                selectedMarker = Create(idx + 1, marker.Position, GMarkerGoogleType.green_dot);
                selectedMarkerIdx = idx;
                Markers[selectedMarkerIdx] = selectedMarker;
            }
        }
        private void OnMarkerDoubleClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            SelectMarker(item);
        }

        private void Reposition_Click(object sender, EventArgs e)
        {
            if (TryParseCoords(out double lat, out double lng))
            {
                selectedMarker.Position = new PointLatLng(lat, lng);
                selectedMarker.ToolTipText = string.Format("Point {0} ({1};{2})", selectedMarkerIdx + 1, lat, lng);
            }
        }

        private void AddMarker_Click(object sender, EventArgs e)
        {
            if (TryParseCoords(out double lat, out double lng))
            {
                Markers.Add(Create(Markers.Count + 1, new PointLatLng(lat, lng)));
                RedrawPath();
            }
        }
        private bool TryParseCoords(out double lat,out double lng) 
        {
            bool correct = true;
            if (!double.TryParse(LatTextBox.Text.Replace('.',','), out lat))
            {
                SystemSounds.Asterisk.Play();
                LatTextBox.Text = "";
                LatTextBox.SelectionStart = 0;
                correct = false;

            }
            if (!double.TryParse(LngTextBox.Text.Replace('.', ','), out lng))
            {
                SystemSounds.Asterisk.Play();
                LngTextBox.Text = "";
                LngTextBox.SelectionStart = 0;
                correct = false;
            }
            if (selectedMarker is null)
            {
                SystemSounds.Asterisk.Play();
                correct = false;
            }
            return correct;
        }
        private void RedrawPath() 
        {
            polyOverlay.Clear();
            List<PointLatLng> points = new();
            for (int i = 0; i < Markers.Count; i++)
            {
                points.Add(Markers[i].Position);
            }
            for (int i = Markers.Count - 1; i >= 0; i--)
            {
                points.Add(Markers[i].Position);
            }
            GMapPolygon polygon = new(points, "Path");
            polygon.Stroke = new Pen(Color.Green, 5);
            polyOverlay.Polygons.Add(polygon);
        }
    }
}
