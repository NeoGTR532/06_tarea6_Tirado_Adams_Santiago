using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Practica
{
    class Frutas:Program
    { 
        public void menuFrutas()
        {
            Debug.Log("Frutas");
            Debug.Log("----------------");
            Debug.Log("1.Manzana");
            Debug.Log("2.Pera");
            Debug.Log("3.Plátano");
            Debug.Log("4.Naranja");
            Debug.Log("5.Fresa");
            Debug.Log("6.Sandía");
            Debug.Log("7.Tomate");
            Debug.Log("[-presionar dependiendo del número que tenga la fruta marcada para ir a ella]-");
            Debug.Log("[-presionar 0 para volver a la tienda]-");

            string str = "1";
            switch (str)
            {
                case "1":                    
                    Manzana();
                    break;
                case "2":                   
                    Pera();
                    break;
                case "3":                   
                    Plátano();
                    break;
                case "4":
                    Naranja();
                    break;
                case "5":
                    Fresa();
                    break;
                case "6":
                    Sandía();
                    break;
                case "7":
                    Tomate();
                    break;
            }
        }

        public void Manzana()
        {
            Debug.Log("Manzana");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.0.5/u");
            Debug.Log("Calidad : buena");
            Debug.Log("[-presionar 1 para recoger manzanas-]");
            Debug.Log("[-presionar 0 para volver a la tienda-]");

            string stri1 = "1";
            switch (stri1)
            {
                case "1":
                    Debug.Log("¿Cuántas deseas recoger?");
                    leercantidad();
                    break;
            }
            void leercantidad()
            {
                string str = "1";
                cantidad = cantidad + int.Parse(str);
                Debug.Log("Has recogido " + cantidad + " manzanas");
            }
        }
        public void Pera()
        {
            Debug.Log("Pera");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.0.7/u");
            Debug.Log("Calidad : buena");
            Debug.Log("[-presionar 1 para recoger peras]-");
            Debug.Log("[-presionar 0 para volver a la tienda]-");

            string stri1 = "1";
            switch (stri1)
            {
                case "1":
                    Debug.Log("¿Cuántas deseas recoger?");
                    leercantidad();
                    break;
            }
            void leercantidad()
            {
                string str = "1";
                cantidad = cantidad + int.Parse(str);
                Debug.Log("Has recogido " + cantidad + " peras");
            }
        }
        public void Plátano()
        {
            Debug.Log("Plátano");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.0.3/u");
            Debug.Log("Calidad : buena");
            Debug.Log("[-presionar 1 para recoger plátanos]-");
            Debug.Log("[-presionar 0 para volver a la tienda]-");

            string stri1 = "1";
            switch (stri1)
            {
                case "1":
                    Debug.Log("¿Cuántas deseas recoger?");
                    leercantidad();
                    break;
            }
            void leercantidad()
            {
                string str = "1";
                cantidad = cantidad + int.Parse(str);
                Debug.Log("Has recogido " + cantidad + " plátanos");
            }
        }
        public void Naranja()
        {
            Debug.Log("Naranja");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.0.4/u");
            Debug.Log("Calidad : buena");
            Debug.Log("[-presionar 1 para recoger naranjas]-");
            Debug.Log("[-presionar 0 para volver a la tienda]-");

            string stri1 = "1";
            switch (stri1)
            {
                case "1":
                    Debug.Log("¿Cuántas deseas recoger?");
                    leercantidad();
                    break;
            }
            void leercantidad()
            {
                string str = "1";
                cantidad = cantidad + int.Parse(str);
                Debug.Log("Has recogido " + cantidad + " naranjas");
            }
        }
        public void Fresa()
        {
            Debug.Log("Fresa");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.0.8/u");
            Debug.Log("Calidad : buena");
            Debug.Log("[-presionar 1 para recoger fresas]-");
            Debug.Log("[-presionar 0 para volver a la tienda]-");

            string stri1 = "1";
            switch (stri1)
            {
                case "1":
                    Debug.Log("¿Cuántas deseas recoger?");
                    leercantidad();
                    break;
            }
            void leercantidad()
            {
                string str = "1";
                cantidad = cantidad + int.Parse(str);
                Debug.Log("Has recogido " + cantidad + " fresas");
            }
        }
        public void Sandía()
        {
            Debug.Log("Sandía");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.3.8/u");
            Debug.Log("Calidad : buena");
            Debug.Log("[-presionar 1 para recoger sandías]-");
            Debug.Log("[-presionar 0 para volver a la tienda]-");

            string stri1 = "1";
            switch (stri1)
            {
                case "1":
                    Debug.Log("¿Cuántas deseas recoger?");
                    leercantidad();
                    break;
            }
            void leercantidad()
            {
                string str = "1";
                cantidad = cantidad + int.Parse(str);
                Debug.Log("Has recogido " + cantidad + " sandías");
            }
        }
        public void Tomate()
        {
            Debug.Log("Tomate");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.0.5/u");
            Debug.Log("Calidad : buena");
            Debug.Log("[-presionar 1 para recoger tomates]-");
            Debug.Log("[-presionar 0 para volver a la tienda]-");

            string stri1 = "1";
            switch (stri1)
            {
                case "1":
                    Debug.Log("¿Cuántas deseas recoger?");
                    leercantidad();
                    break;
            }
            void leercantidad()
            {
                string str = "1";
                cantidad = cantidad + int.Parse(str);
                Debug.Log("Has recogido " + cantidad + " tomates");
            }
        }
    }
}
