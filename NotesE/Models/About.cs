using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesE.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;

        public string Nombre => "Esteban galindo";
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://github.com/estebangalindo27";
        public string Message => "Me llamo esteban galindo y me gusta pasar con mis amigos";
    }
}
