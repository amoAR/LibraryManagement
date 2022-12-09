using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace library
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            timerTimeNow.Enabled = true;
        }        

        public static class Globals
        {
            private const int num = 10;
            public static string[] userRegistrationCode = new string[num];
            public static string[] userFirstName        = new string[num];
            public static string[] userLastName         = new string[num];
            public static string[] userNationalCode     = new string[num];
            public static string[] userTel              = new string[num];
            public static string[] userAddress          = new string[num];
            public static string[] userAvatar           = new string[num];

            public static string[] BookName             = new string[num];
            public static string[] BookAuthor           = new string[num];
            public static string[] BookTranslator       = new string[num];
            public static string[] BookPublisher        = new string[num];
            public static string[] BookReleaseYear      = new string[num];
            public static string[] BookSubject          = new string[num];
            public static string[] BookISBN             = new string[num];
            public static string[] BookPic              = new string[num];
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            DirectoryInfo resource = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Avatars\\");
            foreach (FileInfo f in resource.GetFiles())
                f.Delete();
            resource = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Books\\");
            foreach (FileInfo f in resource.GetFiles())
                f.Delete();
            Application.Exit();
        }

        private bool mouseDown;
        private Point lastLocation;
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Other_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                lblTitle.Focus();            
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Label[] labels = { lblMenuSearch, lblMenuMembers, lblMenuBooks };
            Panel[] panels = { pnlSearch, pnlMembers, pnlBooks };            
            Label lbl = (Label)sender;            
            foreach (Label l in labels)
            {
                if (l.Name != lbl.Name)
                {
                    l.BackColor = DefaultBackColor;
                    panels[Array.IndexOf(labels, l)].Visible = false;
                }
                else
                {
                    l.BackColor = Color.LightSkyBlue;
                    panels[Array.IndexOf(labels, l)].Visible = true;
                }
            }
            switch (lbl.Name)
            {
                case "lblMenuMembers":
                    Image RoundedImage = this.RoundCorners(Image.FromFile(Environment.CurrentDirectory + "\\resources\\defaultAvatar.png"), 70, Color.Transparent);
                    picMembersUser.InitialImage = RoundedImage;
                    picMembersUser.Image = picMembersUser.InitialImage;
                    string resourcesPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Avatars";
                    if (!Directory.Exists(resourcesPath))
                        Directory.CreateDirectory(resourcesPath);
                    break;

                case "lblMenuBooks":
                    RoundedImage = this.RoundCorners(Image.FromFile(Environment.CurrentDirectory + "\\resources\\defaultBook.png"), 70, Color.Transparent);
                    picBooks.InitialImage = RoundedImage;
                    picBooks.Image = picBooks.InitialImage;
                    resourcesPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Books";
                    if (!Directory.Exists(resourcesPath))
                        Directory.CreateDirectory(resourcesPath);
                    break;
            }
        }

        private void GetCheckedrdo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            SearchField_visibleChanged(rdo);
        }

        private void SearchField_visibleChanged(RadioButton r)
        {
            Label[] lbl = { lblSearchBookName, lblSearchAuthorName, lblSearchSubject, lblSearchReleaseYear };
            TextBox[] txt = { txtSearchBookName, txtSearchAuthorName, txtSearchSubject, txtSearchReleaseYear };
            foreach (Label l in lbl)
            {
                if (r.Name.Substring(9) != l.Name.Substring(9))
                {
                    l.Visible = false;
                    txt[Array.IndexOf(lbl, l)].Clear();
                    txt[Array.IndexOf(lbl, l)].Visible = false;
                }
                else
                {
                    l.Visible = true;
                    l.Location = new Point(574, 217);
                    int i = Array.IndexOf(lbl, l);
                    txt[i].Visible = true;
                    switch (txt[i].Name)
                    {
                        case "txtSearchSubject":
                            txt[i].Location = new Point(258, 214);
                            break;
                        case "txtSearchReleaseYear":
                            txt[i].Location = new Point(414, 214);
                            break;
                        default:
                            txt[i].Location = new Point(143, 214);
                            break;
                    }                    
                }
            }            
        }

        private void TXTField_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;            
            CheckPaddingTXT(txt);
            txt.SelectionStart = txt.TextLength;
        }

        private void TXTField_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CheckPaddingTXT(txt);
        }

        private void CheckPaddingTXT(TextBox t)
        {
            string space = "          ";
            if (t.TextLength < 10)
                t.Text = space + t.Text;
            else
            {
                string result = t.Text.Substring(0, 10);
                if (result != space)
                    t.Text = space + t.Text;
            }
        }

        bool IsEnglishCharacter(char ch)
        {
            if (ch >= 97 && ch <= 122 || ch >= 65 && ch <= 90)
                return true;
            else
                return false;
        }

        private void TXTFieldWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar);
            if (IsEnglishCharacter(e.KeyChar))
            {
                MessageBox_Warning("!لطفا فارسی تایپ کنید");
                e.Handled = true;
            }
        }

        private void TXTField_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CheckCompeleteFieldes(txt);
            if (txt.TextLength >= 13)
                txt.BackColor = Color.Honeydew;
            else
                txt.BackColor = Color.MistyRose;
        }

        private void CheckCompeleteFieldes(TextBox t)
        {
            if (t.TextLength > 10 && t.Text.Substring(10) != " ")
            {
                btnSearch.Enabled = true;
                btnSearchDel.Enabled = true;
            }
            else if (t.TextLength > 10)
            {
                btnSearchDel.Enabled = true;
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = false;
                btnSearchDel.Enabled = false;
            }
        }

        private void txtReleaseDate_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchReleaseYear.TextLength == 4)
            {
                btnSearch.Enabled = true;
                btnSearchDel.Enabled = true;
            }
            else if (txtSearchReleaseYear.TextLength > 0)
            {
                btnSearchDel.Enabled = true;
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = false;
                btnSearchDel.Enabled = false;
            }
        }

        private void TXTFieldNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            TextBox[] txt = { txtSearchBookName, txtSearchAuthorName, txtSearchSubject, txtSearchReleaseYear };
            for (byte i = 0; i < txt.Length; i++)
                txt[i].Clear();
            lblTitle.Focus();
        }

        private int oldLength, newLength;
        private void CharCounter_Enter(object sender, EventArgs e)
        {
            oldLength = 0;
            newLength = 0;
        }

        private void CharCounter_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            CharCounter(txt);
        }

        private void CharCounter(TextBox t)
        {
            string[] str = { "lblMembersCharCountRegistrationCode", "lblMembersCharCountNationalCode", "lblMembersCharCountTel" };
            Label[] lbl = { lblMembersCharCountRegistrationCode, lblMembersCharCountNationalCode, lblMembersCharCountTel };
            int lblNumber = Array.IndexOf(str, "lblMembersCharCount" + t.Name.Substring(10));
            newLength = t.TextLength;
            if (newLength == oldLength)
                goto Result;
            else if (newLength > oldLength)
                oldLength = newLength;
            else
                oldLength--;
            Result:            
            CharCounterGetLength(lbl, lblNumber);            
            if (t.TextLength == t.MaxLength)
            {
                lbl[lblNumber].ForeColor = Color.DarkGreen;
                t.BackColor = Color.Honeydew;
            }
            else
            {
                lbl[lblNumber].ForeColor = Color.Black;
                t.BackColor = Color.MistyRose;
            }                
        }

        private void CharCounterGetLength(Label[] l, int lNum)
        {
            int length = l[lNum].Text.Split('/').First().Length;
            if (length == 1)
                l[lNum].Text = oldLength.ToString() + l[lNum].Text.Substring(1);
            else
                l[lNum].Text = oldLength.ToString() + l[lNum].Text.Substring(2);            
        }

        private void btnImportPic_Click(object sender, EventArgs e)
        {            
            if (ofdPic.ShowDialog() == DialogResult.OK)
                RoundAvatar(Image.FromFile(ofdPic.FileName));
            if (pnlMembers.Visible)
                picMembersUser.Image = RoundedImage;
            else
                picBooks.Image = RoundedImage;
        }

        private Image RoundCorners(Image StartImage, int CornerRadius, Color BackgroundColor)
        {
            CornerRadius *= 2;
            Bitmap RoundedImage = new Bitmap(StartImage.Width, StartImage.Height);
            using (Graphics g = Graphics.FromImage(RoundedImage))
            {
                g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Brush brush = new TextureBrush(StartImage);
                GraphicsPath gp = new GraphicsPath();
                gp.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                gp.AddArc(0, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                g.FillPath(brush, gp);
                return RoundedImage;
            }
        }

        private int picCount;
        private void CounterPic()
        {
            DirectoryInfo resourcesPath;
            if (pnlMembers.Visible)
                resourcesPath = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Avatars\\");
            else
                resourcesPath = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Books\\");
            picCount = resourcesPath.GetFiles().Count();
        }        

        private void btnImportPic_MouseHover(object sender, EventArgs e)
        {
            tipImportPic.SetToolTip(picMembersUser, "درج تصویر");
        }

        private void btnSubmitForm_Click(object sender, EventArgs e)
        {                  
            bool correct = true;
            TextBox[] txt = { txtMembersRegistrationCode, txtMembersFirstName, txtMembersLastName, txtMembersNationalCode, txtMembersTel };            
            foreach (TextBox t in txt)
            {
                if (t.BackColor != Color.Honeydew)
                    correct = false;
            }
            if (correct)
            {
                if (rtbMembersAddress.BackColor == Color.Honeydew)
                {
                    if (picMembersUser.Image != picMembersUser.InitialImage)
                    {
                        Array[] arr = { Globals.userRegistrationCode, Globals.userFirstName, Globals.userLastName, Globals.userNationalCode, Globals.userTel };
                        SubmitPic();
                        foreach (TextBox t in txt)
                            arr[Array.IndexOf(txt, t)].SetValue(t.Text, picCount);
                        Globals.userAddress.SetValue(rtbMembersAddress.Text, picCount);                        
                        MessageBox.Show("کاربر باموفقیت اضافه شد", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnMembersNewForm.PerformClick();                                                
                    }
                    else
                        MessageBox_Warning("لطفا یک آواتار تعریف کنید");
                }
                else
                    MessageBox_Warning("لطفا یک آدرس معتبر وارد کنید");
            }
            else
                MessageBox_Warning("لطفا همه فیلدها را تکمیل کنید");            
        }

        private void MessageBox_Warning(string text)
        {
            text = "!" + text;
            MessageBox.Show(text, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SubmitPic()
        {
            string resourcesPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            string fileName = ofdPic.SafeFileName;
            string fileExt = Path.GetExtension(ofdPic.FileName);
            string filePath = ofdPic.FileName;
            CounterPic();
            if (pnlMembers.Visible)
            {
                resourcesPath += "Avatars\\";
                string imgPath = resourcesPath + "Avatar" + picCount.ToString() + ".png";
                if (fileExt == ".jpg")
                {
                    Bitmap b = new Bitmap(filePath);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        b.Save(imgPath, ImageFormat.Png);
                        ms.Close();
                    }
                }
                else
                {
                    File.Copy(filePath, resourcesPath + fileName);
                    File.Move(resourcesPath + fileName, imgPath);
                }
                Globals.userAvatar[picCount] = imgPath;
            }
            else
            {
                resourcesPath += "Books\\";
                string imgPath = resourcesPath + "Book" + picCount.ToString() + ".png";
                if (fileExt == ".jpg")
                {
                    Bitmap b = new Bitmap(filePath);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        b.Save(imgPath, ImageFormat.Png);
                        ms.Close();
                    }
                }
                else
                {
                    File.Copy(filePath, resourcesPath + fileName);
                    File.Move(resourcesPath + fileName, imgPath);
                }
                Globals.BookPic[picCount] = imgPath;
            }
        }

        private void TXTFieldWordNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex pattern = new Regex(@"[\W_-[\s\b\u002D]]");
            e.Handled = pattern.IsMatch(e.KeyChar.ToString());            
            if (IsEnglishCharacter(e.KeyChar))
            {
                MessageBox_Warning("لطفا فارسی تایپ کنید");
                e.Handled = true;
            }
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            TextBox[] txt = { txtMembersRegistrationCode, txtMembersFirstName, txtMembersLastName, txtMembersNationalCode, txtMembersTel };
            foreach (TextBox t in txt)
            {
                t.Clear();
                t.BackColor = Color.WhiteSmoke;
            }                
            Label[] lbl = { lblMembersCharCountRegistrationCode, lblMembersCharCountNationalCode, lblMembersCharCountTel };
            foreach (Label l in lbl)
            {
                oldLength = 0;
                CharCounterGetLength(lbl, Array.IndexOf(lbl, l));                
            }
            rtbMembersAddress.Clear();
            pnlMembersRTBBorder.BackColor = Color.WhiteSmoke;
            rtbMembersAddress.BackColor   = Color.WhiteSmoke;
            picMembersUser.Image = picMembersUser.InitialImage;
        }

        private void timerTimeNow_Tick(object sender, EventArgs e)
        {
            lblTitle.Text = "برنامه کتابخانه   |   " + DateTime.Now.ToString("yyyy/MM/dd   H:mm:ss  tt");
        }

        private void txtBooksReleaseYear_TextChanged(object sender, EventArgs e)
        {
            if (txtBooksReleaseYear.TextLength == txtBooksReleaseYear.MaxLength)
                txtBooksReleaseYear.BackColor = Color.Honeydew;
            else
                txtBooksReleaseYear.BackColor = Color.MistyRose;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            rdoSearchBookName.Checked = true;
        }

        private void rtbMembersAddress_TextChanged(object sender, EventArgs e)
        {
            if (rtbMembersAddress.TextLength >= 13)
            {
                pnlMembersRTBBorder.BackColor = Color.Honeydew;
                rtbMembersAddress.BackColor = Color.Honeydew;
            }
            else
            {
                pnlMembersRTBBorder.BackColor = Color.MistyRose;
                rtbMembersAddress.BackColor = Color.MistyRose;
            }
        }

        private void txtBooksISBN_Leave(object sender, EventArgs e)
        {
            if (txtBooksISBN.TextLength == 13)
            {
                txtBooksISBN.Text = txtBooksISBN.Text.Substring(0, 3) + "-" + txtBooksISBN.Text.Substring(3, 1) + "-" + txtBooksISBN.Text.Substring(4, 2) + "-" + txtBooksISBN.Text.Substring(6, 6) + "-" + txtBooksISBN.Text.Substring(12);
                txtBooksISBN.BackColor = Color.Honeydew;
            }
            else
                txtBooksISBN.BackColor = Color.MistyRose;
        }

        private void cboBooksSubject_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                lblBooksSubject.Focus();
            cboBooksSubject.DroppedDown = true;
        }

        private void cboBooksSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlBooksCBOBorder.BackColor = Color.Honeydew;
            cboBooksSubject.BackColor = Color.Honeydew;
            lblBooksSubject.Focus();
        }

        private void cboBooksSubject_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cboBooksSubject_DropDown(object sender, EventArgs e)
        {
            cboBooksSubject.DroppedDown = true;
        }

        Image RoundedImage;

        private void btnBooksNewForm_Click(object sender, EventArgs e)
        {
            TextBox[] txt = { txtBooksName, txtBooksAuthor, txtBooksTranslator, txtBooksPublisher, txtBooksReleaseYear, txtBooksISBN };
            foreach (TextBox t in txt)
            {
                t.Clear();
                t.BackColor = Color.WhiteSmoke;
            }
            cboBooksSubject.Text = "انتخاب کنید";
            pnlBooksCBOBorder.BackColor = Color.WhiteSmoke;
            cboBooksSubject.BackColor   = Color.WhiteSmoke;            
            picBooks.Image = picBooks.InitialImage;
        }

        private void btnBooksSubmitForm_Click(object sender, EventArgs e)
        {
            bool correct = true;
            TextBox[] txt = { txtBooksName, txtBooksAuthor, txtBooksTranslator, txtBooksPublisher, txtBooksReleaseYear, txtBooksISBN };
            foreach (TextBox t in txt)
            {
                if (t.BackColor != Color.Honeydew)
                    correct = false;
            }
            if (correct)
            {
                if (cboBooksSubject.BackColor == Color.Honeydew)
                {
                    if (picBooks.Image != picBooks.InitialImage)
                    {
                        Array[] arr = { Globals.BookName, Globals.BookAuthor, Globals.BookTranslator, Globals.BookPublisher, Globals.BookReleaseYear, Globals.BookISBN };
                        SubmitPic();
                        foreach (TextBox t in txt)
                            arr[Array.IndexOf(txt, t)].SetValue(t.Text, picCount);
                        Globals.BookSubject.SetValue(cboBooksSubject.Text, picCount);
                        MessageBox.Show("کتاب باموفقیت اضافه شد", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBooksNewForm.PerformClick();                        
                    }
                    else
                        MessageBox_Warning("لطفا یک تصویر تعریف کنید");
                }
                else
                    MessageBox_Warning("لطفا یک موضوع انتخاب کنید");
            }
            else
                MessageBox_Warning("لطفا همه فیلدها را تکمیل کنید");
        }

        private void btnSearchLoginAdmin_Click(object sender, EventArgs e)
        {
            Form login = new FormLogin();
            login.ShowDialog();
        }

        public void RoundAvatar(Image pic)
        {
            RoundedImage = this.RoundCorners(pic, 70, Color.Transparent);            
        }
    }
}