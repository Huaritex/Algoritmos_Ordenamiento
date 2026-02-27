namespace Estructuras_Objetos;

public class Numero
{
    int valor;

    public Numero()
    {
        valor = 1;
    }

    public Numero(int valor)
    {
        if (valor >= 0)
        {
            this.valor = valor;
        }
        else
        {
            this.valor = 0;
        }
    }

    public int obtenervalor(){
        return valor;

    }



    public void ponerValor(int valor){
        if(valor >= 0){
            this.valor = valor;
        }
    }

    public bool num_primo(){
        if (valor < 2) 
        return false;
            for (int i = 2; i <= Math.Sqrt(valor); i++)
        {
            if (valor % i == 0) 
            return false;
        }
        return true;
    }

    public int cantidad_digitos(){
        if (valor == 0) return 1;
        int cantidad = 0;
        int temporal = valor;
        while (temporal > 0)
        {
            cantidad++;
            temporal = temporal / 10;
        }
        return cantidad;
    }


    public int OrdenarDigitosBurbuja()
    {
        int cantidad = cantidad_digitos();
        int ordenado = valor;

        for (int indice = 0; indice < cantidad - 1; indice++)
        {
            for (int siguiente = 0; siguiente < cantidad - 1 - indice; siguiente++)
            {
                int potenciaIzq = 1;
                for (int k = 0; k < cantidad - 1 - siguiente; k++)
                    potenciaIzq = potenciaIzq * 10;
                int potenciaDer = potenciaIzq / 10;

                int digitoIzq = (ordenado / potenciaIzq) % 10;
                int digitoDer = (ordenado / potenciaDer) % 10;

                if (digitoIzq > digitoDer)
                {
                    ordenado = ordenado
                        + (digitoDer - digitoIzq) * potenciaIzq
                        + (digitoIzq - digitoDer) * potenciaDer;
                }
            }
        }
        return ordenado;
    }


    public int OrdenarDigitosSeleccion()
    {
        int cantidad = cantidad_digitos();
        int ordenado = valor;

        for (int indice = 0; indice < cantidad - 1; indice++)
        {
            int potenciaIndice = 1;
            for (int k = 0; k < cantidad - 1 - indice; k++)
                potenciaIndice = potenciaIndice * 10;

            int digitoMenor = (ordenado / potenciaIndice) % 10;
            int posicionMenor = indice;

            for (int siguiente = indice + 1; siguiente < cantidad; siguiente++)
            {
                int potenciaSiguiente = 1;
                for (int k = 0; k < cantidad - 1 - siguiente; k++)
                    potenciaSiguiente = potenciaSiguiente * 10;

                int digitoActual = (ordenado / potenciaSiguiente) % 10;
                if (digitoActual < digitoMenor)
                {
                    digitoMenor = digitoActual;
                    posicionMenor = siguiente;
                }
            }

            if (posicionMenor != indice)
            {
                int potenciaMenor = 1;
                for (int k = 0; k < cantidad - 1 - posicionMenor; k++)
                    potenciaMenor = potenciaMenor * 10;

                int digitoIndice = (ordenado / potenciaIndice) % 10;
                ordenado = ordenado
                    + (digitoMenor - digitoIndice) * potenciaIndice
                    + (digitoIndice - digitoMenor) * potenciaMenor;
            }
        }
        return ordenado;
    }

    public string ConvertirALiteral()
    {
        if (valor == 0) return "cero";
        if (valor > 9999) return "numero fuera de rango";

        string[] unidades = { "", "uno", "dos", "tres", "cuatro", "cinco",
                               "seis", "siete", "ocho", "nueve", "diez",
                               "once", "doce", "trece", "catorce", "quince",
                               "dieciseis", "diecisiete", "dieciocho", "diecinueve" };

        string[] decenas = { "", "diez", "veinte", "treinta", "cuarenta",
                              "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

        string[] centenas = { "", "ciento", "doscientos", "trescientos", "cuatrocientos",
                               "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };

        string resultado = "";
        int numero = valor;

        if (numero >= 1000)
        {
            int miles = numero / 1000;
            if (miles == 1)
                resultado += "mil ";
            else
                resultado += unidades[miles] + " mil ";
            numero = numero % 1000;
        }

        if (numero >= 100)
        {
            if (numero == 100)
                resultado += "cien ";
            else
                resultado += centenas[numero / 100] + " ";
            numero = numero % 100;
        }

        if (numero >= 20)
        {
            resultado += decenas[numero / 10];
            if (numero % 10 != 0)
                resultado += " y " + unidades[numero % 10];
        }
        else if (numero > 0)
        {
            resultado += unidades[numero];
        }

        return resultado.Trim();
    }
}

    

