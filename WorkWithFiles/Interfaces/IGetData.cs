namespace WorkWithFiles.Interfaces
{
    public interface IFormSimple : IDisposable
    {
        DialogResult ShowDialog();
    }

    public interface IGetData : IFormSimple
    {
        string GetData();
    }

    public interface IGetSetData : IGetData
    {
        void SetData(string data);
    }

    public interface IFileOperation : IDisposable
    {
        T GetDataFromFile<T>(string fileName);
    }

    public class FileOperation : IFileOperation
    {
        public void Dispose()
        {
            // TODO release managed resources here
        }

        public T GetDataFromFile<T>(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
