using GuitarApp.Classes;
using GuitarApp.ViewModel.Commands;
using System;
using System.ComponentModel;
using System.Windows;

namespace GuitarApp.ViewModel
{
    public class GuitarViewModel : INotifyPropertyChanged
    {

        private string setter;

        public string Setter
        {
            get { return setter; }
            set { setter = value; }
        }

        private NoteReference noteReference = new NoteReference();

        private bool buttonEnabled = true;

        public bool ButtonEnabled
        {
            get { return buttonEnabled; }
            set { buttonEnabled = value; }
        }


        #region HighENotes

        private string highE1;
        public string HighE1
        {
            get { return highE1; }
            set
            {
                highE1 = ValidateInput(value);
                OnPropertyChanged("HighE1");
            }
        }

        private string highE2;
        public string HighE2
        {
            get { return highE2; }
            set
            {
                highE2 = ValidateInput(value);
                OnPropertyChanged("HighE2");
            }
        }

        private string highE3;
        public string HighE3
        {
            get { return highE3; }
            set
            {
                highE3 = ValidateInput(value);
                OnPropertyChanged("HighE3");
            }
        }

        private string highE4;
        public string HighE4
        {
            get { return highE4; }
            set
            {
                highE4 = ValidateInput(value);
                OnPropertyChanged("HighE4");
            }
        }

        private string highE5;
        public string HighE5
        {
            get { return highE5; }
            set
            {
                highE5 = ValidateInput(value);
                OnPropertyChanged("HighE5");
            }
        }

        private string highE6;
        public string HighE6
        {
            get { return highE6; }
            set
            {
                highE6 = ValidateInput(value);
                OnPropertyChanged("HighE6");
            }
        }

        private string highE7;
        public string HighE7
        {
            get { return highE7; }
            set
            {
                highE7 = ValidateInput(value);
                OnPropertyChanged("HighE7");
            }
        }

        private string highE8;
        public string HighE8
        {
            get { return highE8; }
            set
            {
                highE8 = ValidateInput(value);
                OnPropertyChanged("HighE8");
            }
        }

        private string highE9;
        public string HighE9
        {
            get { return highE9; }
            set
            {
                highE9 = ValidateInput(value);
                OnPropertyChanged("HighE9");
            }
        }

        private string highE10;
        public string HighE10
        {
            get { return highE10; }
            set
            {
                highE10 = ValidateInput(value);
                OnPropertyChanged("HighE10");
            }
        }
        #endregion

        #region BNoteProeprties

        private string b1;
        public string B1
        {
            get { return b1; }
            set
            {
                b1 = ValidateInput(value);
                OnPropertyChanged("B1");
            }
        }

        private string b2;
        public string B2
        {
            get { return b2; }
            set
            {
                b2 = ValidateInput(value);
                OnPropertyChanged("B2");
            }
        }

        private string b3;
        public string B3
        {
            get { return b3; }
            set
            {
                b3 = ValidateInput(value);
                OnPropertyChanged("B3");
            }
        }

        private string b4;
        public string B4
        {
            get { return b4; }
            set
            {
                b4 = ValidateInput(value);
                OnPropertyChanged("B4");
            }
        }

        private string b5;
        public string B5
        {
            get { return b5; }
            set
            {
                b5 = ValidateInput(value);
                OnPropertyChanged("B5");
            }
        }

        private string b6;
        public string B6
        {
            get { return b6; }
            set
            {
                b6 = ValidateInput(value);
                OnPropertyChanged("B6");
            }
        }

        private string b7;
        public string B7
        {
            get { return b7; }
            set
            {
                b7 = ValidateInput(value);
                OnPropertyChanged("B7");
            }
        }

        private string b8;
        public string B8
        {
            get { return b8; }
            set
            {
                b8 = ValidateInput(value);
                OnPropertyChanged("B8");
            }
        }

        private string b9;
        public string B9
        {
            get { return b9; }
            set
            {
                b9 = ValidateInput(value);
                OnPropertyChanged("B9");
            }
        }

        private string b10;
        public string B10
        {
            get { return b10; }
            set
            {
                b10 = ValidateInput(value);
                OnPropertyChanged("B10");
            }
        }

        #endregion

        #region GNoteProperties

        private string g1;
        public string G1
        {
            get { return g1; }
            set
            {
                g1 = ValidateInput(value);
                OnPropertyChanged("G1");
            }
        }

