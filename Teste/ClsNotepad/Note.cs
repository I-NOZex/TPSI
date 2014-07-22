using System;
using System.Collections.Generic;
using System.Text;

namespace ClsNotepad {
    public class Note {
        private string note;
        private DateTime date;

        /// <summary>
        /// Texto da nota
        /// </summary>
        public string NoteText {
            get {
                return note;
            }
            set {
                if (!string.IsNullOrEmpty(value))
                    note = value;
                else
                    throw new ArgumentNullException("Tem que inserir um texto na nota");
            }
        }

        /// <summary>
        /// Data em que a nota foi inserida
        /// </summary>
        public DateTime EntryDate {
            get {
                return date;
            }
            set {
                date = value;
            }
        }
    }
}
