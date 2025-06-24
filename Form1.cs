using CommonLibrary.Devices.MotionController.ThorLabs.KCube;
using CommonLibrary.Log;
using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiToMotor
{
    public partial class Form1 : Form
    {
        Logger MHLog;
        public Form1()
        {
            InitializeComponent();
            MHLog = new Logger();


            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kCubeInertialMotorCtrl1.Initialize(CommonLibrary.Settings.ChuckRotatorTypes.KCubeInertialMotor, MHLog);
            kCubeInertialMotorCtrl1.Connect(new CancellationToken());
            kCubeInertialMotorCtrl1.SetJogAcceleration(2000, true);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            kCubeInertialMotorCtrl1.Disconnect();
        }


        private void radButton1_Click(object sender, EventArgs e)
        {
            // Play the "Charge" fanfare
            playNoteF("G", 4, 0.25);
            playNoteF("C", 4, 0.25);
            playNoteF("E", 4, 0.25);
            playNoteF("G", 5, 0.75);
            playNoteF("E", 4, 0.25);
            playNoteF("G", 5, 1);
        }
        private void radButtonMultiToneTest_Click(object sender, EventArgs e)
        {
            // Play the "Charge" fanfare
            //playNoteF("G", 4, 0.25); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 3, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 3, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 3, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 3, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 3, 0.015); //1


            //playNoteF("C", 4, 0.25); //1
            playNoteF("C", 4, 0.015); //1
            playNoteF("C", 3, 0.015); //1
            playNoteF("C", 4, 0.015); //1
            playNoteF("C", 3, 0.015); //1
            playNoteF("C", 4, 0.015); //1
            playNoteF("C", 3, 0.015); //1
            playNoteF("C", 4, 0.015); //1
            playNoteF("C", 3, 0.015); //1
            playNoteF("C", 4, 0.015); //1
            playNoteF("C", 3, 0.015); //1

            //playNoteF("E", 4, 0.25); //1
            playNoteF("E", 4, 0.015); //1
            playNoteF("E", 3, 0.015); //1
            playNoteF("E", 4, 0.015); //1
            playNoteF("E", 3, 0.015); //1
            playNoteF("E", 4, 0.015); //1
            playNoteF("E", 3, 0.015); //1
            playNoteF("E", 4, 0.015); //1
            playNoteF("E", 3, 0.015); //1
            playNoteF("E", 4, 0.015); //1
            playNoteF("E", 3, 0.015); //1

            //playNoteF("G", 5, 0.75); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1



            //playNoteF("E", 4, 0.25); //1
            playNoteF("E", 4, 0.015); //1
            playNoteF("E", 3, 0.015); //1
            playNoteF("E", 4, 0.015); //1
            playNoteF("E", 3, 0.015); //1
            playNoteF("E", 4, 0.015); //1
            playNoteF("E", 3, 0.015); //1
            playNoteF("E", 4, 0.015); //1
            playNoteF("E", 3, 0.015); //1
            playNoteF("E", 4, 0.015); //1
            playNoteF("E", 3, 0.015); //1

            //playNoteF("G", 5, 1); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
            playNoteF("G", 5, 0.015); //1
            playNoteF("G", 4, 0.015); //1
        }
        private void radButton2_Click(object sender, EventArgs e)
        {
            //Play the Imperial March (Darth Vader's Theme)
            playNoteF("G", 4, 1);
            playNoteF("G", 4, 1);
            playNoteF("G", 4, 1);
            playNoteF("Eb", 4, 0.75);
            playNoteF("Bb", 4, 0.25);
            playNoteF("G", 4, 1);
            playNoteF("Eb", 4, 0.75);
            playNoteF("Bb", 4, 0.25);
            playNoteF("G", 4, 2);
            playNoteF("D", 5, 1.5);
            playNoteF("D", 5, 1.5);
            playNoteF("D", 5, 1.5);
            playNoteF("Eb", 5, 0.75);
            playNoteF("Bb", 4, 0.25);
            playNoteF("F#", 4, 1);
            playNoteF("Eb", 4, 0.75);
            playNoteF("Bb", 4, 0.25);
            playNoteF("G", 4, 2);
            playNoteF("G", 5, 1);
            playNoteF("G", 4, 0.5);
            playNoteF("G", 4, 0.5);
            playNoteF("G", 5, 1);
            playNoteF("F#", 5, 0.5);
            playNoteF("F", 5, 0.5);
            playNoteF("E", 5, 0.5);
            playNoteF("Eb", 5, 0.125);
            playNoteF("E", 5, 1.5);

            playNoteF("Ab", 4, 0.5);
            playNoteF("C#", 5, 1);
            playNoteF("C", 5, 0.5);
            playNoteF("B", 4, 0.5);
            playNoteF("Bb", 4, 0.25);
            playNoteF("A", 4, 0.5);
            playNoteF("Bb", 4, 1);

            playNoteF("Eb", 4, 0.5);
            playNoteF("F#", 4, 1);
            playNoteF("Eb", 4, 0.5);
            playNoteF("F#", 4, 0.5);
            playNoteF("Bb", 4, 1);
            playNoteF("G", 4, 0.5);
            playNoteF("Bb", 4, 0.5);
            playNoteF("D", 5, 2);
            playNoteF("G", 5, 1);
            playNoteF("G", 4, 0.5);
            playNoteF("G", 4, 0.5);
            playNoteF("G", 5, 1);
            playNoteF("F#", 5, 0.5);
            playNoteF("F", 5, 0.5);
            playNoteF("E", 5, 0.5);
            playNoteF("E", 5, 1);

            playNoteF("Ab", 4, 0.5);
            playNoteF("C#", 5, 1);
            playNoteF("C", 5, 0.5);
            playNoteF("B", 4, 0.5);
            playNoteF("Bb", 4, 0.25);
            playNoteF("A", 4, 0.5);
            playNoteF("Bb", 4, 1);
            playNoteF("Eb", 4, 0.25);
            playNoteF("F#", 4, 1);
            playNoteF("Eb", 4, 0.5);
            playNoteF("Bb", 4, 0.25);
            playNoteF("G", 4, 1);

        }
        private bool _stop = false;

        private async void radButton3_Click(object sender, EventArgs e)
        {
            //// Clear all checked items
            for (int i = 0; i < checkedListBoxChannels.Items.Count; i++)
            {
                checkedListBoxChannels.SetItemChecked(i, false);
            }
            Application.DoEvents();
            // 2.3.4.6
            // Check the desired items
            checkedListBoxChannels.SetItemChecked(1, true); // Item 2
            checkedListBoxChannels.SetItemChecked(2, true); // Item 3
            checkedListBoxChannels.SetItemChecked(3, true); // Item 4
            checkedListBoxChannels.SetItemChecked(5, true); // Item 6
            checkedListBoxChannels.SetItemChecked(7, true); // Item 8
            //checkedListBoxChannels.SetItemChecked(10, true); // Item 11

            //Darth Vader's Theme
            // Load the MIDI file
            var midiFile = new MidiFile(AppDomain.CurrentDomain.BaseDirectory + "\\60445.mid");
            await playMidi(midiFile);
        }
        private async void radButtonMHSTW_Click(object sender, EventArgs e)
        {
            //1,5, 6, 7
            // Clear all checked items
            for (int i = 0; i < checkedListBoxChannels.Items.Count; i++)
            {
                checkedListBoxChannels.SetItemChecked(i, false);
            }
            Application.DoEvents();
            // Check the desired items
            checkedListBoxChannels.SetItemChecked(0, true); // Item 1
            checkedListBoxChannels.SetItemChecked(4, true); // Item 5
            checkedListBoxChannels.SetItemChecked(5, true); // Item 6
            checkedListBoxChannels.SetItemChecked(6, true); // Item 7

            // Load the MIDI file "The man who sold the world"
            var midiFile = new MidiFile(AppDomain.CurrentDomain.BaseDirectory + "\\80651.mid");
            await playMidi(midiFile);
        }

        private async void radButtonHurt_Click(object sender, EventArgs e)
        {
            // Clear all checked items
            for (int i = 0; i < checkedListBoxChannels.Items.Count; i++)
            {
                checkedListBoxChannels.SetItemChecked(i, false);
            }
            Application.DoEvents();
            // Check the desired items

            checkedListBoxChannels.SetItemChecked(4, true); // Item 5
            checkedListBoxChannels.SetItemChecked(7, true); // Item 8
            checkedListBoxChannels.SetItemChecked(8, true); // Item 9


            // Load the MIDI file "The man who sold the world"
            var midiFile = new MidiFile(AppDomain.CurrentDomain.BaseDirectory + "\\LED ZEPPELIN.Stairway to heaven K.mid");
            await playMidi(midiFile);
        }
        //
        private async void radButtonFunkyTown_Click(object sender, EventArgs e)
        {
            // Clear all checked items
            //for (int i = 0; i < checkedListBoxChannels.Items.Count; i++)
            //{
            //    checkedListBoxChannels.SetItemChecked(i, false);
            //}
            Application.DoEvents();
            // Check the desired items

            checkedListBoxChannels.SetItemChecked(2, true); // Item 3
            //checkedListBoxChannels.SetItemChecked(7, true); // Item 8
            //checkedListBoxChannels.SetItemChecked(8, true); // Item 9


            // Load the MIDI file "The man who sold the world"
            var midiFile = new MidiFile(AppDomain.CurrentDomain.BaseDirectory + "\\Another-One-Bites-The-Dust-2.mid");
            await playMidi(midiFile);
        }
        private async Task playMidi(MidiFile midiFile)
        {
            _stop = false;
            label1.Text = "";

            await Task.Run(() =>
            {

                // Get the ticks per quarter note from the MIDI file
                int ticksPerQuarterNote = midiFile.DeltaTicksPerQuarterNote;

                // Define the tempo in beats per minute
                // This is a default value, actual tempo may be set in the MIDI file with a tempo event
                double tempo = 100;

                // Calculate the duration of a tick in seconds
                double tickDuration = 60.0 / (tempo * ticksPerQuarterNote);

                // Define the channel of the instrument you want to play
                int instrumentChannel = 1; // MIDI channels are 1-based


                // Create a list to store the notes
                List<Note> notes = new List<Note>();

                foreach (var track in midiFile.Events)
                {
                    foreach (var midiEvent in track)
                    {
                        if (midiEvent.CommandCode == MidiCommandCode.NoteOn)
                        {
                            var noteOnEvent = (NoteOnEvent)midiEvent;

                            // Only process the event if it's for the desired instrument
                            //if (noteOnEvent.Channel == instrumentChannel || noteOnEvent.Channel == 2 || noteOnEvent.Channel == 5 || noteOnEvent.Channel == 6)// || noteOnEvent.Channel == 7) // || noteOnEvent.Channel == 8)
                            if (checkedListBoxChannels.CheckedItems.Contains(noteOnEvent.Channel.ToString()))
                            {
                                if (noteOnEvent.OffEvent != null) // If the note has a corresponding NoteOff event
                                {
                                    string noteName = noteOnEvent.NoteName; // The name of the note (e.g., "C4")
                                    int octave = noteOnEvent.NoteNumber / 12; // - 1; // The octave of the note (e.g., 4)
                                    noteName = noteName.Replace(octave.ToString(), ""); // Remove the octave from the note name (e.g., "C"

                                    // Calculate the duration of the note in seconds
                                    double duration = (noteOnEvent.OffEvent.AbsoluteTime - noteOnEvent.AbsoluteTime) * tickDuration;
                                    if (duration > 0 && duration < 5)
                                    {
                                        // Create a new note and add it to the list
                                        notes.Add(new Note
                                        {
                                            Channel = noteOnEvent.Channel,
                                            StartTime = noteOnEvent.AbsoluteTime * tickDuration,
                                            Duration = duration,
                                            NoteName = noteName,
                                            Octave = octave
                                        });
                                    }
                                }
                            }
                            else
                            {
                                // If the event is not for the desired instrument, skip it
                                Console.WriteLine($"Skipping event for channel {noteOnEvent.Channel}");
                                continue;
                            }
                        }
                    }
                }
                // Sort the notes by start time
                notes = notes.OrderBy(n => n.StartTime).ToList();
                if (notes.Count == 0)
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        label1.Text = "No notes found";
                    }));

                    return;
                }

                // Get the start time of the first note
                double firstNoteStartTime = notes[0].StartTime;

                // If the first note's start time is greater than zero, shift all start times
                if (firstNoteStartTime > 0)
                {
                    foreach (var note in notes)
                    {
                        note.StartTime -= firstNoteStartTime;
                    }
                }

                // Play each note at the correct time
                double previousNoteEndTime = 0;
                foreach (var note in notes)
                {
                    if (_stop)
                    {
                        break;
                    }
                    // Wait until it's time to play the note
                    double waitTime = note.StartTime - previousNoteEndTime;
                    if (waitTime > 0)
                    {
                        Thread.Sleep((int)(waitTime * 1000)); // Convert wait time from seconds to milliseconds
                    }

                    // Play the note
                    Console.WriteLine($"Playing note {note.NoteName}{note.Octave} for {note.Duration:f2} seconds on Channel {note.Channel}");
                    if (kCubeInertialMotorCtrl1.GetPosition() < 100000)
                    {
                        playNoteF(note.NoteName, note.Octave, note.Duration);
                    }
                    else
                    {
                        playNoteB(note.NoteName, note.Octave, note.Duration);
                    }

                    // Update the end time of the previous note
                    previousNoteEndTime = note.StartTime + note.Duration;
                }
            });
            label1.Text = "Done";
            Application.DoEvents();
        }

        private void rbStop_Click(object sender, EventArgs e)
        {
            _stop = true;
        }
        private void playNoteF(string note, int octave, double duration)
        {
            //label1.Text = $"{note} {octave} {duration:f2}";
            BeepMotorForward(GetFrequency(note, octave), getDuration(duration));
            //Console.Beep((int)GetFrequency(note, octave), getDuration(duration));
            //Application.DoEvents();
        }
        private void playNoteB(string note, int octave, double duration)
        {
            //label1.Text = $"{note} {octave} {duration:f2}";
            BeepMotorBackword(GetFrequency(note, octave), getDuration(duration));
        }

        private int getDuration(double noteLength)
        {
            int wholeNote = 200;
            return (int)(wholeNote * noteLength);
        }

        public double GetFrequency(string note, int octave)
        {
            // Define the base frequencies for each note in the 4th octave
            var baseFrequencies = new Dictionary<string, double>
            {
                {"C", 261.63},
                {"C#", 277.18},
                {"Db", 277.18},
                {"D", 293.66},
                {"D#", 311.13},
                {"Eb", 311.13},
                {"E", 329.63},
                {"F", 349.23},
                {"F#", 369.99},
                {"Gb", 369.99},
                {"G", 392.00},
                {"G#", 415.30},
                {"Ab", 415.30},
                {"A", 440.00},
                {"A#", 466.16},
                {"Bb", 466.16},
                {"B", 493.88}
            };

            // Get the base frequency for the given note
            if (!baseFrequencies.TryGetValue(note, out var baseFrequency))
            {
                throw new ArgumentException($"Invalid note: {note}");
            }

            // Calculate the frequency for the given octave
            var frequency = baseFrequency * Math.Pow(2, octave - 4);

            return frequency;
        }

        private void BeepMotorForward(double frequency, int duration)
        {
            kCubeInertialMotorCtrl1.SetJogRate((int)frequency,false);
            kCubeInertialMotorCtrl1.SetJogStepSizeForward(duration,false);
            
            kCubeInertialMotorCtrl1.JogForward(8000);
        }
        private void BeepMotorBackword(double frequency, int duration)
        {
            kCubeInertialMotorCtrl1.SetJogRate((int)frequency, false);
            kCubeInertialMotorCtrl1.SetJogStepSizeBackward(duration, false);
            //kCubeInertialMotorCtrl1.SetSetting(false);
            kCubeInertialMotorCtrl1.JogBackward(8000);
        }


    }

    public class Note
    {
        public int Channel { get; set; }
        public double StartTime { get; set; }
        public double Duration { get; set; }
        public string NoteName { get; set; }
        public int Octave { get; set; }
    }
}
