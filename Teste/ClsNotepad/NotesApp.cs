using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ClsNotepad {
    public class NotesApp {
        private DateTime appFirstUsage;
        private string userName;
        private Guid userRegId;
        private List<Note> notes;

        private string path = AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "NotesAppDB.xml";

        /// <summary>
        /// Data da primeira utilização da aplicação
        /// </summary>
        public DateTime AppFirstUsage {
            get {
                return appFirstUsage;
            }
            set {
                appFirstUsage = value;
            }
        }

        /// <summary>
        /// Nome do utilizador da app - para utilização num procedimento de registo da aplicação no futuro
        /// </summary>
        public String UserName {
            get {
                return userName;
            }
            set {
                if (!string.IsNullOrEmpty(value))
                    userName = value;
                else
                    throw new ArgumentNullException("Tem que inserir um nome de utilizador");
            }
        }

        /// <summary>
        /// Identificador atribuido aquando do registo da app.
        /// </summary>
        public Guid UserRegisterId {
            get {
                return userRegId;
            }
            set {
                userRegId = value;
            }
        }

        /// <summary>
        /// Lista com notas
        /// </summary>
        public List<Note> Notes {
            get {
                return notes;
            }
            set {
                notes = value;
            }
        }
        /// <summary>
        /// Carrega os dados existentes e devolve true se a operação for bem sucedida. Os dados são lidos da pasta onde o programa está a ser executado
        /// </summary>
        public bool LoadAll() {
            TextReader reader = null;
            try {
                reader = new StreamReader(path);
                NotesApp notesapp;
                XmlSerializer xml = new XmlSerializer(typeof(NotesApp));
                notesapp = (NotesApp)xml.Deserialize(reader);
                this.AppFirstUsage = notesapp.AppFirstUsage;
                this.Notes = notesapp.Notes;
                this.UserName = notesapp.UserName;
                this.UserRegisterId = notesapp.UserRegisterId;
            }
            catch {
                return false;
            }
            finally {
                if (reader != default(TextReader))
                    reader.Close();
            }
            return true;
        }

        /// <summary>
        /// Salva os dados. Devolve true se for bem sucedida. Os dados são armazenados na pasta onde o programa está a ser executado.
        /// </summary>
        public bool SaveAll() {
            TextWriter writer = null;
            try {
                writer = new StreamWriter(path);
                XmlSerializer xml = new XmlSerializer(typeof(NotesApp));
                xml.Serialize(writer, this);
            } catch {
                return false;
            } finally {
                if (writer != default(TextWriter))
                    writer.Close();
            }
            return true;
        }

        /// <summary>
        /// Devolve um nº inteiro com o total de registos encontrados
        /// </summary>
        public int ShowTotalNotes() {
            return notes.Count;
        }

        public void AddNotes(Note note) {
            if (Notes == default(List<Note>))
                Notes = new List<Note>();
            Notes.Add(note);
        }
    }
}
