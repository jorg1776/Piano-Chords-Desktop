using Piano_Chords_Desktop.Models;
using System.Windows.Input;

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

        public void OnNoteClicked(object sender, MouseButtonEventArgs e)
        {
            System.Console.WriteLine(((Note)sender).Value);
        }
    }
}