        private string g2;
        public string G2
        {
            get { return g2; }
            set
            {
                g2 = ValidateInput(value);
                OnPropertyChanged("G2");
            }
        }

        private string g3;
        public string G3
        {
            get { return g3; }
            set
            {
                g3 = ValidateInput(value);
                OnPropertyChanged("G3");
            }
        }

        private string g4;
        public string G4
        {
            get { return g4; }
            set
            {
                g4 = ValidateInput(value);
                OnPropertyChanged("G4");
            }
        }

        private string g5;
        public string G5
        {
            get { return g5; }
            set
            {
                g5 = ValidateInput(value);
                OnPropertyChanged("G5");
            }
        }

        private string g6;
        public string G6
        {
            get { return g6; }
            set
            {
                g6 = ValidateInput(value);
                OnPropertyChanged("G6");
            }
        }

        private string g7;
        public string G7
        {
            get { return g7; }
            set
            {
                g7 = ValidateInput(value);
                OnPropertyChanged("G7");
            }
        }

        private string g8;
        public string G8
        {
            get { return g8; }
            set
            {
                g8 = ValidateInput(value);
                OnPropertyChanged("G8");
            }
        }

        private string g9;
        public string G9
        {
            get { return g9; }
            set
            {
                g9 = ValidateInput(value);
                OnPropertyChanged("G9");
            }
        }

        private string g10;
        public string G10
        {
            get { return g10; }
            set
            {
                g10 = ValidateInput(value);
                OnPropertyChanged("G10");
            }
        }
        #endregion

        #region DNoteProperties

        private string d1;
        public string D1
        {
            get { return d1; }
            set
            {
                d1 = ValidateInput(value);
                OnPropertyChanged("D1");
            }
        }

        private string d2;
        public string D2
        {
            get { return d2; }
            set
            {
                d2 = ValidateInput(value);
                OnPropertyChanged("D2");
            }
        }

        private string d3;
        public string D3
        {
            get { return d3; }
            set
            {
                d3 = ValidateInput(value);
                OnPropertyChanged("D3");
            }
        }

        private string d4;
        public string D4
        {
            get { return d4; }
            set
            {
                d4 = ValidateInput(value);
                OnPropertyChanged("D4");
            }
        }

        private string d5;
        public string D5
        {
            get { return d5; }
            set
            {
                d5 = ValidateInput(value);
                OnPropertyChanged("D5");
            }
        }

        private string d6;
        public string D6
        {
            get { return d6; }
            set
            {
                d6 = ValidateInput(value);
                OnPropertyChanged("D6");
            }
        }

        private string d7;
        public string D7
        {
            get { return d7; }
            set
            {
                d7 = ValidateInput(value);
                OnPropertyChanged("D7");
            }
        }

        private string d8;
        public string D8
        {
            get { return d8; }
            set
            {
                d8 = ValidateInput(value);
                OnPropertyChanged("D8");
            }
        }

        private string d9;
        public string D9
        {
            get { return d9; }
            set
            {
                d9 = ValidateInput(value);
                OnPropertyChanged("D9");
            }
        }

        private string d10;
        public string D10
        {
            get { return d10; }
            set
            {
                d10 = ValidateInput(value);
                OnPropertyChanged("D10");
            }
        }
        #endregion

        #region ANoteProperties

        private string a1;
        public string A1
        {
            get { return a1; }
            set
            {
                a1 = ValidateInput(value);
                OnPropertyChanged("A1");
            }
        }

        private string a2;
        public string A2
        {
            get { return a2; }
            set
            {
                a2 = ValidateInput(value);
                OnPropertyChanged("A2");
            }
        }

        private string a3;
        public string A3
        {
            get { return a3; }
            set
            {
                a3 = ValidateInput(value);
                OnPropertyChanged("A3");
            }
        }

        private string a4;
        public string A4
        {
            get { return a4; }
            set
            {
                a4 = ValidateInput(value);
                OnPropertyChanged("A4");
            }
        }

        private string a5;
        public string A5
        {
            get { return a5; }
            set
            {
                a5 = ValidateInput(value);
                OnPropertyChanged("A5");
            }
        }

        private string a6;
        public string A6
        {
            get { return a6; }
            set
            {
                a6 = ValidateInput(value);
                OnPropertyChanged("A6");
            }
        }

