using System;
using System.Collections.Generic;
using System.Data;
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
            //this.taTelefonos.Delete((int)this.idTelefono);
            this.taTelefonos.Delete((int)this.idContacto);
        }

        public void editarRegistro()
        {
            this.taTelefonos.Update((int)idContacto, trabajoTelefono, particularTelefono, faxTelefono, movilTelefono, (int)idContacto);
            //this.taDetalleContacto.Update()
        }

        public void vaciarTelefono()
        {
            DataTable dt = this.taTelefonos.GetDataBy((int)idContacto);

            DataRow row = dt.Rows[0];

            idTelefono = Convert.ToInt64(row["idTelefono"].ToString());
            trabajoTelefono = row["trabajoTelefono"].ToString();
            particularTelefono = row["particularTelefono"].ToString();
            faxTelefono = row["faxTelefono"].ToString();
            movilTelefono = row["movilTelefono"].ToString();
        }
    }
}