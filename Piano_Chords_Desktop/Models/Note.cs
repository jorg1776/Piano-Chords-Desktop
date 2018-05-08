using System.Windows.Media;

namespace Piano_Chords_Desktop.Models
{
    public class Note
    {
        public string Value { get; private set; }
        private bool _isSelected = false;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                if (_isSelected) { Color = Brushes.LightBlue; }
                else { Color = DecideColor(Value); }
            }
        }
        public Brush Color { get; private set; }

        public Note(string value)
        {
            Value = value;
            Color = DecideColor(value);
        }

        private Brush DecideColor(string value)
        {
            if (value.Length == 1) { return Brushes.White; }
            else { return Brushes.Black; }
        }
    }
}
