﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Examen_Progra_RAD.Modelo
{
    public class ClaseRegistro
    {
            [PrimaryKey, AutoIncrement]
            public int id { get; set; }

            [MaxLength(100)]
            public string nombres { get; set; }

            [MaxLength(100)]
            public string apellidos { get; set; }
            public int edad { get; set; }

            [MaxLength(300)]
            public string notas { get; set; }
            public int Latitud { get; set; }
            public int Longitud { get; set;}
    }
}
