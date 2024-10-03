using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRAPI_GAMES
{
    public partial class Frm_jugar : Form
    {
        /*VARIABLES DE ASIGNACION*/
        public int dato_c = 0, dato_f = 0, i = 0;

        private void Frm_jugar_Load(object sender, EventArgs e) { }
        private void Lbl_r1_Click(object sender, EventArgs e) { }
        private void Lbl_r1_MouseClick(object sender, MouseEventArgs e) { }
        public Frm_jugar() { InitializeComponent(); }
        private void Lbl_r12_Click(object sender, EventArgs e){ }
        private void Lbl_r11_MouseClick(object sender, MouseEventArgs e) { }

        //COLUMNAS
        private void L_c1_MouseClick(object sender, MouseEventArgs e) { this.dato_c = 1; }
        private void L_c2_MouseClick(object sender, MouseEventArgs e) { this.dato_c = 2; }
        private void L_c3_MouseClick(object sender, MouseEventArgs e) { this.dato_c = 3; }
        private void L_c4_MouseClick(object sender, MouseEventArgs e) { this.dato_c = 4; }
        private void L_c5_MouseClick(object sender, MouseEventArgs e) { this.dato_c = 5; }
        private void L_c6_MouseClick(object sender, MouseEventArgs e) { this.dato_c = 6; }
        private void L_c7_MouseClick(object sender, MouseEventArgs e) { this.dato_c = 7; }
        private void L_c8_MouseClick(object sender, MouseEventArgs e) { this.dato_c = 8; }
        private void L_c9_MouseClick(object sender, MouseEventArgs e) { this.dato_c = 9; }
        private void L_c10_MouseClick(object sender, MouseEventArgs e) { this.dato_c = 10; }

        //FILAS
        private void L_f1_MouseClick(object sender, MouseEventArgs e) { this.dato_f = 1; }
        private void L_f2_MouseClick(object sender, MouseEventArgs e) { this.dato_f = 2; }
        private void L_f3_MouseClick(object sender, MouseEventArgs e) { this.dato_f = 3; }
        private void L_f4_MouseClick(object sender, MouseEventArgs e) { this.dato_f = 4; }
        private void L_f5_MouseClick(object sender, MouseEventArgs e) { this.dato_f = 5; }
        private void L_f6_MouseClick(object sender, MouseEventArgs e) { this.dato_f = 6; }
        private void L_f7_MouseClick(object sender, MouseEventArgs e) { this.dato_f = 7; }
        private void L_f8_MouseClick(object sender, MouseEventArgs e) { this.dato_f = 8; }
        private void L_f9_MouseClick(object sender, MouseEventArgs e) { this.dato_f = 9; }
        private void L_f10_MouseClick(object sender, MouseEventArgs e) { this.dato_f = 10; }

        private void Operar_Click(object sender, EventArgs e)
        {
            try
            {
                Txt1.Clear();
                Txt3.Clear();
                Txt5.Clear();
                //TABLA 1 - 10
                if ((dato_c == 1) && (dato_f == 1)) { Lbl_r1.Visible = true; Lbl_r1.Text = "1"; }
                if ((dato_c == 1) && (dato_f == 2)) { Lbl_r2.Visible = true; Lbl_r2.Text = "2"; }
                if ((dato_c == 1) && (dato_f == 3)) { Lbl_r3.Visible = true; Lbl_r3.Text = "3"; }
                if ((dato_c == 1) && (dato_f == 4)) { Lbl_r4.Visible = true; Lbl_r4.Text = "4"; }
                if ((dato_c == 1) && (dato_f == 5)) { Lbl_r5.Visible = true; Lbl_r5.Text = "5"; }
                if ((dato_c == 1) && (dato_f == 6)) { Lbl_r6.Visible = true; Lbl_r6.Text = "6"; }
                if ((dato_c == 1) && (dato_f == 7)) { Lbl_r7.Visible = true; Lbl_r7.Text = "7"; }
                if ((dato_c == 1) && (dato_f == 8)) { Lbl_r8.Visible = true; Lbl_r8.Text = "8"; }
                if ((dato_c == 1) && (dato_f == 9)) { Lbl_r9.Visible = true; Lbl_r9.Text = "9"; }
                if ((dato_c == 1) && (dato_f == 10)) { Lbl_r10.Visible = true; Lbl_r10.Text = "10"; }
                //TABLA 2 - 10
                if ((dato_c == 2) && (dato_f == 1)) { Lbl_r11.Visible = true; Lbl_r11.Text = "2"; }
                if ((dato_c == 2) && (dato_f == 2)) { Lbl_r12.Visible = true; Lbl_r12.Text = "4"; }
                if ((dato_c == 2) && (dato_f == 3)) { Lbl_r13.Visible = true; Lbl_r13.Text = "6"; }
                if ((dato_c == 2) && (dato_f == 4)) { Lbl_r14.Visible = true; Lbl_r14.Text = "8"; }
                if ((dato_c == 2) && (dato_f == 5)) { Lbl_r15.Visible = true; Lbl_r15.Text = "10"; }
                if ((dato_c == 2) && (dato_f == 6)) { Lbl_r16.Visible = true; Lbl_r16.Text = "12"; }
                if ((dato_c == 2) && (dato_f == 7)) { Lbl_r17.Visible = true; Lbl_r17.Text = "14"; }
                if ((dato_c == 2) && (dato_f == 8)) { Lbl_r18.Visible = true; Lbl_r18.Text = "16"; }
                if ((dato_c == 2) && (dato_f == 9)) { Lbl_r19.Visible = true; Lbl_r19.Text = "18"; }
                if ((dato_c == 2) && (dato_f == 10)) { Lbl_r20.Visible = true; Lbl_r20.Text = "20"; }
                //TABLA 3 - 10
                if ((dato_c == 3) && (dato_f == 1)) { Lbl_r21.Visible = true; Lbl_r21.Text = "3"; }
                if ((dato_c == 3) && (dato_f == 2)) { Lbl_r22.Visible = true; Lbl_r22.Text = "6"; }
                if ((dato_c == 3) && (dato_f == 3)) { Lbl_r23.Visible = true; Lbl_r23.Text = "9"; }
                if ((dato_c == 3) && (dato_f == 4)) { Lbl_r24.Visible = true; Lbl_r24.Text = "12"; }
                if ((dato_c == 3) && (dato_f == 5)) { Lbl_r25.Visible = true; Lbl_r25.Text = "15"; }
                if ((dato_c == 3) && (dato_f == 6)) { Lbl_r26.Visible = true; Lbl_r26.Text = "18"; }
                if ((dato_c == 3) && (dato_f == 7)) { Lbl_r27.Visible = true; Lbl_r27.Text = "21"; }
                if ((dato_c == 3) && (dato_f == 8)) { Lbl_r28.Visible = true; Lbl_r28.Text = "24"; }
                if ((dato_c == 3) && (dato_f == 9)) { Lbl_r29.Visible = true; Lbl_r29.Text = "27"; }
                if ((dato_c == 3) && (dato_f == 10)) { Lbl_r30.Visible = true; Lbl_r30.Text = "30"; }
                //TABLA 4 - 10
                if ((dato_c == 4) && (dato_f == 1)) { Lbl_r31.Visible = true; Lbl_r31.Text = "4"; }
                if ((dato_c == 4) && (dato_f == 2)) { Lbl_r32.Visible = true; Lbl_r32.Text = "8"; }
                if ((dato_c == 4) && (dato_f == 3)) { Lbl_r33.Visible = true; Lbl_r33.Text = "12"; }
                if ((dato_c == 4) && (dato_f == 4)) { Lbl_r34.Visible = true; Lbl_r34.Text = "16"; }
                if ((dato_c == 4) && (dato_f == 5)) { Lbl_r35.Visible = true; Lbl_r35.Text = "20"; }
                if ((dato_c == 4) && (dato_f == 6)) { Lbl_r36.Visible = true; Lbl_r36.Text = "24"; }
                if ((dato_c == 4) && (dato_f == 7)) { Lbl_r37.Visible = true; Lbl_r37.Text = "28"; }
                if ((dato_c == 4) && (dato_f == 8)) { Lbl_r38.Visible = true; Lbl_r38.Text = "32"; }
                if ((dato_c == 4) && (dato_f == 9)) { Lbl_r39.Visible = true; Lbl_r39.Text = "36"; }
                if ((dato_c == 4) && (dato_f == 10)) { Lbl_r40.Visible = true; Lbl_r40.Text = "40"; }
                //TABLA 5 - 10
                if ((dato_c == 5) && (dato_f == 1)) { Lbl_r41.Visible = true; Lbl_r41.Text = "5"; }
                if ((dato_c == 5) && (dato_f == 2)) { Lbl_r42.Visible = true; Lbl_r42.Text = "10"; }
                if ((dato_c == 5) && (dato_f == 3)) { Lbl_r43.Visible = true; Lbl_r43.Text = "15"; }
                if ((dato_c == 5) && (dato_f == 4)) { Lbl_r44.Visible = true; Lbl_r44.Text = "20"; }
                if ((dato_c == 5) && (dato_f == 5)) { Lbl_r45.Visible = true; Lbl_r45.Text = "25"; }
                if ((dato_c == 5) && (dato_f == 6)) { Lbl_r46.Visible = true; Lbl_r46.Text = "30"; }
                if ((dato_c == 5) && (dato_f == 7)) { Lbl_r47.Visible = true; Lbl_r47.Text = "35"; }
                if ((dato_c == 5) && (dato_f == 8)) { Lbl_r48.Visible = true; Lbl_r48.Text = "40"; }
                if ((dato_c == 5) && (dato_f == 9)) { Lbl_r49.Visible = true; Lbl_r49.Text = "45"; }
                if ((dato_c == 5) && (dato_f == 10)) { Lbl_r50.Visible = true; Lbl_r50.Text = "50"; }
                //TABLA 6 - 10
                if ((dato_c == 6) && (dato_f == 1)) { Lbl_r51.Visible = true; Lbl_r51.Text = "6"; }
                if ((dato_c == 6) && (dato_f == 2)) { Lbl_r52.Visible = true; Lbl_r52.Text = "12"; }
                if ((dato_c == 6) && (dato_f == 3)) { Lbl_r53.Visible = true; Lbl_r53.Text = "18"; }
                if ((dato_c == 6) && (dato_f == 4)) { Lbl_r54.Visible = true; Lbl_r54.Text = "24"; }
                if ((dato_c == 6) && (dato_f == 5)) { Lbl_r55.Visible = true; Lbl_r55.Text = "30"; }
                if ((dato_c == 6) && (dato_f == 6)) { Lbl_r56.Visible = true; Lbl_r56.Text = "36"; }
                if ((dato_c == 6) && (dato_f == 7)) { Lbl_r57.Visible = true; Lbl_r57.Text = "42"; }
                if ((dato_c == 6) && (dato_f == 8)) { Lbl_r58.Visible = true; Lbl_r58.Text = "48"; }
                if ((dato_c == 6) && (dato_f == 9)) { Lbl_r59.Visible = true; Lbl_r59.Text = "54"; }
                if ((dato_c == 6) && (dato_f == 10)) { Lbl_r60.Visible = true; Lbl_r60.Text = "60"; }
                //TABLA 7 - 10
                if ((dato_c == 7) && (dato_f == 1)) { Lbl_r61.Visible = true; Lbl_r61.Text = "7"; }
                if ((dato_c == 7) && (dato_f == 2)) { Lbl_r62.Visible = true; Lbl_r62.Text = "14"; }
                if ((dato_c == 7) && (dato_f == 3)) { Lbl_r63.Visible = true; Lbl_r63.Text = "21"; }
                if ((dato_c == 7) && (dato_f == 4)) { Lbl_r64.Visible = true; Lbl_r64.Text = "28"; }
                if ((dato_c == 7) && (dato_f == 5)) { Lbl_r65.Visible = true; Lbl_r65.Text = "35"; }
                if ((dato_c == 7) && (dato_f == 6)) { Lbl_r66.Visible = true; Lbl_r66.Text = "42"; }
                if ((dato_c == 7) && (dato_f == 7)) { Lbl_r67.Visible = true; Lbl_r67.Text = "49"; }
                if ((dato_c == 7) && (dato_f == 8)) { Lbl_r68.Visible = true; Lbl_r68.Text = "56"; }
                if ((dato_c == 7) && (dato_f == 9)) { Lbl_r69.Visible = true; Lbl_r69.Text = "63"; }
                if ((dato_c == 7) && (dato_f == 10)) { Lbl_r70.Visible = true; Lbl_r70.Text = "70"; }
                //TABLA 8 - 10
                if ((dato_c == 8) && (dato_f == 1)) { Lbl_r71.Visible = true; Lbl_r71.Text = "8"; }
                if ((dato_c == 8) && (dato_f == 2)) { Lbl_r72.Visible = true; Lbl_r72.Text = "16"; }
                if ((dato_c == 8) && (dato_f == 3)) { Lbl_r73.Visible = true; Lbl_r73.Text = "24"; }
                if ((dato_c == 8) && (dato_f == 4)) { Lbl_r74.Visible = true; Lbl_r74.Text = "32"; }
                if ((dato_c == 8) && (dato_f == 5)) { Lbl_r75.Visible = true; Lbl_r75.Text = "40"; }
                if ((dato_c == 8) && (dato_f == 6)) { Lbl_r76.Visible = true; Lbl_r76.Text = "48"; }
                if ((dato_c == 8) && (dato_f == 7)) { Lbl_r77.Visible = true; Lbl_r77.Text = "56"; }
                if ((dato_c == 8) && (dato_f == 8)) { Lbl_r78.Visible = true; Lbl_r78.Text = "64"; }
                if ((dato_c == 8) && (dato_f == 9)) { Lbl_r79.Visible = true; Lbl_r79.Text = "72"; }
                if ((dato_c == 8) && (dato_f == 10)) { Lbl_r80.Visible = true; Lbl_r80.Text = "80"; }
                //TABLA 9 - 10
                if ((dato_c == 9) && (dato_f == 1)) { Lbl_r81.Visible = true; Lbl_r81.Text = "9"; }
                if ((dato_c == 9) && (dato_f == 2)) { Lbl_r82.Visible = true; Lbl_r82.Text = "18"; }
                if ((dato_c == 9) && (dato_f == 3)) { Lbl_r83.Visible = true; Lbl_r83.Text = "27"; }
                if ((dato_c == 9) && (dato_f == 4)) { Lbl_r84.Visible = true; Lbl_r84.Text = "36"; }
                if ((dato_c == 9) && (dato_f == 5)) { Lbl_r85.Visible = true; Lbl_r85.Text = "46"; }
                if ((dato_c == 9) && (dato_f == 6)) { Lbl_r86.Visible = true; Lbl_r86.Text = "55"; }
                if ((dato_c == 9) && (dato_f == 7)) { Lbl_r87.Visible = true; Lbl_r87.Text = "63"; }
                if ((dato_c == 9) && (dato_f == 8)) { Lbl_r88.Visible = true; Lbl_r88.Text = "72"; }
                if ((dato_c == 9) && (dato_f == 9)) { Lbl_r89.Visible = true; Lbl_r89.Text = "81"; }
                if ((dato_c == 9) && (dato_f == 10)) { Lbl_r90.Visible = true; Lbl_r90.Text = "90"; }
                //TABLA 10 - 10
                if ((dato_c == 10) && (dato_f == 1)) { Lbl_r91.Visible = true; Lbl_r91.Text = "10"; }
                if ((dato_c == 10) && (dato_f == 2)) { Lbl_r92.Visible = true; Lbl_r92.Text = "20"; }
                if ((dato_c == 10) && (dato_f == 3)) { Lbl_r93.Visible = true; Lbl_r93.Text = "30"; }
                if ((dato_c == 10) && (dato_f == 4)) { Lbl_r94.Visible = true; Lbl_r94.Text = "40"; }
                if ((dato_c == 10) && (dato_f == 5)) { Lbl_r95.Visible = true; Lbl_r95.Text = "50"; }
                if ((dato_c == 10) && (dato_f == 6)) { Lbl_r96.Visible = true; Lbl_r96.Text = "60"; }
                if ((dato_c == 10) && (dato_f == 7)) { Lbl_r97.Visible = true; Lbl_r97.Text = "70"; }
                if ((dato_c == 10) && (dato_f == 8)) { Lbl_r98.Visible = true; Lbl_r98.Text = "80"; }
                if ((dato_c == 10) && (dato_f == 9)) { Lbl_r99.Visible = true; Lbl_r99.Text = "90"; }
                if ((dato_c == 10) && (dato_f == 10)) { Lbl_r100.Visible = true; Lbl_r100.Text = "100"; }
                Txt1.Text = Convert.ToString(dato_c);
                Txt3.Text = Convert.ToString(dato_f);
                Txt5.Text = Convert.ToString(dato_c * dato_f);
                i++;

                if(i==100)
                {
                    Frm_victoria ventana = new Frm_victoria();
                    ventana.Show();
                }

            }
            catch (Exception) { }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            //TABLA 1 - 10
            Lbl_r1.Visible = false; Lbl_r1.Text = "1"; 
            Lbl_r2.Visible = false; Lbl_r2.Text = "2"; 
            Lbl_r3.Visible = false; Lbl_r3.Text = "3"; 
            Lbl_r4.Visible = false; Lbl_r4.Text = "4"; 
            Lbl_r5.Visible = false; Lbl_r5.Text = "5";
            Lbl_r6.Visible = false; Lbl_r6.Text = "6"; 
            Lbl_r7.Visible = false; Lbl_r7.Text = "7"; 
            Lbl_r8.Visible = false; Lbl_r8.Text = "8"; 
            Lbl_r9.Visible = false; Lbl_r9.Text = "9"; 
            Lbl_r10.Visible = false; Lbl_r10.Text = "10"; 
            //TABLA 2 - 10
            Lbl_r11.Visible = false; Lbl_r11.Text = "2"; 
            Lbl_r12.Visible = false; Lbl_r12.Text = "4";
            Lbl_r13.Visible = false; Lbl_r13.Text = "6"; 
            Lbl_r14.Visible = false; Lbl_r14.Text = "8"; 
            Lbl_r15.Visible = false; Lbl_r15.Text = "10"; 
            Lbl_r16.Visible = false; Lbl_r16.Text = "12"; 
            Lbl_r17.Visible = false; Lbl_r17.Text = "14"; 
            Lbl_r18.Visible = false; Lbl_r18.Text = "16"; 
            Lbl_r19.Visible = false; Lbl_r19.Text = "18"; 
            Lbl_r20.Visible = false; Lbl_r20.Text = "20"; 
            //TABLA 3 - 10
            Lbl_r21.Visible = false; Lbl_r21.Text = "3"; 
            Lbl_r22.Visible = false; Lbl_r22.Text = "6"; 
            Lbl_r23.Visible = false; Lbl_r23.Text = "9"; 
            Lbl_r24.Visible = false; Lbl_r24.Text = "12"; 
            Lbl_r25.Visible = false; Lbl_r25.Text = "15";
            Lbl_r26.Visible = false; Lbl_r26.Text = "18"; 
            Lbl_r27.Visible = false; Lbl_r27.Text = "21"; 
            Lbl_r28.Visible = false; Lbl_r28.Text = "24"; 
            Lbl_r29.Visible = false; Lbl_r29.Text = "27"; 
            Lbl_r30.Visible = false; Lbl_r30.Text = "30"; 
            //TABLA 4 - 10
            Lbl_r31.Visible = false; Lbl_r31.Text = "4"; 
            Lbl_r32.Visible = false; Lbl_r32.Text = "8"; 
            Lbl_r33.Visible = false; Lbl_r33.Text = "12"; 
            Lbl_r34.Visible = false; Lbl_r34.Text = "16"; 
            Lbl_r35.Visible = false; Lbl_r35.Text = "20"; 
            Lbl_r36.Visible = false; Lbl_r36.Text = "24"; 
            Lbl_r37.Visible = false; Lbl_r37.Text = "28"; 
            Lbl_r38.Visible = false; Lbl_r38.Text = "32";
            Lbl_r39.Visible = false; Lbl_r39.Text = "36"; 
            Lbl_r40.Visible = false; Lbl_r40.Text = "40"; 
            //TABLA 5 - 10
            Lbl_r41.Visible = false; Lbl_r41.Text = "5";
            Lbl_r42.Visible = false; Lbl_r42.Text = "10"; 
            Lbl_r43.Visible = false; Lbl_r43.Text = "15"; 
            Lbl_r44.Visible = false; Lbl_r44.Text = "20"; 
            Lbl_r45.Visible = false; Lbl_r45.Text = "25"; 
            Lbl_r46.Visible = false; Lbl_r46.Text = "30"; 
            Lbl_r47.Visible = false; Lbl_r47.Text = "35"; 
            Lbl_r48.Visible = false; Lbl_r48.Text = "40"; 
            Lbl_r49.Visible = false; Lbl_r49.Text = "45"; 
            Lbl_r50.Visible = false; Lbl_r50.Text = "50"; 
            //TABLA 6 - 1
            Lbl_r51.Visible = false; Lbl_r51.Text = "6"; 
            Lbl_r52.Visible = false; Lbl_r52.Text = "12"; 
            Lbl_r53.Visible = false; Lbl_r53.Text = "18"; 
            Lbl_r54.Visible = false; Lbl_r54.Text = "24"; 
            Lbl_r55.Visible = false; Lbl_r55.Text = "30"; 
            Lbl_r56.Visible = false; Lbl_r56.Text = "36"; 
            Lbl_r57.Visible = false; Lbl_r57.Text = "42"; 
            Lbl_r58.Visible = false; Lbl_r58.Text = "48"; 
            Lbl_r59.Visible = false; Lbl_r59.Text = "54"; 
            Lbl_r60.Visible = false; Lbl_r60.Text = "60"; 
            //TABLA 7 - 10
            Lbl_r61.Visible = false; Lbl_r61.Text = "7"; 
            Lbl_r62.Visible = false; Lbl_r62.Text = "14";
            Lbl_r63.Visible = false; Lbl_r63.Text = "21";
            Lbl_r64.Visible = false; Lbl_r64.Text = "28";
            Lbl_r65.Visible = false; Lbl_r65.Text = "35";
            Lbl_r66.Visible = false; Lbl_r66.Text = "42";
            Lbl_r67.Visible = false; Lbl_r67.Text = "49";
            Lbl_r68.Visible = false; Lbl_r68.Text = "56";
            Lbl_r69.Visible = false; Lbl_r69.Text = "63";
            Lbl_r70.Visible = false; Lbl_r70.Text = "70";
            //TABLA 8 - 10
            Lbl_r71.Visible = false; Lbl_r71.Text = "8";
            Lbl_r72.Visible = false; Lbl_r72.Text = "16";
            Lbl_r73.Visible = false; Lbl_r73.Text = "24";
            Lbl_r74.Visible = false; Lbl_r74.Text = "32";
            Lbl_r75.Visible = false; Lbl_r75.Text = "40";
            Lbl_r76.Visible = false; Lbl_r76.Text = "48";
            Lbl_r77.Visible = false; Lbl_r77.Text = "56";
            Lbl_r78.Visible = false; Lbl_r78.Text = "64";
            Lbl_r79.Visible = false; Lbl_r79.Text = "72";
            Lbl_r80.Visible = false; Lbl_r80.Text = "80";
            //TABLA 9 - 10
            Lbl_r81.Visible = false; Lbl_r81.Text = "9";
            Lbl_r82.Visible = false; Lbl_r82.Text = "18";
            Lbl_r83.Visible = false; Lbl_r83.Text = "27";
            Lbl_r84.Visible = false; Lbl_r84.Text = "36";
            Lbl_r85.Visible = false; Lbl_r85.Text = "46";
            Lbl_r86.Visible = false; Lbl_r86.Text = "55";
            Lbl_r87.Visible = false; Lbl_r87.Text = "63";
            Lbl_r88.Visible = false; Lbl_r88.Text = "72";
            Lbl_r89.Visible = false; Lbl_r89.Text = "81";
            Lbl_r90.Visible = false; Lbl_r90.Text = "90";
            //TABLA 10 - 10
            Lbl_r91.Visible = false;
            Lbl_r92.Visible = false; Lbl_r92.Text = "20";
            Lbl_r93.Visible = false; Lbl_r93.Text = "30";
            Lbl_r94.Visible = false; Lbl_r94.Text = "40";
            Lbl_r95.Visible = false; Lbl_r95.Text = "50";
            Lbl_r96.Visible = false; Lbl_r96.Text = "60";
            Lbl_r97.Visible = false; Lbl_r97.Text = "70";
            Lbl_r98.Visible = false; Lbl_r98.Text = "80";
            Lbl_r99.Visible = false; Lbl_r99.Text = "90";
            Lbl_r100.Visible = false; Lbl_r100.Text = "100";
            Txt1.Clear();
            Txt3.Clear();
            Txt5.Clear();
        }

        

        

    }
}
