using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Practica
{
    class Verduras:Program
    {
        public void menuVerduras()
        {
            Debug.Log("Verduras");
            Debug.Log("----------------");
            Debug.Log("1.Lechuga");
            Debug.Log("2.Brócoli");
            Debug.Log("3.Apio");
            Debug.Log("4.Zanahoria");
            Debug.Log("5.Papa");
            Debug.Log("[-presionar dependiendo del número que tenga la fruta marcada para ir a ella]-");

            string str = "1";
            switch (str)
            {
                case "1":                  
                    Lechuga();
                    break;
                case "2":                   
                    Brócoli();
                    break;
                case "3":                    
                    Apio();
                    break;
                case "4":                   
                    Zanahoria();
                    break;
                case "5":                  
                    Papa();
                    break;
            }
        }
        public void Lechuga()
        {
            Debug.Log("Lechuga");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.1.2/u");
            Debug.Log("Calidad : buena");
            Debug.Log("[-presionar 1 para recoger Lechuga-]");
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
                Debug.Log("Has recogido " + cantidad + " lechugas");
            }
        }
        public void Brócoli()
        {
            Debug.Log("brócoli");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.0.9/u");
            Debug.Log("Calidad : buena");

            Debug.Log("[-presionar 1 para recoger brócolis-]");
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
                Debug.Log("Has recogido " + cantidad + " brócolis");
            }
        }
        public void Apio()
        {
            Debug.Log("Apio");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.0.4/u");
            Debug.Log("Calidad : buena");
            Debug.Log("[-presionar 1 para recoger apios-]");
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
                Debug.Log("Has recogido " + cantidad + " apios");
            }
        }
        public void Zanahoria()
        {
            Debug.Log("Zanahoria");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.0.7/u");
            Debug.Log("Calidad : buena");
            Debug.Log("[-presionar 1 para recoger zanahorias-]");
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
                Debug.Log("Has recogido " + cantidad + " zanahorias");
            }
        }
        public void Papa()
        {
            Debug.Log("Papa");
            Debug.Log("");
            Debug.Log("tienes " + cantidad);
            Debug.Log("Precio : S/.0.3/u");
            Debug.Log("Calidad : buena");
            Debug.Log("[-presionar 1 para recoger papas-]");
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
                Debug.Log("Has recogido " + cantidad + " papas");
            }
        }
    }
}
