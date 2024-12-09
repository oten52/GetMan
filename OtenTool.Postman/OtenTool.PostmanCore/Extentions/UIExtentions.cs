namespace OtenTool.PostmanCore.Extentions
{
    public static class UIExtentions
    {
        // ToDefaultFormSettings - Default Form Ayarları
        public static void ToDefaultFormSettings(this Form frm)
        {
            if (frm != null)
            {
                frm.StartPosition = FormStartPosition.CenterScreen;
            }
        }
    }
}