        private string a7;
        public string A7
        {
            get { return a7; }
            set
            {
                a7 = ValidateInput(value);
                OnPropertyChanged("A7");
            }
        }

        private string a8;
        public string A8
        {
            get { return a8; }
            set
            {
                a8 = ValidateInput(value);
                OnPropertyChanged("A8");
            }
        }

        private string a9;
        public string A9
        {
            get { return a9; }
            set
            {
                a9 = ValidateInput(value);
                OnPropertyChanged("A9");
            }
        }

        private string a10;
        public string A10
        {
            get { return a10; }
            set
            {
                a10 = ValidateInput(value);
                OnPropertyChanged("A10");
            }
        }
        #endregion

        #region LowEProperties

        private string lowE1;

        public string LowE1
        {
            get { return lowE1; }
            set
            {
                lowE1 = ValidateInput(value);
                OnPropertyChanged("LowE1");
            }
        }

        private string lowE2;

        public string LowE2
        {
            get { return lowE2; }
            set
            {
                lowE2 = ValidateInput(value);
                OnPropertyChanged("LowE2");
            }
        }

        private string lowE3;

        public string LowE3
        {
            get { return lowE3; }
            set
            {
                lowE3 = ValidateInput(value);
                OnPropertyChanged("LowE3");
            }
        }

        private string lowE4;

        public string LowE4
        {
            get { return lowE4; }
            set
            {
                lowE4 = ValidateInput(value);
                OnPropertyChanged("LowE4");
            }
        }

        private string lowE5;

        public string LowE5
        {
            get { return lowE5; }
            set
            {
                lowE5 = ValidateInput(value);
                OnPropertyChanged("LowE5");
            }
        }

        private string lowE6;

        public string LowE6
        {
            get { return lowE6; }
            set
            {
                lowE6 = ValidateInput(value);
                OnPropertyChanged("LowE6");
            }
        }

        private string lowE7;

        public string LowE7
        {
            get { return lowE7; }
            set
            {
                lowE7 = ValidateInput(value);
                OnPropertyChanged("LowE7");
            }
        }

        private string lowE8;

        public string LowE8
        {
            get { return lowE8; }
            set
            {
                lowE8 = ValidateInput(value);
                OnPropertyChanged("LowE8");
            }
        }

        private string lowE9;

        public string LowE9
        {
            get { return lowE9; }
            set
            {
                lowE9 = ValidateInput(value);
                OnPropertyChanged("LowE9");
            }
        }

        private string lowE10;

