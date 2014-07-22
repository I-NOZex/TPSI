using System;
using System.Collections.Generic;
using System.Text;

namespace ClsNotepad
{
    public class NotesApp
    {
        /// <summary>
        /// Data da primeira utilização da aplicação
        /// </summary>
        public DateTime AppFirstUsage
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Nome do utilizador da app - para utilização num procedimento de registo da aplicação no futuro
        /// </summary>
        public String UserName
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Identificador atribuido aquando do registo da app.
        /// </summary>
        public Guid UserRegisterId
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Lista com notas
        /// </summary>
        public List<Note> Notes
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Carrega os dados existentes e devolve true se a operação for bem sucedida. Os dados são lidos da pasta onde o programa está a ser executado
        /// </summary>
        public bool LoadAll()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Salva os dados. Devolve true se for bem sucedida. Os dados são armazenados na pasta onde o programa está a ser executado.
        /// </summary>
        public bool SaveAll()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Devolve um nº inteiro com o total de registos encontrados
        /// </summary>
        public int ShowTotalNotes()
        {
            throw new System.NotImplementedException();
        }
    }
}
