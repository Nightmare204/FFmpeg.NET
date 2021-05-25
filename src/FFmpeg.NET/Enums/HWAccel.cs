namespace FFmpeg.NET.Enums
{
    public enum HWAccel
    {
        None,
        auto,
        cuda,
        cuvid,
        dxva2,               //Direct-X Video Acceleration API, developed by Microsoft (supports Windows and XBox360).
        d3d11va,
        qsv
    }
}