  // Hàm khởi tạo hộp thoại cảnh báo đơn giản
  void _showAlert(BuildContext context, String title, String content) {
    showDialog(
        context: context,
        builder: (context) =>
            AlertDialog(
              title: Text(title),
              content: Text(content),
            )
    );
  }
  
  // Ví dụ gọi hàm:
  _showAlert(context, 'Thông báo', 'Ví dụ này được demo bởi Non Nguyen Blog!');
