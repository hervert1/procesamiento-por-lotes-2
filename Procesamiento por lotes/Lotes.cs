using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Procesamiento_por_lotes
{
    public partial class Lotes : Form
    {
        int lotes = 0, procesos = 0, lot_act = 1;
        int act = 0;
        double tiempo_usado = 0, tiempo_restante = 0;
        string lastchar = "C";                           // Variable para detectar teclas

        List<process> lista = new List<process>();

        public Lotes(){
            InitializeComponent();
            start.Enabled = false;
            string sr = "Proceso.txt";
            if (!File.Exists(sr)){
                execute_btn.Enabled = false;
            }
        }

        private void add_process_Click(object sender, EventArgs e){
            try{
                int id = 1;
                File.Delete("Proceso.txt");
                int cant = int.Parse(cantidad.Text);
                string result = "";

                //Generación Random
                var value = 0;
                var value2 = 1;
                var seed = Environment.TickCount;
                var random = new Random(seed);

                for(int i = 0; i < cant; i++) { 
                    //Recuperar contenido previo
                    string sr = "Proceso.txt";
                    string previous = "";
                    if (File.Exists(sr)){
                        previous = File.ReadAllText(sr);
                    }

                    //Crear el archivo y el Writer
                    StreamWriter sw = new StreamWriter("Proceso.txt");
                    sw.Write(previous);

                    //Iniciar nueva escritura
                    sw.WriteLine("#JOB");                       // Escribir inicio de proceso

                    result = Convert.ToString(id);              // Pasar a string el valor
                    sw.WriteLine(result);                       // Escribir el ID

                    value = random.Next(7, 16);
                    result = Convert.ToString(value);           // Pasar a string el valor
                    sw.WriteLine(result);                       // Escribir Tiempo Máximo Estimado

                    value = random.Next(0, 4);                  // Generar la operación aritmetica
                    string operador = "";
                    if (value == 0){ operador = "+"; }          // Comparar el signo correspondiente
                    else if (value == 1) { operador = "-"; }    //
                    else if (value == 2) { operador = "*"; }    //
                    else if (value == 3) { operador = "/"; }    //
                    else if (value == 4) { operador = "%"; }    //

                    value = random.Next(0, 10000);              // Generar operador 1
                    value2 = random.Next(1, 10000);             // Generar operador 2
                    sw.WriteLine(value + operador + value2);    // Escribir la operación

                    int num1, num2, res = 0;                    // Variables para hacer la operación
                    num1 = value;                               // Operador 1 a variable
                    num2 = value2;                              // Operador 2 a variable

                    if (operador == "+"){                       // Comparaciones de operaciones, suma
                        res = num1 + num2;
                    }
                    else if (operador == "-"){                  // Comparaciones de operaciones, resta
                        res = num1 - num2;
                    }
                    else if (operador == "*"){                  // Comparaciones de operaciones, multiplicación
                        res = num1 * num2;
                    }
                    else if (operador == "/"){                  // Comparaciones de operaciones, división
                        res = num1 / num2;
                    }
                    else if (operador == "%"){                  // Comparaciones de operaciones, residuo
                        res = num1 % num2;
                    }

                    result = Convert.ToString(res);             // Escribir resultado de operación
                    sw.WriteLine(result);                       //
                    sw.WriteLine("#END");                       // Final del proceso

                    sw.Close();                                 //Cerrar el archivo
                    id++;
                }
            }
            finally { }
        }

        private void reset_Click(object sender, EventArgs e) {
            Lotes lot = new Lotes();
            lot.Show();
            this.Hide();
        }

        private void cantidad_TextChanged(object sender, EventArgs e){
            if (cantidad.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(cantidad.Text, "^[0]+$")){
                add_process.Enabled = false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(cantidad.Text, "^[0-9]+$")){
                add_process.Enabled = true;
            }
            else{
                cantidad.Clear();
                MessageBox.Show("Por favor ingrese solo números en este campo, debe ser mayor que 0");
            }
        }

        private void Lotes_KeyDown(object sender, KeyEventArgs e){
            
            // Detectar teclas presionadas
            if(e.KeyValue.ToString() == "80"){
                state.Text = "PAUSE";
                clock.Stop();
                lastchar = "P";
            }
            else if (e.KeyValue.ToString() == "67"){
                state.Text = "RUNNING";
                clock.Start();
                lastchar = "C";
            }
            else if (e.KeyValue.ToString() == "69" && lastchar != "P"){
                state.Text = "Process " + lista[act].getNum() + " INTERRUPTED";
                lastchar = "E";
                process aux;
                tiempo_usado = tiempo_usado + lista[act].getTT();

                if (act % 4 == 0){
                    if (lista[act + 1] != null && lista[act + 2] != null && lista[act + 3] != null) {
                        aux = lista[act];
                        lista[act] = lista[act + 1];
                        lista[act + 1] = lista[act + 2];
                        lista[act + 2] = lista[act + 3];
                        lista[act + 3] = aux;
                    }
                    else if(lista[act+1] != null && lista[act + 2] != null)
                    {
                        aux = lista[act];
                        lista[act] = lista[act + 1];
                        lista[act + 1] = lista[act + 2];
                        lista[act + 2] = aux;
                    }
                    else if(lista[act + 1] != null)
                    {
                        aux = lista[act];
                        lista[act] = lista[act + 1];
                        lista[act + 1] = aux;
                    }

                    dataGridView1.Rows.RemoveAt(0);
                    if(lista[act+1] != null){
                        dataGridView1.Rows.RemoveAt(0);
                    }
                    if(lista[act+2] != null){
                        dataGridView1.Rows.RemoveAt(0);
                    }
                    if (lista[act + 3] != null)
                    {
                        dataGridView1.Rows.RemoveAt(0);
                    }

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = lista[act].getNum();
                    dataGridView1.Rows[0].Cells[1].Value = lista[act].getTME();
                    dataGridView1.Rows[0].Cells[2].Value = (lista[act].getTME() - lista[act].getTT());
                    
                    if(lista[act+1] != null){
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[1].Cells[0].Value = lista[act + 1].getNum();
                        dataGridView1.Rows[1].Cells[1].Value = lista[act + 1].getTME();
                        dataGridView1.Rows[1].Cells[2].Value = (lista[act + 1].getTME() - lista[act + 1].getTT());
                    }

                    if(lista[act+2] != null){
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[2].Cells[0].Value = lista[act + 2].getNum();
                        dataGridView1.Rows[2].Cells[1].Value = lista[act + 2].getTME();
                        dataGridView1.Rows[2].Cells[2].Value = (lista[act + 2].getTME() - lista[act + 2].getTT());
                    }

                    if(lista[act+3] != null){
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[3].Cells[0].Value = lista[act + 3].getNum();
                        dataGridView1.Rows[3].Cells[1].Value = lista[act + 3].getTME();
                        dataGridView1.Rows[3].Cells[2].Value = (lista[act + 3].getTME() - lista[act + 3].getTT());
                    }
                }

                else if (act % 4 == 1)
                {
                    if (lista[act + 1] != null && lista[act + 2] != null)
                    {
                        aux = lista[act];
                        lista[act] = lista[act + 1];
                        lista[act + 1] = lista[act + 2];
                        lista[act + 2] = aux;
                    }
                    else if (lista[act + 1] != null)
                    {
                        aux = lista[act];
                        lista[act] = lista[act + 1];
                        lista[act + 1] = aux;
                    }

                    dataGridView1.Rows.RemoveAt(0);
                    if (lista[act + 1] != null){
                        dataGridView1.Rows.RemoveAt(0);
                    }
                    if (lista[act + 2] != null)
                    {
                        dataGridView1.Rows.RemoveAt(0);
                    }

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = lista[act].getNum();
                    dataGridView1.Rows[0].Cells[1].Value = lista[act].getTME();
                    dataGridView1.Rows[0].Cells[2].Value = (lista[act].getTME() - lista[act].getTT());

                    if (lista[act + 1] != null){
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[1].Cells[0].Value = lista[act + 1].getNum();
                        dataGridView1.Rows[1].Cells[1].Value = lista[act + 1].getTME();
                        dataGridView1.Rows[1].Cells[2].Value = (lista[act + 1].getTME() - lista[act + 1].getTT());
                    }

                    if (lista[act + 2] != null)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[2].Cells[0].Value = lista[act + 2].getNum();
                        dataGridView1.Rows[2].Cells[1].Value = lista[act + 2].getTME();
                        dataGridView1.Rows[2].Cells[2].Value = (lista[act + 2].getTME() - lista[act + 2].getTT());
                    }
                }

                else if (act % 4 == 2)
                {
                    if (lista[act + 1] != null)
                    {
                        aux = lista[act];
                        lista[act] = lista[act + 1];
                        lista[act + 1] = aux;
                    }

                    dataGridView1.Rows.RemoveAt(0);
                    if (lista[act + 1] != null)
                    {
                        dataGridView1.Rows.RemoveAt(0);
                    }

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = lista[act].getNum();
                    dataGridView1.Rows[0].Cells[1].Value = lista[act].getTME();
                    dataGridView1.Rows[0].Cells[2].Value = (lista[act].getTME() - lista[act].getTT());

                    if (lista[act + 1] != null)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[1].Cells[0].Value = lista[act + 1].getNum();
                        dataGridView1.Rows[1].Cells[1].Value = lista[act + 1].getTME();
                        dataGridView1.Rows[1].Cells[2].Value = (lista[act + 1].getTME() - lista[act + 1].getTT());
                    }

                }
                else if (act % 4 == 3)
                {
                    dataGridView1.Rows.RemoveAt(0);

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = lista[act].getNum();
                    dataGridView1.Rows[0].Cells[1].Value = lista[act].getTME();
                    dataGridView1.Rows[0].Cells[2].Value = (lista[act].getTME() - lista[act].getTT());
                }
            }
            else if (e.KeyValue.ToString() == "87" && lastchar != "P")
            {
                state.Text = "ERROR in process " + lista[act].getNum();
                lastchar = "W";

                lista[act].setTT(lista[act].getTME());
                tiempo_usado = tiempo_usado + lista[act].getTT();
                lista[act].setResultado("Error");
            }
        }

        private void Lotes_Load(object sender, EventArgs e)
        {

        }

        private void clock_Tick(object sender, EventArgs e){

            // Variables de tiempo
            Double tiempo = Convert.ToDouble(time_label.Text);      // Obtener el tiempo anterior desde el label
            tiempo = tiempo + 1;                                    // Sumar 1 al tiempo
            time_label.Text = tiempo.ToString();                    // Reimprimir el tiempo

            // Actualizar la ventana de proceso actual
            if(act <= lista.Count()){
                if (lista[act] != null){
                    if(lista[act].getTT() != lista[act].getTME()){
                        lista[act].setTT(lista[act].getTT() + 1);
                    }

                    id_label.Text = "ID:" + lista[act].getNum().ToString();
                    op_label.Text = "Operación: " + lista[act].getOperacion();
                    tme_label.Text = "Tiempo Máximo Estimado: " + lista[act].getTME().ToString();
                    tt_label.Text = "Tiempo Trasncurrido: " + lista[act].getTT();
                    tiempo_restante = (lista[act].getTME() - lista[act].getTT());
                    tr_label.Text = "Tiempo restante: " + tiempo_restante;
                }
            }
            

            if (tiempo_restante == 0){

                // Agregar nueva fila a los terminados
                if(act <= lista.Count()){
                    if (lista[act] != null){
                        tiempo_usado = tiempo_usado + lista[act].getTME();
                        dataGridView1.Rows.RemoveAt(0);                                         // Eliminar el proceso superior
                        dataGridView2.Rows.Add();                                               // Agregar fila a terminados
                        dataGridView2.Rows[act].Cells[0].Value = lista[act].getNum();           // ID
                        dataGridView2.Rows[act].Cells[1].Value = lista[act].getOperacion();     // Operación
                        dataGridView2.Rows[act].Cells[2].Value = lista[act].getResultado();     // Resultado
                        dataGridView2.Rows[act].Cells[3].Value = (act / 4) + 1;                 // Número de lote
                    }
                }
                

                if ((act/4+1) != ((act+1)/4+1)){                                            // Si el lote cambio

                    // Mostrar el total de lotes
                    dataGridView1.Rows.Clear();
                    lotes--;
                    lot_act++;
                    wait_lot_label.Text = "Número de lotes pendientes: " + (lotes-1);
                    lot_label.Text = "Lote actual: " + lot_act;

                    // Detectar desfase de indices
                    if (lista.Count() != (act+1)) {

                        // Cargar siguiente lote
                        if (lista[act + 1] != null) {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[0].Cells[0].Value = lista[act + 1].getNum();
                            dataGridView1.Rows[0].Cells[1].Value = lista[act + 1].getTME();
                            dataGridView1.Rows[0].Cells[2].Value = (lista[act + 1].getTME() - lista[act + 1].getTT());
                            if (lista[act + 2] != null)  {
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[1].Cells[0].Value = lista[act + 2].getNum();
                                dataGridView1.Rows[1].Cells[1].Value = lista[act + 2].getTME();
                                dataGridView1.Rows[1].Cells[2].Value = (lista[act + 2].getTME() - lista[act + 2].getTT());
                                if (lista[act + 3] != null) {
                                    dataGridView1.Rows.Add();
                                    dataGridView1.Rows[2].Cells[0].Value = lista[act + 3].getNum();
                                    dataGridView1.Rows[2].Cells[1].Value = lista[act + 3].getTME();
                                    dataGridView1.Rows[2].Cells[2].Value = (lista[act+3].getTME() - lista[act + 3].getTT());
                                    if (lista[act + 4] != null) {
                                        dataGridView1.Rows.Add();
                                        dataGridView1.Rows[3].Cells[0].Value = lista[act + 4].getNum();
                                        dataGridView1.Rows[3].Cells[1].Value = lista[act + 4].getTME();
                                        dataGridView1.Rows[3].Cells[2].Value = (lista[act + 4].getTME() - lista[act + 4].getTT());
                                     }
                                }
                            }
                        }
                    }
                }
                act++;

                if (act >= lista.Count() || lista[act] == null){
                    clock.Stop();
                    start.Enabled = false;
                    MessageBox.Show("Procesos terminados con exito!!");
                }
            }
        }

        private void start_Click(object sender, EventArgs e){
            clock.Start();
            start.Enabled = false;
            execute_btn.Enabled = false;
        }

        private void execute_btn_Click(object sender, EventArgs e){
            String line;
            lista.Clear();
            try{
                StreamReader sr = new StreamReader("Proceso.txt");
                int num1;
                line = sr.ReadLine();

                while (line != null){

                    process pro = new process();
                    if (line == "#JOB"){
                        procesos++;
                    }
                    // Avanzar linea, convertir a int y guardar el numero de programa
                    line = sr.ReadLine();
                    num1 = int.Parse(line);
                    pro.setNum(num1);

                    // Avanzar linea, convertir a int y guardar el TME
                    line = sr.ReadLine();
                    num1 = int.Parse(line);
                    pro.setTME(num1);

                    // Asignar la operación
                    line = sr.ReadLine();
                    pro.setOperacion(line);

                    // Avanzar linea, convertir a int y guardar el resultado
                    line = sr.ReadLine();
                    pro.setResultado(line);

                    // Avanzar la linea de #END
                    line = sr.ReadLine();

                    lista.Add(pro);
                    // Avanzar una linea adicional para encontrar otro #JOB
                    line = sr.ReadLine();
                }
                sr.Close();
                while ((lista.Count() % 4) != 0){
                    lista.Add(null);
                }
                // Obtener el total de lotes a procesar
                //lotes = (procesos / 4) + (procesos%4);
                lotes = (lista.Count()/4) + (lista.Count()%4);
            }
            finally{
                // Mostrar el total de lotes
                dataGridView1.Rows.Clear();
                wait_lot_label.Text = "Número de lotes pendientes: " + (lotes-1);
                lot_label.Text = "Lote actual: " + lot_act;

                if(lista[0] != null){
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = lista[0].getNum();
                    dataGridView1.Rows[0].Cells[1].Value = lista[0].getTME();
                    dataGridView1.Rows[0].Cells[2].Value = (lista[0].getTME() - lista[0].getTT());
                    if (lista[1] != null){
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[1].Cells[0].Value = lista[1].getNum();
                        dataGridView1.Rows[1].Cells[1].Value = lista[1].getTME();
                        dataGridView1.Rows[1].Cells[2].Value = (lista[1].getTME() - lista[1].getTT());
                        if (lista[2] != null){
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[2].Cells[0].Value = lista[2].getNum();
                            dataGridView1.Rows[2].Cells[1].Value = lista[2].getTME();
                            dataGridView1.Rows[2].Cells[2].Value = (lista[2].getTME() - lista[2].getTT());
                            if (lista[3] != null){
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[3].Cells[0].Value = lista[3].getNum();
                                dataGridView1.Rows[3].Cells[1].Value = lista[3].getTME();
                                dataGridView1.Rows[3].Cells[2].Value = (lista[3].getTME() - lista[3].getTT());
                            }
                        }
                    }
                }
                start.Enabled = true;
            }
        }

    }
}
