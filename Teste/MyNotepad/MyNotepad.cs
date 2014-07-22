using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClsNotepad;

namespace MyNotepad
{
    public partial class MyNotepad : Form
    {
        //NotesApp notesApp;
        NotesApp notes;
        public MyNotepad()
        {
            InitializeComponent();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e) {
            notes = Program.MyNoteApp;
            if(!notes.SaveAll())
                MessageBox.Show("Ocorreu um erro a salvar o ficheiro.");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e) {
            notes = Program.MyNoteApp;
            if(!notes.LoadAll())
                MessageBox.Show("Ocorreu um erro a abrir o ficheiro.");
            else
                dgvNotas.DataSource = notes.Notes;
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                Note note = new Note();
                note.NoteText = txtNota.Text;
                note.EntryDate = DateTime.Now;

                notes = Program.MyNoteApp;
                notes.AppFirstUsage = DateTime.Now;
                notes.UserRegisterId = Guid.NewGuid();
                notes.AddNotes(note);
                inputBox inputDlg = new inputBox();
                inputDlg.ShowDialog();
                notes.UserName = inputDlg.input;

                MessageBox.Show("Registo Guardado!");

                txtNota.Clear();
            } catch (Exception ex){
                MessageBox.Show("Ocorreu um erro.\n{0}",ex.Message);
            }
        }

        private void MyNotepad_Load(object sender, EventArgs e) {

        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            dgvNotas.DataSource = typeof(Note);
            dgvNotas.DataSource = notes.Notes;
            dgvNotas.Update();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}