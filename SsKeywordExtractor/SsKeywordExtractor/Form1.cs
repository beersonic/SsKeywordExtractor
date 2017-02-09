using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SsKeywordExtractor
{
    enum Status
    {
        Ready,
        Working,
    }

    public partial class Form1 : Form
    {
        class Result
        {
            public String keywords;
            public String title;
        }

        Object m_lockResult = new object();
        String m_urlToBeProcessed = "";
        String m_regexPatternKeyword = "";
        String m_regexPatternTitle = "";
        Result m_result = null;
        bool m_isDone = false;
        Status m_status = Status.Ready;

        public Form1()
        {
            InitializeComponent();

            m_regexPatternKeyword = textBoxRegexKeyword.Text;
            m_regexPatternTitle = textBoxRegexTitle.Text;
            backgroundWorker1.RunWorkerAsync();
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            string url = textBoxURL.Text;
            if (url == "")
            {
                richTextBoxKeyword.Clear();
            }
            else
            {
                lock (m_urlToBeProcessed)
                {
                    m_urlToBeProcessed = url;
                }
            }
        }

        private Result ExtractTitleAndKeyword(string htmlData)
        {
            Result result = new Result();

            List<String> keywords = new List<string>();
            String title = "";

            Regex rxKeyword = new Regex(m_regexPatternKeyword);
            Regex rxTitle = new Regex(m_regexPatternTitle);
            StringReader sr = new StringReader(htmlData);
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                {
                    break;
                }

                Match sm = rxKeyword.Match(line);
                if (sm.Success)
                {
                    keywords.Add(sm.Groups[1].ToString());
                }

                sm = rxTitle.Match(line);

                if (sm.Success)
                {
                    title = sm.Groups[1].ToString();
                }               
            }

            string keywordStr = "";
            foreach (string k in keywords)
            {
                keywordStr += k + ";";
            }

            result.keywords = keywordStr;
            result.title = title;
            return result;
        }

        private String ReadHtmlFromUrl(string url)
        {
            String data = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }
            return data;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(!m_isDone)
            {
                m_status = Status.Ready;

                String urlToBeProcessed = "";
                lock(m_urlToBeProcessed)
                {
                    if (m_urlToBeProcessed != "")
                    {
                        urlToBeProcessed = m_urlToBeProcessed;
                        m_urlToBeProcessed = "";
                    }
                }

                if (urlToBeProcessed != "")
                {
                    m_status = Status.Working;
                    String htmlData = ReadHtmlFromUrl(urlToBeProcessed);
                    Result result = ExtractTitleAndKeyword(htmlData);
                    
                    lock(m_lockResult)
                    {
                        m_result = result;
                    }
                }
            }
        }

        private void textBoxRegex_TextChanged(object sender, EventArgs e)
        {
            lock(m_regexPatternKeyword)
            {
                m_regexPatternKeyword = textBoxRegexKeyword.Text;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lock (m_lockResult)
            {
                if (m_result != null)
                {
                    richTextBoxKeyword.Text = m_result.keywords;
                    richTextBoxTitle.Text = m_result.title;        
                    m_result = null;
                }
            }

            textBoxStatus.Text = m_status.ToString();

            textBoxRegexKeyword.Enabled = (m_status == Status.Ready);
            textBoxURL.Enabled = (m_status == Status.Ready);
            textBoxRegexTitle.Enabled = (m_status == Status.Ready);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_isDone = true;
        }
    }
}
