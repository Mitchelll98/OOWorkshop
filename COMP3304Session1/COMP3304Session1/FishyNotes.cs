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
    /**
     * FishyNotes:  Form Class used to create new desktop notes
     */
    public partial class FishyNotes : Form
    {
        // Instance Variables

        // Declare a List of type FishyNote
        NoteData _notes;
        int _noteID = 0;

        // Declare a XXXX to store the xxx
        private FishyNote _newNote;

       


        /**
         * Constructor for objects of class FishyNotes
         */
        public FishyNotes()
        {
            // Parent Initialisation Method Called
            InitializeComponent();

            //
            _notes = new NoteData();
        }

        /**
         * Button Method:   Used to create & display a new instance of "FishyNote"
         */
        private void AddNote_Click(object sender, EventArgs e)
        {
            

            //IF
            if ((_newNote == null) || (_newNote.IsDisposed))
            {
                _newNote = new FishyNote(_noteID);

                // Increment Note ID
                _noteID++;

                // Add FishyNote to the NoteData
                _notes.AddNote(_newNote);

                _newNote.Show();             
            }


        }




        private void FishyNotes_Load(object sender, EventArgs e)
        {

        }

    }
}
