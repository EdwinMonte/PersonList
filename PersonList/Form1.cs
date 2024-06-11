namespace PersonList
{
    public partial class Form1 : Form
    {
        private List<Person> people = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = (int)numAge.Value;
            people.Add(new Person { Name = name, Age = age });
            listBoxPeople.Items.Add($"{name}, {age} años");
            txtName.Clear();
            numAge.Value = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;
                    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    using (BinaryWriter writer = new BinaryWriter(fs))
                    {
                        writer.Write(people.Count);
                        foreach (var person in people)
                        {
                            writer.Write(person.Name);
                            writer.Write(person.Age);
                        }
                    }
                    MessageBox.Show("Lista guardada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la lista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    using (BinaryReader reader = new BinaryReader(fs))
                    {
                        people.Clear();
                        listBoxPeople.Items.Clear();
                        int count = reader.ReadInt32();
                        for (int i = 0; i < count; i++)
                        {
                            string name = reader.ReadString();
                            int age = reader.ReadInt32();
                            people.Add(new Person { Name = name, Age = age });
                            listBoxPeople.Items.Add($"{name}, {age} años");
                        }
                    }
                    MessageBox.Show("Lista cargada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

