using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesamiento_por_lotes
{
    /*////////////////////////////////////////////////////////////
    //   Clase Process, representa una instancia de proceso     //
    //   contiene los valores de tiempos respectivos al BCP     //
    ////////////////////////////////////////////////////////////*/
    
    class process{
        private String operacion = "";  // Cadena de operación
        private int no_programa = 0;    // ID
        private string resultado = "0";      // Resultado de la operación

        private int tme = 0;            // Tiempo máximo estimado
        private double tl = 0;          // Tiempo de llegada
        private double tf = 0;          // Tiempo de finalización
        private double tret = 0;        // Tiempo de retorno
        private double ts = 0;          // Tiempo de servicio
        private double tres = 0;        // Tiempo de respuesta
        private double te = 0;          // Tiempo de espera
        private double tt = 0;          // Tiempo transcurrido

        // Getters & Setters generales

        public string getOperacion(){
            return this.operacion;
        }

        public int getNum(){
            return this.no_programa;
        }

        public string getResultado(){
            return this.resultado;
        }

        public void setOperacion(string aux){
            this.operacion = aux;
        }

        public void setNum(int aux){
            this.no_programa = aux;
        }

        public void setResultado(string aux){
            this.resultado = aux;
        }

        // Getters & Setters de los tiempos

        public void setTME(int aux){
            this.tme = aux;
        }

        public int getTME(){
            return this.tme;
        }

        public void setTL(double aux){
            this.tl = aux;
        }

        public double getTL(){
            return this.tl;
        }

        public void setTF(double aux){
            this.tf = aux;
        }

        public double getTF(){
            return this.tf;
        }

        public void setTRET(double aux){
            this.tret = aux;
        }

        public double getTRET(){
            return this.tret;
        }

        public void setTS(double aux){
            this.ts = aux;
        }

        public double getTS(){
            return this.ts;
        }

        public void setTRES(double aux){
            this.tres = aux;
        }

        public double getTRES(){
            return this.tres;
        }

        public void setTE(double aux){
            this.te = aux;
        }

        public double getTE(){
            return this.te;
        }

        public void setTT(double aux){
            this.tt = aux;
        }

        public double getTT(){
            return this.tt;
        }
    }
}
