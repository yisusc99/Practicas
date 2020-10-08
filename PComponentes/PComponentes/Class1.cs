using System;
using System.Collections.Generic;
using System.Text;

namespace PControlesForm
{
    public class Persona
    {
        private string nombre1;
        private string apellidos1;
        private string telefono1;
        private string direccion1;
        private string ciudad1;
        private string estado1;

        public String nombre { get => nombre1; set => nombre1 = value; }
        public String apellidos { get => apellidos1; set => apellidos1 = value; }
        public String telefono { get => telefono1; set => telefono1 = value; }
        public String direccion { get => direccion1; set => direccion1 = value; }
        public String ciudad { get => ciudad1; set => ciudad1 = value; }
        public String estado { get => estado1; set => estado1 = value; }
        public String nom() { return nombre1; }
        public String ape() { return apellidos1; }
        public String tel() { return telefono1; }
        public String dire() { return direccion1; }
        public String ciu() { return ciudad1; }
        public String est() { return estado1; }
    }
    public class Componentes
    {
        private String procesador1;
        private int ram1;
        private String[] adl1;
        private int caphdd21;
        private int caphdd11;
        private String hdd21;
        private String hdd11;
        private String so1;

        public String procesador { get => procesador1; set => procesador1 = value; }
        public int ram { get => ram1; set => ram1 = value; }
        public String so { get => so1; set => so1 = value; }
        public String hdd1 { get => hdd11; set => hdd11 = value; }
        public String hdd2 { get => hdd21; set => hdd21 = value; }
        public int caphdd1 { get => caphdd11; set => caphdd11 = value; }
        public int caphdd2 { get => caphdd21; set => caphdd21 = value; }
        public String[] adl { get => adl1; set => adl1 = value; }

        public String proce() { return procesador1;}
        public int ra() { return ram1;}
        public String s1() { return so1;}
        public String hd1() { return hdd11;}
        public String hd2() { return hdd21;}
        public int caphd1() { return caphdd11;}
        public int caphd2() { return caphdd21;}
        public String[] adls() { return adl1;}
    }
}
