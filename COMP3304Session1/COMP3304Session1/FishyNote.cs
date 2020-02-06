using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    public partial class FishyNote : Form
    {
        // Variables
        private int _idNumber;

        //
        //NoteData _noteData;


        bool _isCollasped = false;

        private List<string> _userNotes = new List<string>();
        string _textNote = "";


        // Constructor
        public FishyNote(int id)
        {
            this.NoteID = id;
            InitializeComponent();
        }

        public int NoteID   // Note ID property
        {
            get { return _idNumber; }   // get method
            set { _idNumber = value; }  // set method
        }

        public List<string> NoteData   // Note Data property
        {
            get { return _userNotes; }   // get method
            set { _userNotes = value; }  // set method
        }


        private void ExitNote_Click(object sender, EventArgs e)
        {
            // Disposes of Current Note
            this.Dispose();
        }

        private void ActionNote_Click(object sender, EventArgs e)
        {

            if (!_isCollasped)
            {
                // Collaspe Note
                this.Size = new Size(this.Size.Width, 90);
                textNote.Visible = false;
                _isCollasped = true;
            }
            else
            {
                // Enlarge Note
                this.Size = new Size(this.Size.Width, 280);
                textNote.Visible = true;
                _isCollasped = false;


                
                
            }


            

        }

        private void textNote_Click(object sender, EventArgs e)
        {
            _userNotes.Add(_textNote);

            textNote.Text = "";
            
        }

        private void textNote_TextChanged(object sender, EventArgs e)
        {
            _textNote = textNote.Text;
        }
    }
}
