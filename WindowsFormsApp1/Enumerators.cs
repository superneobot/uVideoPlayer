namespace uPlayer
{
    public enum Type
    {
        Media = 0,
        Torrent = 1,
        URL = 3,
        NONE = 4
    }
    public enum PlayingType
    {
        Watching = 0,
        Streaming = 1
    }
    public enum StreamType
    {
        HTTP = 0,
        RTSP = 1,
        UDP = 2,
        None = 3
    }
    public enum PLayerStyle
    {
        Normal = 0,
        Compact = 1,
        Fullscreen = 2
    }
    public enum PlayStatus
    {
        Stop = 0,
        Play = 1,
        Pause = 2,
        Opening = 3,
        Connecting = 4,
        Starting = 5,
        Stopping = 6
    }
}
