public partial class MainForm : Form
{
    private Form active;
private void panelForm(Form fm)
    {
        if (active != null)
            active.Close();
        active = fm;
        fm.TopLevel = false;
        fm.FormBorderStyle = FormBorderStyle.None;
        fm.Dock = DockStyle.Fill;
        this.panel3.Controls.Add(fm);
        this.panel3.Tag = fm;
        fm.BringToFront();
        fm.Show();

    }
}
