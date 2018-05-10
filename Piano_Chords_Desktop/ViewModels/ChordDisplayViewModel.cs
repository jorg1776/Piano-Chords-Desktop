using Piano_Chords_Desktop.Models;


namespace Piano_Chords_Desktop.ViewModels
{
    class ChordDisplayViewModel : ViewModelBase
    {
        public Note[] Notes { get; } = {
            new Note("C"),
            new Note("C#"),
            new Note("D"),
            new Note("D#"),
            new Note("E"),
            new Note("F"),
            new Note("F#"),
            new Note("G"),
            new Note("G#"),
            new Note("A"),
            new Note("A#"),
            new Note("B"),
            new Note("C"),
            new Note("C#"),
            new Note("D"),
            new Note("D#"),
            new Note("E"),
            new Note("F"),
            new Note("F#"),
            new Note("G"),
            new Note("G#"),
            new Note("A"),
            new Note("A#"),
            new Note("B"),
            new Note("C")
        };

        private string _selectedRoot;
        public string SelectedRoot
        {
            get { return _selectedRoot; }
            set
            {
                if (value.Equals(_selectedRoot)) { return; }

                _selectedRoot = value;
                ClearKeyboard();
                HighlightChord(_selectedRoot);
                NotifyPropertyChanged(nameof(SelectedRoot));
            }
        }

        private void ClearKeyboard()
        {
            foreach (Note key in Notes)
            {
                key.IsSelected = false;
            }
        }

        public void HighlightChord(string root)
        {
            root = TrimString(root);
            int rootIndex = GetNoteIndex(root);

            Notes[rootIndex].IsSelected = true;

        }

        private int GetNoteIndex(string note)
        {
            switch (note)
            {
                case "C": return 0;
                case "C#": return 1;
                case "D": return 2;
                case "D#": return 3;
                case "E": return 4;
                case "F": return 5;
                case "F#": return 6;
                case "G": return 7;
                case "G#": return 8;
                case "A": return 9;
                case "A#": return 10;
                case "B": return 11;
                default: return 0;
            }
        }

        private string TrimString(string root)
        {
            string[] splitString = root.Split(' ');
            return splitString[1];
        }
    }
}
