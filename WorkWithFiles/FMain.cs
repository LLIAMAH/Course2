using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using WorkWithFiles.Forms;
using WorkWithFiles.Interfaces;

namespace WorkWithFiles
{
    public partial class FMain : Form
    {
        private int _stringLength;
        private string _data;
        private const string _folderName = "C:\\Temp\\Course";
        private const string _fileNameOld = "OldScholData.dat";
        private const string _fileNameBinary = "BinaryData.dat";
        private const string _fileNameXml = "XmlData.xml";

        public FMain()
        {
            InitializeComponent();
        }

        private void bnOldWrite_Click(object sender, EventArgs e)
        {
            var fullName = Path.Combine(_folderName, _fileNameOld);

            //var di = new DirectoryInfo(fullName);
            var fi = new FileInfo(fullName);
            //FileStream fs;
            //if (fi.Exists)
            //    fs = fi.OpenWrite();
            //else
            //    fs = fi.Create();

            using (var fs = fi.Exists ? fi.OpenWrite() : fi.Create())
            {
                var longData = 1023423523L;
                var stringData = "Some string to write into file";
                var boolData = true;
                var doubleData = 23421513425325.34523453245;

                this._stringLength = WriteData(fs, longData, stringData, boolData, doubleData);

                fs.Close();
            }
        }

        private void bnOldRead_Click(object sender, EventArgs e)
        {
            var fullName = Path.Combine(_folderName, _fileNameOld);
            var fi = new FileInfo(fullName);
            if (!fi.Exists)
            {
                MessageBox.Show("File does not exist.");
                return;
            }

            using (var fs = fi.OpenRead())
            {
                var structData = ReadData(fs, this._stringLength);

                var t = structData;
            }
        }

        private ReturnData ReadData(FileStream fs, int stringLength)
        {
            var sizeLong = sizeof(long);
            var sizeString = stringLength; // = 100;
            var sizeBool = sizeof(bool);
            var sizeDouble = sizeof(double);

            var bufferLong = new byte[sizeLong];
            var bufferString = new byte[sizeString];
            var bufferBool = new byte[sizeBool];
            var bufferDouble = new byte[sizeDouble];

            fs.Read(bufferLong);
            fs.Read(bufferString);
            fs.Read(bufferBool);
            fs.Read(bufferDouble);

            var l = BitConverter.ToInt64(bufferLong);
            var str = Encoding.ASCII.GetString(bufferString);
            var b = BitConverter.ToBoolean(bufferBool);
            var d = BitConverter.ToDouble(bufferDouble);

            return new ReturnData(l, str, b, d);
        }

        private int WriteData(FileStream fs, long longData, string stringData, bool boolData, double doubleData)
        {
            var byteLong = BitConverter.GetBytes(longData);
            var byteString = Encoding.ASCII.GetBytes(stringData);
            var byteBool = BitConverter.GetBytes(boolData);
            var byteDouble = BitConverter.GetBytes(doubleData);

            fs.Write(byteLong);
            fs.Write(byteString);
            fs.Write(byteBool);
            fs.Write(byteDouble);

            return byteString.Length;
        }

        private void bnWriteBinary_Click(object sender, EventArgs e)
        {
            var list = new List<Person>()
            {
                new Person() { Id = 1, Name = "Vasiliy", Surname = "H", Gender = EnumGender.Male, BirthDate = new DateTime(1982, 10, 25) },
                new Person() { Id = 2, Name = "Anastacia", Surname = "S", Gender = EnumGender.Female, BirthDate = new DateTime(2000, 7, 2) },
                new Person() { Id = 3, Name = "Bogdan", Surname = "Y", Gender = EnumGender.Male, BirthDate = new DateTime(2004, 8, 27) },
            };

            var fullPath = Path.Combine(_folderName, _fileNameBinary);
            WriteToBinaryFile(fullPath, list);
        }

        private void bnReadBinary_Click(object sender, EventArgs e)
        {
            var fullPath = Path.Combine(_folderName, _fileNameBinary);
            var data = ReadFromBinaryFile<List<Person>>(fullPath);

            lbResultBinary.DataSource = data;
        }

        private void WriteToBinaryFile<T>(string fullPath, T objectToWrite)
        {
            using (Stream stream = File.Open(fullPath, FileMode.Create))
            {
#pragma warning disable SYSLIB0011
                var formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                formatter.Serialize(stream, objectToWrite);
                stream.Close();
            }
        }

        private T ReadFromBinaryFile<T>(string fullPath)
        {
            using (Stream stream = File.Open(fullPath, FileMode.Open))
            {
#pragma warning disable SYSLIB0011
                var formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                return (T)formatter.Deserialize(stream);
            }
        }

        private void bnWriteXml_Click(object sender, EventArgs e)
        {
            var list = new List<Person>()
            {
                new Person() { Id = 1, Name = "Vasiliy", Surname = "H", Gender = EnumGender.Male, BirthDate = new DateTime(1982, 10, 25) },
                new Person() { Id = 2, Name = "Anastacia", Surname = "S", Gender = EnumGender.Female, BirthDate = new DateTime(2000, 7, 2) },
                new Person() { Id = 3, Name = "Bogdan", Surname = "Y", Gender = EnumGender.Male, BirthDate = new DateTime(2004, 8, 27) },
            };

            var fullPath = Path.Combine(_folderName, _fileNameXml);
            WriteToXmlFile(fullPath, list);
        }

        private void bnReadXml_Click(object sender, EventArgs e)
        {
            var fullPath = Path.Combine(_folderName, _fileNameXml);
            var data = ReadFromXmlFile<List<Person>>(fullPath);

            lbResultXml.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (IGetData form = new FGetData())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    this._data = form.GetData();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (IGetSetData form = new FGetSetData())
            {
                form.SetData(this._data);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this._data = form.GetData();
                }
            }

            IFileOperation dataSource = new FileOperation();

            var t = dataSource.GetDataFromFile<List<Person>>("C:\\Temp\\SomeFile.Txt");
        }

        private void WriteToXmlFile<T>(string fullPath, T objectToWrite)
        {
            using (Stream stream = File.Open(fullPath, FileMode.Create))
            {
                var formatter = new XmlSerializer(typeof(T));
                formatter.Serialize(stream, objectToWrite);
                stream.Close();
            }
        }

        private T ReadFromXmlFile<T>(string fullPath)
        {
            using (Stream stream = File.Open(fullPath, FileMode.Open))
            {
                var formatter = new XmlSerializer(typeof(T));
                return (T)formatter.Deserialize(stream);
            }
        }
    }

    [Serializable]
    public enum EnumGender
    {
        Male,
        Female
    }

    [Serializable]
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public EnumGender Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Surname}, {Gender}, {BirthDate:dd/MM/yyyy}";
        }
    }

    public struct ReturnData
    {
        public long DataLong { get; set; }

        public string DataString { get; set; }

        public bool DataBool { get; set; }

        public double DataDouble { get; set; }

        public ReturnData(long inputLong, string inputString, bool inputBool, double inputDouble)
        {
            this.DataLong = inputLong;
            this.DataString = inputString;
            this.DataBool = inputBool;
            this.DataDouble = inputDouble;
        }
    }
}
