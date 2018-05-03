using System;
using System.Collections.Generic;
using System.Text;

namespace Encuestas
{
    class encuesta
    {
        #region
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EquipoFavorito { get; set; }
        #endregion
        #region
        public override string ToString()
        {
            return $"{Nombre}!{FechaNacimiento}!{EquipoFavorito}";
        }
        #endregion
    }
}
