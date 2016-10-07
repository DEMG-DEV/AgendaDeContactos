using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContactos
{
    class clTelefonos
    {
        dsTelefonosTableAdapters.telefonosTableAdapter taTelefonos = new dsTelefonosTableAdapters.telefonosTableAdapter();

        private long idTelefono;
        private long idContacto;
        private string trabajoTelefono;
        private string particularTelefono;
        private string faxTelefono;
        private string movilTelefono;

        public clTelefonos(long idcontacto)
        {
            this.idContacto = idcontacto;
        }

        public long IdTelefono
        {
            get
            {
                return idTelefono;
            }

            set
            {
                idTelefono = value;
            }
        }

        public long IdContacto
        {
            get
            {
                return idContacto;
            }

            set
            {
                idContacto = value;
            }
        }

        public string TrabajoTelefono
        {
            get
            {
                return trabajoTelefono;
            }

            set
            {
                trabajoTelefono = value;
            }
        }

        public string ParticularTelefono
        {
            get
            {
                return particularTelefono;
            }

            set
            {
                particularTelefono = value;
            }
        }

        public string FaxTelefono
        {
            get
            {
                return faxTelefono;
            }

            set
            {
                faxTelefono = value;
            }
        }

        public string MovilTelefono
        {
            get
            {
                return movilTelefono;
            }

            set
            {
                movilTelefono = value;
            }
        }

        public void insertarRegistro()
        {
            this.taTelefonos.Insert((int)idContacto, trabajoTelefono, particularTelefono, faxTelefono, movilTelefono);
        }

        public void borrarRegistro()
        {
            this.taTelefonos.Delete((int)this.idTelefono);
        }

        public void editarRegistro()
        {
            this.taTelefonos.Update((int)idContacto, trabajoTelefono, particularTelefono, faxTelefono, movilTelefono, (int)idTelefono);
            //this.taDetalleContacto.Update()
        }

        public void vaciarTelefono(System.Data.DataRow registro)
        {
            idTelefono = Convert.ToInt64(registro["idTelefono"].ToString());
            idContacto = Convert.ToInt64(registro["idContacto"].ToString());
            trabajoTelefono = registro["trabajoTelefono"].ToString();
            particularTelefono = registro["particularTelefono"].ToString();
            faxTelefono = registro["faxTelefono"].ToString();
            movilTelefono = registro["movilTelefono"].ToString();
        }
    }
}