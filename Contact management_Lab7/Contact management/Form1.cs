namespace Contact_management
{
    public partial class Form1 : Form
    {
        List<Contact> contacts = new List<Contact>();
        public Form1()
        {
            InitializeComponent();
            listViewContact.View = View.Details;
            listViewContact.LabelEdit = true;
            listViewContact.AllowColumnReorder = true;
            listViewContact.FullRowSelect = true;
            listViewContact.GridLines = true;
            listViewContact.Sorting = SortOrder.Ascending;

            listViewContact.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listViewContact.Columns.Add("First name", -2, HorizontalAlignment.Left);
            listViewContact.Columns.Add("Last name", -2, HorizontalAlignment.Left);
            listViewContact.Columns.Add("Phone", -2, HorizontalAlignment.Left);
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            string Firstname = textBoxFirstName.Text;
            string Lastname = textBoxLastName.Text;
            string Phone = textBoxPhone.Text;
            contacts.Add(new Contact(Firstname, Lastname, Phone));
            NewListView();
        }

        private void NewListView()
        {
            listViewContact.Items.Clear();
            List<ListViewItem> ListItem = new List<ListViewItem>();
            int Index = 0;
            foreach (Contact contact in contacts)
            {
                ListViewItem item = new ListViewItem(Index + "", Index);

                Random random = new Random();
                item.SubItems.Add(contact.FirstName);
                item.SubItems.Add(contact.LastName);
                item.SubItems.Add(contact.Phone);
                ListItem.Add(item);
                Index++;
            }
            listViewContact.Items.AddRange(ListItem.ToArray());
        }



        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        private void buttonSoft_Click(object sender, EventArgs e)
        {
            contacts.Sort((a, b) => (a.FirstName).CompareTo(b.FirstName));
            listViewContact.Items.Clear();
            List<ListViewItem> ListItems = new List<ListViewItem>();
            int Index = 0;
            foreach(Contact contact in contacts)
            {
                ListViewItem items = new ListViewItem(Index + "", Index);
                items.SubItems.Add(contact.FirstName);
                items.SubItems.Add(contact.LastName);
                items.SubItems.Add(contact.Phone);
                ListItems.Add(items);
                Index++;
            }
            listViewContact.Items.AddRange(ListItems.ToArray());
        }
    }
    internal class Contact
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }

        public Contact(string firstname, string lastname, string phone)
        {
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
        }
    }
}
