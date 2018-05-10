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
                HighlightChord(_selectedRoot);
            }
        }

        private string _selectedChord;
        public string SelectedChord
        {
            get { return _selectedChord; }
            set
            {
                if (value.Equals(_selectedChord)) { return; }
                _selectedChord = value;
                HighlightChord(SelectedRoot);
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
            ClearKeyboard();

            root = TrimString(root);
            int rootIndex = GetNoteIndex(root);

            Notes[rootIndex].IsSelected = true;

            int[] chordDefinition = GetChordDefinition(SelectedChord);

            foreach (int steps in chordDefinition)
            {
                Notes[rootIndex + steps].IsSelected = true;
            }
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

        private int[] GetChordDefinition(string chord)
        {
            chord = TrimString(chord);

            switch (chord)
            {
                case "Major": return ChordDefinitions.Major;
                case "Minor": return ChordDefinitions.Minor;
                default: return ChordDefinitions.Major;
            }
        }

        private string TrimString(string input)
        {
            if (input != null)
            {
                string[] splitString = input.Split(' ');
                if (splitString.Length > 1)
                    return splitString[1];
                else
                    return input;
            }
            else
                return input;
        }
    }
}
