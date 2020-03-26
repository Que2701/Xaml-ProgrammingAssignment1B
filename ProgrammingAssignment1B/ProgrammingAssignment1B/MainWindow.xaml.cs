using System;
using System.Windows;
using System.Windows.Media;
using MarksGeneratorLibrary;

namespace ProgrammingAssignment1B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Global Variables
        private WeightsLibrary.StudentMarks studentMarks = WeightsLibrary.StudentMarks.Instance;
        private GenerateMarks generateMarks = GenerateMarks.Instance;
        private WeightsLibrary.TestWeights testWeights = WeightsLibrary.TestWeights.Instance;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Main_Window_Loaded(object sender, RoutedEventArgs e)
        {
            DisableEnableButtons(false);
        }
        private void Generate_Good_Marks_Button_Click(object sender, RoutedEventArgs e)
        {
            generateMarks.GoodMarks();
            PopulateTextBoxes();
            DisableEnableButtons(true);
        }
        private void Generate_Bad_Marks_Button_Click(object sender, RoutedEventArgs e)
        {
            generateMarks.BadMarks();
            PopulateTextBoxes();
            DisableEnableButtons(true);
        }

        private void Calculate_Marks_Button_Click(object sender, RoutedEventArgs e)
        {
            CalculatePredicate();
            ColourLabels();
            predicateResultsLabel.Content = $"Your predicate is: {studentMarks.Predicate.ToString("N2")}";
            predicateNeededLabel.Content = $"You need {100 - studentMarks.Predicate} to pass in the Exam";
        }

        private void ColourLabels()
        {
            _ = studentMarks.Predicate < 41 ? predicateResultsLabel.Foreground = Brushes.Red : predicateResultsLabel.Foreground = Brushes.Green;
        }

        private void CalculatePredicate()
        {
            studentMarks.Predicate = ((studentMarks.TermTest1 * testWeights.TermTest1) +
                                     (studentMarks.TermTest2  * testWeights.TermTest2) +
                                     (studentMarks.Practicals * testWeights.Practicals) +
                                     (studentMarks.AdditionalTests * testWeights.AdditionalTests) + 
                                     (studentMarks.Project * testWeights.Project)) ;
        }

        private void PopulateTextBoxes()
        {
            practicalTotalTextBox.Text =  studentMarks.AdditionalTests.ToString();
            term1TextBox.Text = studentMarks.TermTest1.ToString();
            term2TextBox.Text = studentMarks.TermTest2.ToString();
            additionalTextBox.Text = studentMarks.AdditionalTests.ToString();
            projectTotalTextBox.Text = studentMarks.Project.ToString();
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            SetControlDefaults();
            DisableEnableButtons(false);
        }

        private void DisableEnableButtons(bool flag)
        {
            clearButton.IsEnabled = flag;
            calculateButton.IsEnabled = flag;
        }

        private void SetControlDefaults()
        {
            practicalTotalTextBox.Text = default(string);
            term1TextBox.Text = default(string);
            term2TextBox.Text = default(string);
            additionalTextBox.Text = default(string);
            projectTotalTextBox.Text = default(string);
            predicateResultsLabel.Content = default(string);
            predicateNeededLabel.Content = default(string);
            predicateResultsLabel.Foreground = Brushes.Black;
            predicateNeededLabel.Foreground = Brushes.Black;
        }
    }
}
