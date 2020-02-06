using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    class NoteData
    {
        // Variables

        private List<FishyNote> _userNotes = new List<FishyNote>();


        // Constructor
        public NoteData()
        {

        }



        // Add Note Method:     Used to ...
        public void AddNote(FishyNote _note)
        {
            // Add the FishyNote to the List
            _userNotes.Add(_note);


            // Loop through the notes list and show each one
            for (int i = 0; i < _userNotes.Count; i++)
            {
                //
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Note ID: " + _userNotes[i].NoteID);
                Console.WriteLine("----------------------------------");

                for (int z = 0; z < _userNotes[i].NoteData.Count; z++)
                {
                    Console.WriteLine(_userNotes[i].NoteData[z]);
                }

                Console.WriteLine("----------------------------------");
            }


            
        }


        // Remove Note Method:     Used to ...
        public void RemoveNote(int id)
        {

            for (int i = 0; i < _userNotes.Count; i++)
            {
                if (_userNotes[i].NoteID == id)
                {
                    _userNotes.Remove(_userNotes[i]);
                }
            }

        }



        // Retreive Note Method:     Used to ...
        public List<string> RetreiveNote(int id)
        {

            for (int i = 0; i < _userNotes.Count; i++)
            {
                if (_userNotes[i].NoteID == id)
                {
                    return _userNotes[i].NoteData;
                }
            }

            return null;
        }


    }
}
