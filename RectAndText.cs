// Class này giúp lưu trữ văn bản, tọa độ (trong hình chữ nhật)
public class RectAndText {
    public iTextSharp.text.Rectangle Rect;
    public String Text;
    public RectAndText(iTextSharp.text.Rectangle rect, String text) {
        this.Rect = rect;
        this.Text = text;
    }
}
