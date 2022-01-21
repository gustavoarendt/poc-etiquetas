namespace pocEtiquetas.WebApi.Handlers
{
    
    public static class ConvertHandlers
    {
        public static string ConvertBaseToString(string file) {
            byte[] pdfBytes = File.ReadAllBytes(file);
            return Convert.ToBase64String(pdfBytes);
        }
    }
}