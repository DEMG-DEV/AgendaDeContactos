using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContactos
{
    class clDetalleContacto
    {
        dsDetalleContactoTableAdapters.contactoTableAdapter taDetalleContacto = new dsDetalleContactoTableAdapters.contactoTableAdapter();

        private long idContacto;
        private string tratamientoContacto;
        private string nombreContacto;
        private string apePaternoContacto;
        private string apeMaternoContacto;
        private string organizacionContacto;
        private string puestoContacto;

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

        public string TratamientoContacto
        {
            get
            {
                return tratamientoContacto;
            }

            set
            {
                tratamientoContacto = value;
            }
        }

        public string NombreContacto
        {
            get
            {
                return nombreContacto;
            }

            set
            {
                nombreContacto = value;
            }
        }

        public string ApePaternoContacto
        {
            get
            {
                return apePaternoContacto;
            }

            set
            {
                apePaternoContacto = value;
            }
        }

        public string ApeMaternoContacto
        {
            get
            {
                return apeMaternoContacto;
            }

            set
            {
                apeMaternoContacto = value;
            }
        }

        public string OrganizacionContacto
        {
            get
            {
                return organizacionContacto;
            }

            set
            {
                organizacionContacto = value;
            }
        }

        public string PuestoContacto
        {
            get
            {
                return puestoContacto;
            }

            set
            {
                puestoContacto = value;
            }
        }

        public void insertarRegistro()
        {
            this.taDetalleContacto.Insert(tratamientoContacto, nombreContacto, apePaternoContacto, apeMaternoContacto, organizacionContacto, puestoContacto);
        }

        public void borrarRegistro()
        {
            this.taDetalleContacto.Delete((int)idContacto);
        }

        public void editarRegistro()
        {
            //this.taDetalleContacto.Update()
        }

        public void vaciarRegistro(System.Data.DataRow registro)
        {
            idContacto = Convert.ToInt64(registro["idContacto"].ToString());
            tratamientoContacto = registro["tratamientoContacto"].ToString();
            nombreContacto = registro["nombreContacto"].ToString();
            apePaternoContacto = registro["apePaternoContacto"].ToString();
            apeMaternoContacto = registro["apeMaternoContacto"].ToString();
            organizacionContacto = registro["organizacionContacto"].ToString();
            puestoContacto = registro["puestoContacto"].ToString();
        }
    }
}
