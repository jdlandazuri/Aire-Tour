using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aire_Tour
{
    internal class Destinos
    {
        public int Id { get; set; } // Identificación de pasajero
        public string Nombre { get; set; } // Nombre
        public string Apellido { get; set; } // Apellidos
        public string CiudadOrigen { get; set; }

        public string Destino { get; set; } // Ciudad de destino
        public char Clase { get; set; } // Clase en la que va a viajar

        public char Estrato { get; set; } // Descuento por estrato

        public string Dia { get; set; } // Descuento por día de la semana en la que viaja

        public string Genero { get; set; } // Descuento de genero femenino

        public double DesEstrato;
        public double DesDía;
        public double DesGenero;

        public double DescuentoEstrato()
        {
            double DesEstrato = 0;
            if (Estrato == '1' ||  Estrato == '2')
            {
                DesEstrato = 0.9D;
            }
            else if (Estrato == '3' || Estrato == '4')
            {
                DesEstrato = 0.93D;
            }
            else if (Estrato == '5' || Estrato == '6')
            {
                DesEstrato = 0.95D;
            }
            return DesEstrato;
        }

        public double DescuentoDia()
        {
            double DesDia = 0;

            if (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles")
            {
                DesDia = 0.9D;

            }
            else if (Dia == "Jueves" || Dia == "Viernes")
            {
                DesDia = 0.95D;
            }
            return DesDia;
        }

        public double DescuentoGenero()
        {
            double DesGenero = 0;

            if (Genero == "Femenino")
            {
                DesGenero = 0.97D;
            }
            else
            {
                
            }
            return DesGenero;
        }

        /* Descuentos Destino Bogotá, Clase A */
        public double DestinoBogotaClaseA()
        {
            double ValorClaseA = 300000;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia();
            }
            else if ((Estrato == '1' || DescuentoEstrato() == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia();
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * DescuentoEstrato();
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia() * DescuentoGenero();
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia() * DescuentoGenero();
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoGenero();
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia();
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia();
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * DescuentoEstrato();
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia() * DescuentoGenero();
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia() * DescuentoGenero();
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoGenero();
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia();
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia();
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * DescuentoEstrato();
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia() * DescuentoGenero();
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoDia() * DescuentoGenero();
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * DescuentoEstrato() * DescuentoGenero();
            }


            return Total;
        }
        /*********************************************************************************************/

        /* Descuentos Destino Bogotá, Clase B */
        public double DestinoBogotaClaseB()
        {
            double ValorClaseB = 225000;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D * 0.9D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D * 0.95D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D;
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.9D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.95D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.97D;
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D * 0.9D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D * 0.95D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D;
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.9D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.95D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.97D;
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D * 0.9D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D * 0.95D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D;
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.9D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.95D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.97D;
            }
            return Total;
        }

        /*********************************************************************************************/

        /* Descuentos Destino Bogotá, Clase C */
        public double DestinoBogotaClaseC()
        {
            double ValorClaseC = 150000;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D * 0.9D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D * 0.95D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D;
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.9D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.95D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.97D;
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D * 0.9D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D * 0.95D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D;
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.9D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.95D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.97D;
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D * 0.9D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D * 0.95D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D;
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.9D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.95D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.97D;
            }
            return Total;
        }

        /*********************************************************************************************/

        /* Descuentos Destino Medellín, Clase A */
        public double DestinoMedellinClaseA()
        {
            double ValorClaseA = 420000;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.9D * 0.9D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.9D * 0.95D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.9D;
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.9D * 0.9D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.9D * 0.95D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.9D * 0.97D;
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.93D * 0.9D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.93D * 0.95D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.93D;
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.93D * 0.9D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.93D * 0.95D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.93D * 0.97D;
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.95D * 0.9D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.95D * 0.95D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.95D;
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.95D * 0.9D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.95D * 0.95D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.95D * 0.97D;
            }
            return Total;
        }

        public double DestinoMedellinClaseB()
        {
            double ValorClaseB = 315000;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D * 0.9D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D * 0.95D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D;
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.9D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.95D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.97D;
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D * 0.9D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D * 0.95D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D;
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.9D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.95D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.97D;
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D * 0.9D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D * 0.95D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D;
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.9D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.95D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.97D;
            }
            return Total;
        }

        public double DestinoMedellinClaseC()
        {
            double ValorClaseC = 210000;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D * 0.9D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D * 0.95D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D;
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.9D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.95D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.97D;
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D * 0.9D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D * 0.95D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D;
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.9D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.95D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.97D;
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D * 0.9D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D * 0.95D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D;
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.9D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.95D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.97D;
            }
            return Total;
        }

        public double DestinoFlorenciaClaseA()
        {
            double ValorClaseA = 270000;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.9D * 0.9D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.9D * 0.95D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.9D;
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.9D * 0.9D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.9D * 0.95D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.9D * 0.97D;
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.93D * 0.9D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.93D * 0.95D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.93D;
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.93D * 0.9D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.93D * 0.95D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.93D * 0.97D;
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.95D * 0.9D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.95D * 0.95D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.95D;
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.95D * 0.9D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.95D * 0.95D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.95D * 0.97D;
            }
            return Total;
        }

        public double DestinoFlorenciaClaseB()
        {
            double ValorClaseB = 202500;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D * 0.9D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D * 0.95D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D;
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.9D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.95D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.97D;
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D * 0.9D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D * 0.95D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D;
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.9D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.95D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.97D;
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D * 0.9D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D * 0.95D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D;
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.9D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.95D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.97D;
            }
            return Total;
        }

        public double DestinoFlorenciaClaseC()
        {
            double ValorClaseC = 135000;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D * 0.9D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D * 0.95D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D;
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.9D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.95D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.97D;
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D * 0.9D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D * 0.95D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D;
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.9D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.95D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.97D;
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D * 0.9D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D * 0.95D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D;
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.9D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.95D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.97D;
            }
            return Total;
        }

        public double DestinoPitalitoClaseA()
        {
            double ValorClaseA = 2500000;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.9D * 0.9D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.9D * 0.95D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.9D;
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.9D * 0.9D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.9D * 0.95D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.9D * 0.97D;
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.93D * 0.9D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.93D * 0.95D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.93D;
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.93D * 0.9D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.93D * 0.95D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.93D * 0.97D;
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.95D * 0.9D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.95D * 0.95D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseA * 0.95D;
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.95D * 0.9D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.95D * 0.95D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseA * 0.95D * 0.97D;
            }
            return Total;
        }

        public double DestinoPitalitoClaseB()
        {
            double ValorClaseB = 187000;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D * 0.9D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D * 0.95D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.9D;
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.9D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.95D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.9D * 0.97D;
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D * 0.9D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D * 0.95D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.93D;
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.9D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.95D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.93D * 0.97D;
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D * 0.9D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D * 0.95D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseB * 0.95D;
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.9D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.95D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseB * 0.95D * 0.97D;
            }
            return Total;
        }

        public double DestinoPitalitoClaseC()
        {
            double ValorClaseC = 187000;
            double Total = 0;

            //Estratos 1 y 2, Genero Masculino

            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D * 0.9D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D * 0.95D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.9D;
            }

            //Estratos 1 y 2, Genero Femenino
            else
            if ((Estrato == '1' || Estrato == '2') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.9D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.95D * 0.97D;
            }
            else if ((Estrato == '1' || Estrato == '2') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.9D * 0.97D;
            }

            //Estratos 3 y 4, Genero Masculino

            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D * 0.9D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D * 0.95D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.93D;
            }

            //Estratos 3 y 4, Genero Femenino
            else
            if ((Estrato == '3' || Estrato == '4') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.9D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.95D * 0.97D;
            }
            else if ((Estrato == '3' || Estrato == '4') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.93D * 0.97D;
            }


            //Estratos 5 y 6, Genero Masculino
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D * 0.9D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D * 0.95D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Masculino"))
            {
                Total = ValorClaseC * 0.95D;
            }
            //Estratos 5 y 6, Genero Femenino
            else
            if ((Estrato == '5' || Estrato == '6') && (Dia == "Lunes" || Dia == "Martes" || Dia == "Miercoles") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.9D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Jueves" || Dia == "Viernes") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.95D * 0.97D;
            }
            else if ((Estrato == '5' || Estrato == '6') && (Dia == "Sábado" || Dia == "Domingo") && (Genero == "Femenino"))
            {
                Total = ValorClaseC * 0.95D * 0.97D;
            }
            return Total;
        }
    }
}
