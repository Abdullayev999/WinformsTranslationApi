using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TranslationWinForm
{
    public partial class MainForm : Form
    {
        private WebClient Web { get; set; }
        public string url { get; set; }
        private TranslateRequest Translate { get; set; }
        private List<string> List { get; set; }
        public MainForm()
        {
            InitializeComponent();
            
            Web = new WebClient();
            List=new List<string>()
            {
                "en",
                "az",
                "tr"
            };
            url= "https://translation.googleapis.com/language/translate/v2?key=AIzaSyCqwaXLLd9JraElDHNGKFIN2zfbSAgAHms";

            withComboBox.Items.AddRange(List.ToArray());
            toComboBox.Items.AddRange(List.ToArray());
        }

        private void withTextBox_TextChanged(object sender, EventArgs e)
        {
            if (withComboBox.SelectedItem == null) MessageBox.Show("You not selected  language with ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else if (toComboBox.SelectedItem == null) MessageBox.Show("You not selected  language to", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {

                    Translate = new TranslateRequest()
                    {
                        source = withComboBox.SelectedItem.ToString(), target = toComboBox.SelectedItem.ToString(),
                        format = "text"
                    };
                    Translate.q = withTextBox.Text;

                    string answerUploadString = Web.UploadString(url, JsonConvert.SerializeObject(Translate));
                    var resulTranslateResponse = JsonConvert.DeserializeObject<TranslateResponse>(answerUploadString);

                    toTextBox.Text = resulTranslateResponse.data.translations[0].translatedText;
                }
                catch (Exception Exception)
                {
                 //   MessageBox.Show(Exception.Message);  kajdiy raz vivodid soobwenie ne sootvetsvuet realnosti Translate Google
                }
            }


           
        }
    }
}
