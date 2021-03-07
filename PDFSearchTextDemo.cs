// File PDF cần xử lý
var testFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test.pdf");

// Văn bản cần tìm kiếm
var textToSearch = "Non Nguyen Blog";

// Khởi tạo class MyLocationTextExtractionStrategy
var t = new MyLocationTextExtractionStrategy(textToSearch);

// Trích xuất trang 1 của tài liệu PDF ở trên
using (var r = new PdfReader(testFile)) {
    var ex = PdfTextExtractor.GetTextFromPage(r, 1, t);
}

// Lặp: với mỗi "cụm văn bản" tìm được
foreach (var p in t.myPoints) {
    Console.WriteLine(string.Format("Found text {0} at {1}x{2}", p.Text, p.Rect.Left, p.Rect.Bottom));
}