        public string LowE10
        {
            get { return lowE10; }
            set
            {
                lowE10 = ValidateInput(value);
                OnPropertyChanged("LowE10");
            }
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public NoteQueryCommand NoteQueryCommand { get; set; }
        public ClearTextboxesCommand ClearTextboxesCommand { get; set; }

        public GuitarViewModel()
        {
            NoteQueryCommand = new NoteQueryCommand(this);
            ClearTextboxesCommand = new ClearTextboxesCommand(this);
        }

        public bool SetButton()
        {
            if (buttonEnabled == true)
            {
                buttonEnabled = false;
                return buttonEnabled;
            }

            else
            {
                buttonEnabled = true;
                return buttonEnabled;
            }

        }
        public void GetLowENote()
        {
            LowE1 = (!string.IsNullOrWhiteSpace(LowE1)) ? noteReference.lowENotes[LowE1] : "";
            LowE2 = (!string.IsNullOrWhiteSpace(LowE2)) ? noteReference.lowENotes[LowE2] : "";
            LowE3 = (!string.IsNullOrWhiteSpace(LowE3)) ? noteReference.lowENotes[LowE3] : "";
            LowE4 = (!string.IsNullOrWhiteSpace(LowE4)) ? noteReference.lowENotes[LowE4] : "";
            LowE5 = (!string.IsNullOrWhiteSpace(LowE5)) ? noteReference.lowENotes[LowE5] : "";
            LowE6 = (!string.IsNullOrWhiteSpace(LowE6)) ? noteReference.lowENotes[LowE6] : "";
            LowE7 = (!string.IsNullOrWhiteSpace(LowE7)) ? noteReference.lowENotes[LowE7] : "";
            LowE8 = (!string.IsNullOrWhiteSpace(LowE8)) ? noteReference.lowENotes[LowE8] : "";
            LowE9 = (!string.IsNullOrWhiteSpace(LowE9)) ? noteReference.lowENotes[LowE9] : "";
            LowE10 = (!string.IsNullOrWhiteSpace(LowE10)) ? noteReference.lowENotes[LowE10] : "";
        }

        public void GetBNote()
        {
            B1 = (!string.IsNullOrWhiteSpace(B1)) ? noteReference.bNotes[B1] : "";
            B2 = (!string.IsNullOrWhiteSpace(B2)) ? noteReference.bNotes[B2] : "";
            B3 = (!string.IsNullOrWhiteSpace(B3)) ? noteReference.bNotes[B3] : "";
            B4 = (!string.IsNullOrWhiteSpace(B4)) ? noteReference.bNotes[B4] : "";
            B5 = (!string.IsNullOrWhiteSpace(B5)) ? noteReference.bNotes[B5] : "";
            B6 = (!string.IsNullOrWhiteSpace(B6)) ? noteReference.bNotes[B6] : "";
            B7 = (!string.IsNullOrWhiteSpace(B7)) ? noteReference.bNotes[B7] : "";
            B8 = (!string.IsNullOrWhiteSpace(B8)) ? noteReference.bNotes[B8] : "";
            B9 = (!string.IsNullOrWhiteSpace(B9)) ? noteReference.bNotes[B9] : "";
            B10 = (!string.IsNullOrWhiteSpace(B10)) ? noteReference.bNotes[B10] : "";
        }

        public void GetGNote()
        {
            G1 = (!string.IsNullOrWhiteSpace(G1)) ? noteReference.gNotes[G1] : "";
            G2 = (!string.IsNullOrWhiteSpace(G2)) ? noteReference.gNotes[G2] : "";
            G3 = (!string.IsNullOrWhiteSpace(G3)) ? noteReference.gNotes[G3] : "";
            G4 = (!string.IsNullOrWhiteSpace(G4)) ? noteReference.gNotes[G4] : "";
            G5 = (!string.IsNullOrWhiteSpace(G5)) ? noteReference.gNotes[G5] : "";
            G6 = (!string.IsNullOrWhiteSpace(G6)) ? noteReference.gNotes[G6] : "";
            G7 = (!string.IsNullOrWhiteSpace(G7)) ? noteReference.gNotes[G7] : "";
            G8 = (!string.IsNullOrWhiteSpace(G8)) ? noteReference.gNotes[G8] : "";
            G9 = (!string.IsNullOrWhiteSpace(G9)) ? noteReference.gNotes[G9] : "";
            G10 = (!string.IsNullOrWhiteSpace(G10)) ? noteReference.gNotes[G10] : "";
        }

        public void GetDNote()
        {
            D1 = (!string.IsNullOrWhiteSpace(D1)) ? noteReference.dNotes[D1] : "";
            D2 = (!string.IsNullOrWhiteSpace(D2)) ? noteReference.dNotes[D2] : "";
            D3 = (!string.IsNullOrWhiteSpace(D3)) ? noteReference.dNotes[D3] : "";
            D4 = (!string.IsNullOrWhiteSpace(D4)) ? noteReference.dNotes[D4] : "";
            D5 = (!string.IsNullOrWhiteSpace(D5)) ? noteReference.dNotes[D5] : "";
            D6 = (!string.IsNullOrWhiteSpace(D6)) ? noteReference.dNotes[D6] : "";
            D7 = (!string.IsNullOrWhiteSpace(D7)) ? noteReference.dNotes[D7] : "";
            D8 = (!string.IsNullOrWhiteSpace(D8)) ? noteReference.dNotes[D8] : "";
            D9 = (!string.IsNullOrWhiteSpace(D9)) ? noteReference.dNotes[D9] : "";
            D10 = (!string.IsNullOrWhiteSpace(D10)) ? noteReference.dNotes[D10] : "";
        }

        public void GetANote()
        {
            A1 = (!string.IsNullOrWhiteSpace(A1)) ? noteReference.aNotes[A1] : "";
            A2 = (!string.IsNullOrWhiteSpace(A2)) ? noteReference.aNotes[A2] : "";
            A3 = (!string.IsNullOrWhiteSpace(A3)) ? noteReference.aNotes[A3] : "";
            A4 = (!string.IsNullOrWhiteSpace(A4)) ? noteReference.aNotes[A4] : "";
            A5 = (!string.IsNullOrWhiteSpace(A5)) ? noteReference.aNotes[A5] : "";
            A6 = (!string.IsNullOrWhiteSpace(A6)) ? noteReference.aNotes[A6] : "";
            A7 = (!string.IsNullOrWhiteSpace(A7)) ? noteReference.aNotes[A7] : "";
            A8 = (!string.IsNullOrWhiteSpace(A8)) ? noteReference.aNotes[A8] : "";
            A9 = (!string.IsNullOrWhiteSpace(A9)) ? noteReference.aNotes[A9] : "";
            A10 = (!string.IsNullOrWhiteSpace(A10)) ? noteReference.aNotes[A10] : "";
        }

        public void GetHighENote()
        {
            HighE1 = (!string.IsNullOrWhiteSpace(HighE1)) ? noteReference.highENotes[HighE1] : "";
            HighE2 = (!string.IsNullOrWhiteSpace(HighE2)) ? noteReference.highENotes[HighE2] : "";
            HighE3 = (!string.IsNullOrWhiteSpace(HighE3)) ? noteReference.highENotes[HighE3] : "";
            HighE4 = (!string.IsNullOrWhiteSpace(HighE4)) ? noteReference.highENotes[HighE4] : "";
            HighE5 = (!string.IsNullOrWhiteSpace(HighE5)) ? noteReference.highENotes[HighE5] : "";
            HighE6 = (!string.IsNullOrWhiteSpace(HighE6)) ? noteReference.highENotes[HighE6] : "";
            HighE7 = (!string.IsNullOrWhiteSpace(HighE7)) ? noteReference.highENotes[HighE7] : "";
            HighE8 = (!string.IsNullOrWhiteSpace(HighE8)) ? noteReference.highENotes[HighE8] : "";
            HighE9 = (!string.IsNullOrWhiteSpace(HighE9)) ? noteReference.highENotes[HighE9] : "";
            HighE10 = (!string.IsNullOrWhiteSpace(HighE10)) ? noteReference.highENotes[HighE10] : "";
        }

        private string ValidateInput(string setterValue)
        {
            if (Setter != "dictionary")
            {
                if (Int32.TryParse(setterValue, out var valueAsInt))
                {
                    if (valueAsInt >= 0 && valueAsInt <= 24)
                    {
                        return setterValue;
                    }

                    else
                    {
                        MessageBox.Show("It only goes up ti 24 frets, arsehole!", "Impudent Bastard", MessageBoxButton.OK, MessageBoxImage.Error);
                        return "";
                    }
                }

                else
                {
                    MessageBox.Show($"Hiv ye ivver seen \"{setterValue}\" written in tab before?? No?? Well ye winna see it here either, arsehole! GET IT SORTED!!!", "Impudent Bastard", MessageBoxButton.OK, MessageBoxImage.Error);
                    return "";
                }
            }

            else
            {
                return setterValue;
            }
        }

        public void ClearTextBoxes()
        {
            HighE1 = "";
            HighE2 = "";
            HighE3 = "";
            HighE4 = "";
            HighE5 = "";
            HighE6 = "";
            HighE7 = "";
            HighE8 = "";
            HighE9 = "";
            HighE10 = "";

            B1 = "";
            B2 = "";
            B3 = "";
            B4 = "";
            B5 = "";
            B6 = "";
            B7 = "";
            B8 = "";
            B9 = "";
            B10 = "";

            G1 = "";
            G2 = "";
            G3 = "";
            G4 = "";
            G5 = "";
            G6 = "";
            G7 = "";
            G8 = "";
            G9 = "";
            G10 = "";

            D1 = "";
            D2 = "";
            D3 = "";
            D4 = "";
            D5 = "";
            D6 = "";
            D7 = "";
            D8 = "";
            D9 = "";
            D10 = "";


            A1 = "";
            A2 = "";
            A3 = "";
            A4 = "";
            A5 = "";
            A6 = "";
            A7 = "";
            A8 = "";
            A9 = "";
            A10 = "";

            LowE1 = "";
            LowE2 = "";
            LowE3 = "";
            LowE4 = "";
            LowE5 = "";
            LowE6 = "";
            LowE7 = "";
            LowE8 = "";
            LowE9 = "";
            LowE10 = "";
        }
    }
}
