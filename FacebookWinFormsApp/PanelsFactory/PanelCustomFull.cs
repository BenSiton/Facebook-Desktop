using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace FacebookApp.PanelsFactory
{
    public class PanelCustomFull : PanelCustom
    {
        public Point NameLocation => new Point(4, 145);

    public Point EmailLocation => new Point(4, 165);

    public Point GenderLocation => new Point(4, 185);

    public Point BirthdayLocation => new Point(4, 205);

    public Point CityLocation => new Point(4, 225);

    public PanelCustomFull()
    {
        initializeComponent();
        UserBindingSource.DataSource = SingletonUser.FacebookUser;
        GenderProxyBindingSource.DataSource = new GenderProxy();
        CityBindingSource.DataSource = SingletonUser.FacebookUser.Location;
    }

    private void initializeComponent()
    {
        this.panel1 = new Panel();
        this.label5 = new Label();
        this.nameLabel2 = new Label();
        this.CityBindingSource = new BindingSource();
        this.label6 = new Label();
        this.genderLabel1 = new Label();
        this.GenderProxyBindingSource = new BindingSource();
        this.birthdayLabel1 = new Label();
        this.UserBindingSource = new BindingSource();
        this.label4 = new Label();
        this.label2 = new Label();
        this.label1 = new Label();
        this.imageNormalPictureBox = new PictureBox();
        this.emailLabel1 = new Label();
        this.nameLabel1 = new Label();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.CityBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.GenderProxyBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.UserBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.imageNormalPictureBox).BeginInit();
        this.SuspendLayout();

        this.panel1.Controls.Add(this.label5);
        this.panel1.Controls.Add(this.imageNormalPictureBox);
        this.panel1.Controls.Add(this.nameLabel1);
        this.panel1.Controls.Add(this.nameLabel2);
        this.panel1.Controls.Add(this.genderLabel1);
        this.panel1.Controls.Add(this.label4);
        this.panel1.Controls.Add(this.label6);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.emailLabel1);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.birthdayLabel1);
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.AutoSize = true;
        this.panel1.TabIndex = 0;

        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)177);
        this.label5.Location = new System.Drawing.Point(BirthdayLocation.X, BirthdayLocation.Y);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(93, 22);
        this.label5.TabIndex = 73;
        this.label5.Text = "BirthDay:";

        this.nameLabel2.DataBindings.Add(new Binding("Text", this.CityBindingSource, "Name", true));
        this.nameLabel2.Location = new System.Drawing.Point(CityLocation.X + TabValue, CityLocation.Y);
        this.nameLabel2.Name = "nameLabel2";
        this.nameLabel2.Size = new System.Drawing.Size(93, 22);
        this.nameLabel2.TabIndex = 2;
        this.nameLabel2.Text = "label3";

        this.CityBindingSource.DataSource = typeof(City);

        this.label6.AutoSize = true;
        this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)177);
        this.label6.Location = new System.Drawing.Point(CityLocation.X, CityLocation.Y);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(92, 22);
        this.label6.TabIndex = 71;
        this.label6.Text = "Location:";

        this.genderLabel1.DataBindings.Add(new Binding("Text", this.GenderProxyBindingSource, "Gender", true));
        this.genderLabel1.Location = new System.Drawing.Point(GenderLocation.X + TabValue, GenderLocation.Y);
        this.genderLabel1.Name = "genderLabel1";
        this.genderLabel1.Size = new System.Drawing.Size(93, 22);
        this.genderLabel1.TabIndex = 10;
        this.genderLabel1.Text = "label1";

        this.GenderProxyBindingSource.DataSource = typeof(GenderProxy);

        this.birthdayLabel1.DataBindings.Add(new Binding("Text", this.UserBindingSource, "Birthday", true));
        this.birthdayLabel1.Location = new System.Drawing.Point(BirthdayLocation.X + TabValue, BirthdayLocation.Y);
        this.birthdayLabel1.Name = "birthdayLabel1";
        this.birthdayLabel1.Size = new System.Drawing.Size(93, 22);
        this.birthdayLabel1.TabIndex = 3;
        this.birthdayLabel1.Text = "label1";

        this.UserBindingSource.DataSource = typeof(User);

        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)177);
        this.label4.Location = new System.Drawing.Point(GenderLocation.X, GenderLocation.Y);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(82, 22);
        this.label4.TabIndex = 75;
        this.label4.Text = "Gender:";

        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)177);
        this.label2.Location = new System.Drawing.Point(EmailLocation.X, EmailLocation.Y);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(65, 22);
        this.label2.TabIndex = 77;
        this.label2.Text = "Email:";

        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)177);
        this.label1.Location = new System.Drawing.Point(NameLocation.X, NameLocation.Y);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(67, 22);
        this.label1.TabIndex = 79;
        this.label1.Text = "Name:";

        this.imageNormalPictureBox.DataBindings.Add(new Binding("Image", this.UserBindingSource, "ImageNormal", true));
        this.imageNormalPictureBox.AutoSize = false;
        this.imageNormalPictureBox.Location = new System.Drawing.Point(3, 0);
        this.imageNormalPictureBox.Name = "imageNormalPictureBox";
        this.imageNormalPictureBox.Size = new System.Drawing.Size(140, 140);
        this.imageNormalPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        this.imageNormalPictureBox.TabIndex = 7;
        this.imageNormalPictureBox.TabStop = false;

        this.emailLabel1.DataBindings.Add(new Binding("Text", this.UserBindingSource, "Email", true));
        this.emailLabel1.Location = new System.Drawing.Point(EmailLocation.X + TabValue, EmailLocation.Y);
        this.emailLabel1.Name = "emailLabel1";
        this.emailLabel1.Size = new System.Drawing.Size(93, 22);
        this.emailLabel1.TabIndex = 5;
        this.emailLabel1.Text = "label1";

        this.nameLabel1.DataBindings.Add(new Binding("Text", this.UserBindingSource, "Name", true));
        this.nameLabel1.Location = new System.Drawing.Point(NameLocation.X + TabValue, NameLocation.Y);
        this.nameLabel1.Name = "nameLabel1";
        this.nameLabel1.Size = new System.Drawing.Size(93, 22);
        this.nameLabel1.TabIndex = 9;
        this.nameLabel1.Text = "label1";

        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.panel1);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.CityBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.GenderProxyBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.UserBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.imageNormalPictureBox).EndInit();
        this.ResumeLayout(false);
    }

    public int TabValue => 70;

    private Panel panel1;
    private Label birthdayLabel1;
    private PictureBox imageNormalPictureBox;
    private Label emailLabel1;
    private Label nameLabel1;
    private Label genderLabel1;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label2;
    private Label label1;
    private Label nameLabel2;
}
}
