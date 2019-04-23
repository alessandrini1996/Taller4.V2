using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApplication.ViewModels.Profesor
{
    public class ProfesorView
    {
        public IEnumerable<ProfesorViewI> Profesor { get; set; }

        public ProfeseorView()
        {
            Profesor = Enumerable.Empty<ProfesorViewI>();
        }
    }
}