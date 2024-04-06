using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace SGBDgeneric
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

//Tabel Raliu2

/*
<?xml version = "1.0" encoding = "utf-8" ?>
<configuration>

    <connectionStrings>

        <add name = "cn" connectionString = " Data Source = LAPTOP-LO9O0L3V\SQLEXPRESS ; Initial Catalog = Raliu2; Integrated Security= True " />


    </connectionStrings>

    <startup>

        <supportedRuntime version = "v4.0" sku = ".NETFramework,Version=v4.7.2" />

    </startup>

    <appSettings>

        <add key = "selectParent" value = "Select * from CATEGORIE" />

        <add key = "selectChild" value = "Select * from MASINA where ID_CAT= @id_parent" />

        <add key = "ChildColumnNames" value = "CAPACITATE_MOTOR,MARCA,MODEL" />

        <add key = "InsertQuery" value = "INSERT INTO MASINA(CAPACITATE_MOTOR, MARCA, MODEL,ID_CAT) VALUES(@CAPACITATE_MOTOR, @MARCA, @MODEL,@id_parent)" />

        <add key = "UpdateQuery" value = "UPDATE MASINA SET CAPACITATE_MOTOR=@CAPACITATE_MOTOR, MARCA=@MARCA, MODEL=@MODEL WHERE ID_MASINA=@id_child" />

        <add key = "DeleteQuery" value = "DELETE FROM MASINA WHERE ID_MASINA=@id_child" />

    </appSettings>




</configuration>
*/


//Tabel Muzica

/*
<?xml version = "1.0" encoding = "utf-8" ?>
<configuration>

    <connectionStrings>

        <add name = "cn" connectionString = " Data Source = LAPTOP-LO9O0L3V\SQLEXPRESS ; Initial Catalog = Muzica; Integrated Security= True" />


    </connectionStrings>

    <startup>

        <supportedRuntime version = "v4.0" sku = ".NETFramework,Version=v4.7.2" />

    </startup>

    <appSettings>

        <add key = "selectParent" value = "Select * from Album" />

        <add key = "selectChild" value = "Select * from Piesa where id_album= @id_parent" />

        <add key = "ChildColumnNames" value = "nume,artist" />

        <add key = "InsertQuery" value = "INSERT INTO Piesa(nume, artist, id_album) VALUES(@nume,@artist, @id_parent)" />

        <add key = "UpdateQuery" value = "UPDATE Piesa SET nume=@nume, artist=@artist WHERE id=@id_child" />

        <add key = "DeleteQuery" value = "DELETE FROM Piesa WHERE id=@id_child" />

    </appSettings>



</configuration>
*/