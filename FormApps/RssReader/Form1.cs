using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemData> items;

        Dictionary<string, string> rssUrlDict = new Dictionary<string, string>() {
            {"IT","https://news.yahoo.co.jp/rss/categories/it.xml" },
            {"���C�t","https://news.yahoo.co.jp/rss/categories/life.xml" },
            {"�o��","https://news.yahoo.co.jp/rss/categories/business.xml" },
            {"�G���^��","https://news.yahoo.co.jp/rss/categories/entertainment.xml" },
        };




        public Form1() {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e) {
            cbUrl.DataSource = rssUrlDict.Select(k => k.Key).ToList();
        }

        private async void btRssGet_Click(object sender, EventArgs e) {

            using (var hc = new HttpClient()) {

                string xml = await hc.GetStringAsync(getRssUrl(cbUrl.Text));
                XDocument xdoc = XDocument.Parse(xml);

                //RSS����͂��ĕK�v�ȗv�f���擾
                items = xdoc.Root.Descendants("item")
                    .Select(x =>
                        new ItemData {
                            Title = (string?)x.Element("title"),
                            Link = (string?)x.Element("link"),
                        }).ToList();


                //���X�g�{�b�N�X�փ^�C�g����\��
                lbTitles.Items.Clear();
                items.ForEach(item => lbTitles.Items.Add(item.Title ?? "�f�[�^�Ȃ�"));

            }





        }
        //�R���{�{�b�N�X�̕�������`�F�b�N���ăA�N�Z�X�\��URL��Ԃ�
        private string getRssUrl(string str) {
            if (rssUrlDict.ContainsKey(str)) {
                return rssUrlDict[str];
            }
            return str;
        }

        //�^�C�g����I�������Ƃ��ɌĂ΂��C�x���g�n���h��
        private void webView21_Click(object sender, EventArgs e) {

            wvRssLink.Source = new Uri(items[lbTitles.SelectedIndex].Link);
        }

        private void Backpage_Click(object sender, EventArgs e) {




        }

       
    }
}
