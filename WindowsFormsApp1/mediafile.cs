namespace uPlayer
{
    public class MediaFile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public MediaFile(string name, string path)
        {
            Name = name;
            Path = path;
        }
    }
}
