using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myTodoDLL;
using System.Xml.Serialization;
using System.IO;

namespace myTodoForm {
    public partial class frm_todo : Form {
        App myApp = new App();
        public frm_todo() {
            InitializeComponent();
        }

        private void frm_todo_Load(object sender, EventArgs e) {
            Todo t1 = new Todo();
            t1.Data = DateTime.Now;
            t1.Tarefa = "Oi";
            myApp.Data = DateTime.Now;
            myApp.User = "Ze";
            myApp.addTodo(t1);
            Open();
            dgv.DataSource = myApp.Todo_s;
        }

        private void Save() {
            XmlSerializer serial = new XmlSerializer(typeof(App));
            TextWriter writer = new StreamWriter(Application.LocalUserAppDataPath+"\\todo.xml");
            serial.Serialize(writer, myApp);
            writer.Close();
        }

        private void Open() {
            XmlSerializer serial = new XmlSerializer(typeof(App));
            TextReader reader = new StreamReader(Application.LocalUserAppDataPath + "\\todo.xml");
            myApp = (App)serial.Deserialize(reader);
            reader.Close();
        }

        private void btn_save_Click(object sender, EventArgs e) {
            Save();
        }

        private void btn_open_Click(object sender, EventArgs e) {
            Open();
            dgv.DataSource = myApp.Todo_s;
        }

        private void btn_new_Click(object sender, EventArgs e) {
            try {
                Todo t1 = new Todo();
                t1.Tarefa = txt_desc.Text;
                t1.Data = dtpick.Value;
                myApp.addTodo(t1);
            } catch (todoException ex) {
                MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
