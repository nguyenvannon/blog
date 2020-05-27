// Hàm khởi tạo hộp thoại cảnh báo có nút
  void _showAlert(BuildContext context, String title, String content) {
    showDialog(
        context: context,
        builder: (context) =>
            AlertDialog(
              title: Text(title),
              content: Text(content),
                actions:[
                  FlatButton(
                    child: Text("Đóng lại"),
                    onPressed: (){
                      Navigator.of(context).pop();
                    },
                  )
                ]
            )
    );
  }
  
  // Ví dụ gọi hàm:
  _showAlert(context, 'Thông báo', 'Ví dụ này được demo bởi Non Nguyen Blog!');
