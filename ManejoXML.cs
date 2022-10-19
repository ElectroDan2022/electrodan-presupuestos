//namespace App
//{

//    using System;
//    using System.Collections;
//    using System.IO;
//    using System.Xml;
//    using Gtk;


//    public class XmlApp
//    {
//        private string nombre, apellido_p, apellido_m, edad;

//        private Glade.XML gxml;

//        #region Glade
//        [Glade.Widget("winmain")]
//        Gtk.Window winmain;

//        [Glade.WidgetAttribute]
//        private Gtk.Entry txtnombre;
//        [Glade.WidgetAttribute]
//        private Gtk.Entry txtapellido_p;
//        [Glade.WidgetAttribute]
//        private Gtk.Entry txtapellido_m;
//        [Glade.WidgetAttribute]
//        private Gtk.Entry txtedad;
//        [Glade.WidgetAttribute]
//        private Gtk.Entry txtnombre_xml;
//        [Glade.WidgetAttribute]
//        private Gtk.Label texto;
//        [Glade.WidgetAttribute]
//        private Statusbar statusbar;
//        #endregion

//        public XmlApp
//            (string[] args)
//        {
//            //Inicializar la Interfaz Grafica
//            Application.Init();

//            gxml = new Glade.XML(null, "gui.glade", "winmain", null);
//            gxml.Autoconnect(this);

//            statusbar.Push(0, "Demo utilizacion de Archivos XMl con C# - Christian M. C.E.");
//            Application.Run();
//        }

//        public void gtk_widget_destroy(object sender, EventArgs a)
//        {
//            Gtk.Application.Quit();
//        }

//        public void on_btnleer_clicked(object o, EventArgs args)
//        {
//            if (txtnombre_xml.Text.Length == 0)
//            {
//                Console.WriteLine("Debes de indicar un nombre de Archivo");
//                return;
//            }
//            Leer(txtnombre_xml.Text);

//            texto.Markup = "Hola  " + nombre + " " + apellido_p + " " + apellido_m + ", \r\r\rTu edad es: " + edad + "";
//            statusbar.Push(0, "Leyendo Archivo XML");

//        }


//        public void on_btnescribir_clicked(object o, EventArgs args)
//        {

//            if (txtnombre_xml.Text.Length == 0)
//            {
//                Console.WriteLine("Debes de indicar un nombre de Archivo");
//                return;
//            }

//            Escribir(txtnombre_xml.Text);

//            txtnombre.Text = "";
//            txtapellido_p.Text = "";
//            txtapellido_m.Text = "";
//            txtedad.Text = "";
//            statusbar.Push(0, "Escribiendo en el Archivo XML");
//        }


//        public void on_btnacercade_clicked(object o, EventArgs args)
//        {
//            string[] authors = new string[] { "Christian Mauricio C.E. xpchristian@hotmail.com>" };
//            string[] doc = new string[] { };
//            About about = new About("XmlApp", "Beta 1", "Copyright (C) 2005 Christian Mauricio <xpchristian@hotmail.com>", "Ejemplo sobre el uso de archivos XML con C#", authors, doc, "", icono);
//            about.Show();
//        }


//        //Esta Funcion permite Leer un Archivo XML
//        public void Leer(string nombre_xml)
//        {
//            //Declaramor un lector para el XML indicando el nombre de este
//            StreamReader reader = new StreamReader(nombre_xml, System.Text.Encoding.UTF8);

//            //Indicamos cual es el nombre de lector XML a usar en este caso es reader
//            XmlTextReader xml = new XmlTextReader(reader);
//            xml.Namespaces = false;

//            //Hacemos un ciclo para leer cada uno de los nodos del XML
//            while (xml.Read())
//            {
//                //Vamos a leer cada uno de los elementos que contiene el archivo XML
//                //En este ejemplo los elementos son nombre,apellido_p,apellido_,
//                // y edad incluidos dentro del Nodo principal llamado Persona

//                switch (xml.NodeType)
//                {
//                    case XmlNodeType.Element:
//                        switch (xml.Name)
//                        {
//                            case "persona":
//                                break;
//                            case "nombre":
//                                //Leemos el valor elemento Nombre
//                                nombre = xml.ReadString();
//                                break;
//                            case "apellido_p":
//                                apellido_p = xml.ReadString();
//                                break;
//                            case "apellido_m":
//                                apellido_m = xml.ReadString();
//                                break;
//                            case "edad":
//                                edad = xml.ReadString();
//                                break;
//                        }
//                        break;
//                }
//            }

//            //Cerramos el lector de XML
//            xml.Close();

//        }


//        //Esta funcion permite escribir en un archivo XML
//        public void Escribir(string nombre_xml)
//        {

//            //Declaramos un escritor de texto XML, indicando cual es el nombre del archivo XML
//            XmlTextWriter xml = new XmlTextWriter(nombre_xml, System.Text.Encoding.UTF8);

//            xml.Formatting = Formatting.Indented;

//            //Inicializamos el Documento XML
//            xml.WriteStartDocument();

//            //Escribimos el Elemento Principal (Persona)
//            xml.WriteStartElement(null, "persona", null);


//            //Escribimos el elemento <nombre>
//            xml.WriteStartElement(null, "nombre", null);

//            //Escribimos el dato de ese elemento en formato tipo cadena (String)
//            xml.WriteString(txtnombre.Text);

//            //Cerramos el elemento </nombre>
//            xml.WriteEndElement();

//            xml.WriteStartElement(null, "apellido_p", null);
//            xml.WriteString(txtapellido_p.Text);
//            xml.WriteEndElement();

//            xml.WriteStartElement(null, "apellido_m", null);
//            xml.WriteString(txtapellido_m.Text);
//            xml.WriteEndElement();

//            xml.WriteStartElement(null, "edad", null);
//            xml.WriteString(txtedad.Text);
//            xml.WriteEndElement();



//            xml.WriteEndElement(); //Cerramos el Elemento Principal </persona>
//            xml.WriteEndDocument(); //Cerramos el Documento XML
//            xml.Close(); //Cerramos el Escritor XML
//        }
//    }
//}
