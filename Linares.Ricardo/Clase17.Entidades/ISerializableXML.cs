using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Clase17.Entidades
{
    public interface ISerializableXML
    {
        bool Serializar();

        bool Deserializar();

        string PATH { get; set; }
    }
}
